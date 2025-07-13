using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Works4me.Xurrent.GraphQL.Utilities;
using Works4me.Xurrent.GraphQL.Extensions;

namespace Works4me.Xurrent.GraphQL
{
    public partial class XurrentClient
    {
        private readonly bool traceEnabled = Trace.Listeners is not null && Trace.Listeners.Count > 0;
        private readonly JsonSerializerOptions traceSerializationoptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = false };

        /// <summary>
        /// Writes a trace message containing details of the HTTP request or response for diagnostic purposes.
        /// </summary>
        /// <param name="logIdentifier">The unique identifier for the log entry.</param>
        /// <param name="requestMessage">The <see cref="HttpRequestMessage"/> to log.</param>
        /// <param name="content">The optional HTTP content to include in the trace.</param>
        /// <param name="responseTime">The optional duration representing the response time, in milliseconds.</param>
        /// <param name="responseMessage">The optional <see cref="HttpResponseMessage"/> to log.</param>
        private void WriteDebug(Guid logIdentifier, HttpRequestMessage requestMessage, string? content = null, TimeSpan? responseTime = null, HttpResponseMessage? responseMessage = null)
        {
            if (!traceEnabled)
                return;

            bool isResponse = responseTime is not null;
            XurrentTraceMessage message = new()
            {
                Id = logIdentifier,
                AccountId = isResponse ? null : (requestMessage.Headers.TryGetValues(Constants.AccountHeader, out IEnumerable<string>? headerValues) ? headerValues.FirstOrDefault() : null),
                Method = isResponse ? null : requestMessage.Method.ToString(),
                Uri = isResponse ? null : requestMessage.RequestUri,
                Content = isResponse ? null : content,
                ResponseCode = isResponse ? responseMessage?.StatusCode : null,
                RetryAfterInMilliseconds = isResponse && responseMessage is not null && (int)responseMessage.StatusCode == 429 ? responseMessage.Headers.TryGetInt("retry-after") is int retryAfter ? retryAfter * 1000 : null : null,
                ResponseTimeInMilliseconds = isResponse ? (int?)responseTime?.TotalMilliseconds : null
            };

            try
            {
                Trace.WriteLine(JsonSerializer.Serialize(message, traceSerializationoptions));
                Trace.Flush();
            }
            catch (Exception ex) when (ex is JsonException or IOException or UnauthorizedAccessException)
            {
            }
        }
    }
}
