using System;
using System.Net.Http;
using Works4me.Xurrent.GraphQL.Utilities;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="HttpResponseMessage"/> to validate HTTP response status and content type.
    /// </summary>
    internal static class HttpResponseMessageExtensions
    {
        /// <summary>
        /// Throws a <see cref="XurrentExecutionException"/> if the HTTP response status is not successful or if the response content type is not JSON (<c>application/json</c>).
        /// </summary>
        /// <param name="responseMessage">The HTTP response message to validate.</param>
        /// <exception cref="XurrentExecutionException">Thrown if the response status is not successful or if the content type is not JSON.</exception>
        public static void ThrowIfInvalidResponse(this HttpResponseMessage responseMessage)
        {
            try
            {
                responseMessage.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new XurrentExecutionException($"Invalid response, {responseMessage.ReasonPhrase}.", ex);
            }

            string? mediaType = responseMessage.Content.Headers.ContentType?.MediaType;
            if (mediaType is null || !mediaType.Equals(Constants.ApplicationJsonMediaType, StringComparison.OrdinalIgnoreCase))
                throw new XurrentExecutionException($"Unsupported Content-Type: {mediaType ?? "unknown"}. Status: {responseMessage.StatusCode}.");
        }
    }
}
