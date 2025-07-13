using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using System.Globalization;

namespace Works4me.Xurrent.GraphQL
{
    public partial class XurrentClient
    {
        /// <summary>
        /// Uploads a file at the specified file system path to the Xurrent AWS S3 storage.
        /// </summary>
        /// <param name="path">The full file-system path of the file to upload.</param>
        /// <param name="contentType">The MIME content type of the file.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{AttachmentUploadResponse}"/> representing the asynchronous operation, containing the storage key and the size (in bytes) of the uploaded file.</returns>
        public async Task<AttachmentUploadResponse> UploadAttachmentAsync(string path, string contentType, CancellationToken ct = default)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException($"'{nameof(path)}' cannot be null or whitespace.", nameof(path));

            return await UploadAttachmentAsync(new FileInfo(path), contentType, ct).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads a local file to the Xurrent AWS S3 storage. 
        /// </summary>
        /// <param name="file">A <see cref="FileInfo"/> representing the file to upload.</param>
        /// <param name="contentType">The MIME content type of the file.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{AttachmentUploadResponse}"/> representing the asynchronous operation, containing the storage key and the size (in bytes) of the uploaded file.</returns>
        public async Task<AttachmentUploadResponse> UploadAttachmentAsync(FileInfo file, string contentType, CancellationToken ct = default)
        {
            if (file is null)
                throw new ArgumentNullException(nameof(file));

            if (!file.Exists)
                throw new FileNotFoundException(file.FullName);

            using (FileStream stream = file.OpenRead())
                return await UploadAttachmentAsync(stream, file.Name, contentType, ct).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads a file stream as an attachment to Xurrent AWS S3 storage. 
        /// </summary>
        /// <param name="stream">The <see cref="Stream"/> containing the file data to upload. Must not be <c>null</c> and must support seeking in order to determine the HTTP Content-Length header.</param>
        /// <param name="fileName">The name of the file, including its extension.</param>
        /// <param name="contentType">The MIME content type of the file.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{AttachmentUploadResponse}"/> representing the asynchronous operation, containing the storage key and the size (in bytes) of the uploaded file.</returns>
        public async Task<AttachmentUploadResponse> UploadAttachmentAsync(Stream stream, string fileName, string contentType, CancellationToken ct = default)
        {
            if (stream is null)
                throw new ArgumentNullException(nameof(stream));

            if (!stream.CanSeek)
                throw new XurrentException("The stream needs to support seeking in order to determine the HTTP Content-Length header.");

            AttachmentStorage? attachmentStorage = await GetAsync<AttachmentStorage>(GetAccountId(), new AttachmentStorageQuery().SelectAll(), ct).ConfigureAwait(false);

            if (attachmentStorage is null || attachmentStorage.AllowedExtensions is null)
                throw new XurrentException("No AttachmentStorage object returned by the GraphQL API.");

            string fileExtension = Path.GetExtension(fileName).TrimStart('.');
            if (attachmentStorage.AllowedExtensions.Count > 0 && !attachmentStorage.AllowedExtensions.Contains(fileExtension, StringComparer.InvariantCultureIgnoreCase))
                throw new XurrentException($"File extension “{fileExtension}” is not allowed.");

            if (stream.Length >= attachmentStorage.SizeLimit)
                throw new XurrentException($"File size exceeded, the maximum size is {attachmentStorage.SizeLimit} bytes.");

            if (attachmentStorage.ProviderParameters is null)
                throw new XurrentException("File upload failed, invalid AttachmentStorage.ProviderParameters value.");

            if (JsonSerializer.Deserialize<S3UploadParameters>(attachmentStorage.ProviderParameters.Value.GetRawText(), _defaultJsonOptions) is not S3UploadParameters parameters)
                throw new XurrentException("File upload failed, invalid AttachmentStorage.ProviderParameters value.");

            using (MultipartFormDataContent multipartContent = new())
            {
                multipartContent.Add(new StringContent(contentType), "Content-Type");
                multipartContent.Add(new StringContent(parameters.Acl), "acl");
                multipartContent.Add(new StringContent(parameters.Key), "key");
                multipartContent.Add(new StringContent(parameters.Policy), "policy");
                multipartContent.Add(new StringContent(parameters.SuccessActionStatus.ToString(CultureInfo.InvariantCulture)), "success_action_status");
                multipartContent.Add(new StringContent(parameters.XAmzAlgorithm), "x-amz-algorithm");
                multipartContent.Add(new StringContent(parameters.XAmzCredential), "x-amz-credential");
                multipartContent.Add(new StringContent(parameters.XAmzDate), "x-amz-date");
                multipartContent.Add(new StringContent(parameters.XAmzServerSideEncryption), "x-amz-server-side-encryption");
                multipartContent.Add(new StringContent(parameters.XAmzSignature), "x-amz-signature");
                multipartContent.Add(new StreamContent(stream), "file", fileName);

                using (HttpRequestMessage requestMessage = new(HttpMethod.Post, attachmentStorage.UploadUri) { Content = multipartContent })
                {
                    Guid logId = Guid.NewGuid();
                    WriteDebug(logId, requestMessage, "***");

                    Stopwatch stopwatch = Stopwatch.StartNew();
                    using (HttpResponseMessage responseMessage = await _httpClient.SendAsync(requestMessage, ct).ConfigureAwait(false))
                    {
                        stopwatch.Stop();
                        WriteDebug(logId, requestMessage, null, stopwatch.Elapsed, responseMessage);

#if NET5_0_OR_GREATER
                        using (StreamReader reader = new(await responseMessage.Content.ReadAsStreamAsync(ct).ConfigureAwait(false)))
                        {
                            string data = await reader.ReadToEndAsync(ct).ConfigureAwait(false);
#else
                        using (StreamReader reader = new(await responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false)))
                        {
                            string data = await reader.ReadToEndAsync().ConfigureAwait(false);
#endif
                            if (XDocument.Parse(data).Descendants("Key").FirstOrDefault() is XElement keyElement)
                            {
                                return new AttachmentUploadResponse
                                {
                                    Key = keyElement.Value,
                                    Size = stream.Length
                                };
                            }
                            throw new XurrentException($"Upload succeeded but no <Key> element found in response:{Environment.NewLine}{data}");
                        }
                    }
                }
            }
        }

    }
}
