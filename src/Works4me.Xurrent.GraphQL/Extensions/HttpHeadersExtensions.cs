using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    internal static class HttpHeadersExtensions
    {
        private static readonly DateTimeOffset UnixEpoch = new(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        /// <summary>
        /// Tries to read the first header value as an int.
        /// </summary>
        public static int? TryGetInt(this HttpHeaders headers, string headerName)
        {
            if (headers is null)
                throw new ArgumentNullException(nameof(headers));

            if (string.IsNullOrWhiteSpace(headerName))
                throw new ArgumentException($"'{nameof(headerName)}' cannot be null or whitespace.", nameof(headerName));

            if (headers.TryGetValues(headerName, out IEnumerable<string>? headerValues))
            {
                string? headerValue = headerValues.FirstOrDefault();
                if (int.TryParse(headerValue, out int value))
                {
                    return value;
                }
            }

            return null;
        }

        /// <summary>
        /// Tries to read the first header value (Unix seconds) as a DateTimeOffset.
        /// </summary>
        public static DateTimeOffset? TryGetUnixTime(this HttpHeaders headers, string headerName)
        {
            if (headers is null)
                throw new ArgumentNullException(nameof(headers));

            if (string.IsNullOrWhiteSpace(headerName))
                throw new ArgumentException($"'{nameof(headerName)}' cannot be null or whitespace.", nameof(headerName));

            if (headers.TryGetValues(headerName, out IEnumerable<string>? headerValues))
            {
                string? headerValue = headerValues.FirstOrDefault();
                if (long.TryParse(headerValue, out long value))
                {
                    DateTimeOffset result = UnixEpoch.AddSeconds(value);
                    return result;
                }
            }

            return null;
        }
    }
}
