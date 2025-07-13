using System;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Works4me.Xurrent.GraphQL
{
    public partial class XurrentClient
    {
        /// <summary>
        /// Creates a new event using the <see href="https://developer.4me.com/v1/requests/events/">4me events API</see>.
        /// <para>
        /// <b>Note:</b> Only the <see cref="Request.Id"/> (<c>nodeID</c>) and <see cref="Request.RequestId"/> (<c>id</c>) are set in the returned <see cref="Request"/> object.
        /// Other properties may be missing, as the response is not fully mapped.
        /// </para>
        /// </summary>
        /// <param name="requestEventCreateInput">The event's data.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns> A <see cref="Request"/> object containing the <see cref="Request.Id"/> (the <c>nodeID</c> from the API response) and <see cref="Request.RequestId"/> (the <c>id</c> from the API response).</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="requestEventCreateInput"/> is <c>null</c>.</exception>
        /// <exception cref="XurrentExecutionException">Thrown if <c>nodeID</c> or <c>id</c> are missing from the response.</exception>
        public async Task<Request> CreateEventAsync(RequestEventCreateInput requestEventCreateInput, CancellationToken ct = default)
        {
            if (requestEventCreateInput is null)
                throw new ArgumentNullException(nameof(requestEventCreateInput));

            AuthenticationToken token = await GetAuthenticationTokenAsync(ct).ConfigureAwait(false);

            using (HttpRequestMessage requestMessage = CreateHttpRequest(GetAccountId(), token, $"{_restUrl}/events"))
            {
                using (JsonDocument document = await SendHttpRequestAsync(requestMessage, requestEventCreateInput.GetHttpRequestBody(), token, true, ct).ConfigureAwait(false))
                {
                    if (document.RootElement.TryGetProperty("nodeID", out JsonElement nodeIdElement) &&  nodeIdElement.GetString() is string nodeID
                        && document.RootElement.TryGetProperty("id", out JsonElement idElement) && idElement.GetInt64() is long id)
                    {
                        return new Request()
                        {
                            Id = nodeID,
                            RequestId = id.ToString(CultureInfo.InvariantCulture)
                        };
                    }
                    throw new XurrentExecutionException("Unprocessable response entity: nodeID is missing in the response.");
                }
            }
        }
    }
}
