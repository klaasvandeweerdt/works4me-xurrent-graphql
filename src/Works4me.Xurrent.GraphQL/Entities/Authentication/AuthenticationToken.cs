using System;
using System.Threading;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents a Xurrent authentication token, managing its value, type, expiration, and rate/cost limits in a thread-safe manner.
    /// </summary>
    public sealed class AuthenticationToken : IDisposable
    {
        private readonly int _id;
        private readonly string? _clientId;
        private readonly string? _clientSecret;
        private string _token = string.Empty;
        private string _tokenType = string.Empty;
        private DateTimeOffset _tokenExpires = DateTimeOffset.MinValue;
        private DateTimeOffset? _retryAfter;
        private readonly AuthenticationTokenLimit _requestLimit = new();
        private readonly AuthenticationTokenLimit _costLimit = new();
        private readonly ReaderWriterLockSlim _lock = new();
        private bool _disposedValue;

        /// <summary>
        /// Gets the unique identifier for this token instance.
        /// </summary>
        internal int Id
        {
            get => _id;
        }

        /// <summary>
        /// Gets the OAuth 2.0 client grant client secret.
        /// </summary>
        public string? ClientId
        {
            get => _clientId;
        }

        /// <summary>
        /// Get the Xurrent OAuth 2.0 client grant client secret.
        /// </summary>
        internal string? ClientSecret
        {
            get => _clientSecret;
        }

        /// <summary>
        /// Gets the current authentication token string.
        /// </summary>
        internal string Token
        {
            get
            {
                _lock.EnterReadLock();
                try 
                {
                    return _token;
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Gets the token type (for example, "Bearer").
        /// </summary>
        internal string TokenType
        {
            get
            {
                _lock.EnterReadLock();
                try
                {
                    return _tokenType;
                }
                finally
                {
                    _lock.ExitReadLock(); 
                }
            }
        }

        /// <summary>
        /// Gets the request limit information: total limit, remaining requests, and reset time.
        /// </summary>
        public AuthenticationTokenLimit RequestLimit
        {
            get
            {
                _lock.EnterReadLock();
                try
                {
                    return _requestLimit.Clone();
                }
                finally 
                {
                    _lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Gets the cost limit information: total cost points limit, remaining points, and reset time.
        /// </summary>
        public AuthenticationTokenLimit CostLimit
        {
            get
            {
                _lock.EnterReadLock();
                try 
                {
                    return _costLimit.Clone(); 
                }
                finally 
                {
                    _lock.ExitReadLock(); 
                }
            }
        }

        /// <summary>
        /// Gets the timestamp until which this token should not be used due to a 429 Too Many Requests response.<br />
        /// When set, the token should be considered unavailable until the specified time has passed.<br /> 
        /// Null indicates no active rate-limiting window.<br />
        /// </summary>
        public DateTimeOffset? RetryAfter
        {
            get
            {
                _lock.EnterReadLock();
                try
                {
                    return _retryAfter;
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance using a personal access token.
        /// </summary>
        /// <param name="personalAccessToken">The personal access token string.</param>
        public AuthenticationToken(string personalAccessToken)
        {
            _token = personalAccessToken ?? throw new ArgumentNullException(nameof(personalAccessToken));
            _tokenExpires = DateTimeOffset.MaxValue;
            _tokenType = "Bearer";
            _id = StringComparer.Ordinal.GetHashCode(personalAccessToken);
        }

        /// <summary>
        /// Initializes a new instance using OAuth 2.0 client credentials flow.
        /// </summary>
        /// <param name="clientId">The OAuth 2.0 client ID.</param>
        /// <param name="clientSecret">The OAuth 2.0 client secret.</param>
        public AuthenticationToken(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _tokenExpires = DateTimeOffset.MinValue;
            _tokenType = string.Empty;
            _id = StringComparer.Ordinal.GetHashCode(_clientId + _clientSecret);
        }

        /// <summary>
        /// Atomically updates the token string, its type, and the expiration timestamp.
        /// </summary>
        /// <param name="token">The new token string.</param>
        /// <param name="tokenType">The new token type (e.g., "Bearer").</param>
        /// <param name="expiresInSeconds">Seconds from now when the token will expire.</param>
        internal void SetToken(string token, string tokenType, int expiresInSeconds)
        {
            _lock.EnterWriteLock();
            try
            {
                _token = token;
                _tokenType = tokenType;
                _tokenExpires = DateTimeOffset.UtcNow.AddSeconds(expiresInSeconds);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Determines whether the token has expired or will expire within the next two minute.
        /// </summary>
        /// <returns><c>true</c> if the token is expired or near expiration; otherwise <c>false</c>.</returns>
        internal bool IsTokenExpired()
        {
            _lock.EnterReadLock();
            try
            {
                return _tokenExpires < DateTimeOffset.UtcNow.AddMinutes(2);
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        /// <summary>
        /// Sets the <see cref="RetryAfter"/> property to the current UTC time plus the specified number of seconds, indicating when the token can be retried after a rate-limiting response (HTTP 429).
        /// </summary>
        /// <param name="seconds">
        /// The number of seconds to wait before this token can be used again.<br />
        /// If <c>null</c>, the method returns without making changes.<br />
        /// </param>
        internal void UpdateRetryAfter(int? seconds)
        {
            _lock.EnterWriteLock();
            try
            {
                if (seconds is null)
                {
                    _retryAfter = null;
                    return;
                }

                DateTimeOffset now = DateTimeOffset.UtcNow;
                if (_retryAfter is not null && _retryAfter > now)
                {
                    _retryAfter = _retryAfter.Value.AddSeconds(seconds.Value);
                }
                else
                {
                    _retryAfter = now.AddSeconds(seconds.Value);
                }
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Atomically updates both rate-limit and cost-limit properties in one operation.<br />
        /// Also clears the <see cref="RetryAfter"/> property if it is set and has expired.<br />
        /// </summary>
        /// <param name="requestLimit">The total request limit for the period.</param>
        /// <param name="requestRemaining">The number of remaining requests.</param>
        /// <param name="requestReset">The time when the request limit resets.</param>
        /// <param name="costLimit">The total cost points limit for the period.</param>
        /// <param name="costRemaining">The number of remaining cost points.</param>
        /// <param name="costReset">The time when the cost limit resets.</param>
        internal void UpdateLimits(int? requestLimit, int? requestRemaining, DateTimeOffset? requestReset, int? costLimit, int? costRemaining, DateTimeOffset? costReset)
        {
            if (requestLimit is null && requestRemaining is null && requestReset is null && costLimit is null && costRemaining is null && costReset is null)
                return;

            _lock.EnterWriteLock();
            try
            {
                _requestLimit.Limit = requestLimit ?? _requestLimit.Limit;
                _requestLimit.Remaining = requestRemaining ?? _requestLimit.Remaining;
                _requestLimit.Reset = requestReset ?? _requestLimit.Reset;

                _costLimit.Limit = costLimit ?? _costLimit.Limit;
                _costLimit.Remaining = costRemaining ?? _costLimit.Remaining;
                _costLimit.Reset = costReset ?? _costLimit.Reset;

                if (_retryAfter.HasValue && _retryAfter < DateTimeOffset.UtcNow)
                    _retryAfter = null;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Releases the resources used by this <see cref="AuthenticationTokenCollection"/>.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _lock?.Dispose();
                }
                _disposedValue = true;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// Disposes this instance and suppresses finalization.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
