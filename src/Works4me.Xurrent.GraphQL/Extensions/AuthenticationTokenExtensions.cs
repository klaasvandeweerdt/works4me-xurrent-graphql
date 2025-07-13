using System.Net.Http.Headers;
using System;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="AuthenticationToken"/> to update its rate-limit and cost-limit values from HTTP headers.
    /// </summary>
    public static class AuthenticationTokenExtensions
    {
        /// <summary>
        /// Reads rate-limit and cost-limit headers and applies them to the token.
        /// </summary>
        /// <param name="token">The <see cref="AuthenticationToken"/> whose limits are to be updated.</param>
        /// <param name="headers">The <see cref="HttpHeaders"/> containing rate-limit and cost-limit values.</param>
        public static void UpdateLimitsFromHeaders(this AuthenticationToken token, HttpHeaders headers)
        {
            if (token is null)
                throw new ArgumentNullException(nameof(token));

            if (headers is null)
                throw new ArgumentNullException(nameof(headers));

            token.UpdateLimits(
                headers.TryGetInt("x-ratelimit-limit"),
                headers.TryGetInt("x-ratelimit-remaining"),
                headers.TryGetUnixTime("x-ratelimit-reset"),
                headers.TryGetInt("x-costlimit-limit"),
                headers.TryGetInt("x-costlimit-remaining"),
                headers.TryGetUnixTime("x-costlimit-reset")
            );
        }

        /// <summary>
        /// Reads the "Retry-After" header from the specified <see cref="HttpHeaders"/> and updates the <see cref="AuthenticationToken"/>'s retry-after property.
        /// </summary>
        /// <param name="token">The <see cref="AuthenticationToken"/> whose retry-after property is to be updated.</param>
        /// <param name="headers">The <see cref="HttpHeaders"/> containing the retry-after value.</param>
        public static void UpdateRetryAfter(this AuthenticationToken token, HttpHeaders headers)
        {
            if (token is null)
                throw new ArgumentNullException(nameof(token));

            if (headers is null)
                throw new ArgumentNullException(nameof(headers));

            token.UpdateRetryAfter(headers.TryGetInt("retry-after"));
        }
    }
}
