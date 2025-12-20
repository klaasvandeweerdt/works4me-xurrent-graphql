using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// A thread-safe collection of <see cref="AuthenticationToken"/> instances that selects the best token based on weighted request and cost limits.
    /// </summary>
    public sealed class AuthenticationTokenCollection : IEnumerable<AuthenticationToken>, IDisposable
    {
        private readonly List<AuthenticationToken> _tokens = new();
        private readonly ReaderWriterLockSlim _lock = new();
        private readonly object _disposeLock = new();
        private bool _disposedValue;

        /// <summary>
        /// Gets or sets the weight applied to the percentage of remaining requests when scoring tokens. Default is 0.6.
        /// </summary>
        public double RequestWeight { get; private set; } = 0.6;

        /// <summary>
        /// Gets or sets the weight applied to the percentage of remaining cost points when scoring tokens. Default is 0.4.
        /// </summary>
        public double CostWeight { get; private set; } = 0.4;

        /// <summary>
        /// Initializes a new instance containing no access tokens or OAuth2 client credentials.
        /// </summary>
        public AuthenticationTokenCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance containing the specified <see cref="AuthenticationToken"/>.
        /// </summary>
        /// <param name="authenticationToken">The token instance to add.</param>
        public AuthenticationTokenCollection(AuthenticationToken authenticationToken)
        {
            Add(authenticationToken);
        }

        /// <summary>
        /// Gets the best available token based on weighted scoring of request and cost limits.
        /// Throws if no tokens are present or if all tokens have exhausted their quotas.
        /// </summary>
        /// <returns>The <see cref="AuthenticationToken"/> with the highest computed score.</returns>
        /// <exception cref="XurrentException">Thrown if the collection is empty or if all tokens have exhausted their quotas.</exception>
        public AuthenticationToken Get()
        {
            List<AuthenticationToken> snapshot;
            _lock.EnterReadLock();
            try
            {
                if (_tokens.Count == 0)
                    throw new XurrentException("The collection does not contain any token.");

                snapshot = new List<AuthenticationToken>(_tokens);
            }
            finally
            {
                _lock.ExitReadLock();
            }

            (AuthenticationToken Token, double Score) = snapshot
                .Select(t =>
                {
                    AuthenticationTokenLimit req = t.RequestLimit;
                    AuthenticationTokenLimit cost = t.CostLimit;
                    double requestScore = req.Limit > 0 ? (double)req.Remaining / req.Limit : 0.0;
                    double costScore = cost.Limit > 0 ? (double)cost.Remaining / cost.Limit : 0.0;
                    double score = requestScore * RequestWeight + costScore * CostWeight;
                    return (Token: t, Score: score);
                })
                .Where(x => x.Score > 0)
                .OrderByDescending(x => x.Score)
                .ThenBy(x => x.Token.RetryAfter ?? DateTimeOffset.MinValue)
                .FirstOrDefault();

            if (Token is null)
                throw new XurrentException("All authentication tokens have been exhausted.");

            if (Token.RequestLimit.Remaining < 1 && Token.RequestLimit.Reset > DateTimeOffset.UtcNow)
                throw new XurrentException("There are no remaining API requests for the provided authentication tokens.");

            if (Token.CostLimit.Remaining < 1 && Token.CostLimit.Reset > DateTimeOffset.UtcNow)
                throw new XurrentException("There are no remaining cost points for the provided authentication tokens.");

            return Token;
        }

        /// <summary>
        /// Adds the specified <see cref="AuthenticationToken"/> to the collection if it is not already present.
        /// </summary>
        /// <param name="authenticationToken">The token to add.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="authenticationToken"/> is null.</exception>
        /// <exception cref="XurrentException">If both the token string and client credentials are missing or whitespace.</exception>
        public void Add(AuthenticationToken authenticationToken)
        {
            if (authenticationToken is null)
                throw new ArgumentNullException(nameof(authenticationToken));

            _lock.EnterWriteLock();
            try
            {
                if (string.IsNullOrWhiteSpace(authenticationToken.Token) && (string.IsNullOrWhiteSpace(authenticationToken.ClientId) || string.IsNullOrWhiteSpace(authenticationToken.ClientSecret)))
                {
                    throw new XurrentException("Missing Client Id and Client Secret, or Personal Access Token.");
                }

                if (!_tokens.Any(t => t.Id == authenticationToken.Id))
                {
                    _tokens.Add(authenticationToken);
                }
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Removes the specified <see cref="AuthenticationToken"/> from the collection.
        /// </summary>
        /// <param name="authenticationToken">The token instance to remove.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="authenticationToken"/> is null.</exception>
        public void Remove(AuthenticationToken authenticationToken)
        {
            if (authenticationToken is null)
                throw new ArgumentNullException(nameof(authenticationToken));

            _lock.EnterWriteLock();
            try
            {
                _tokens.RemoveAll(t => t.Id == authenticationToken.Id);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Removes all tokens from the collection.
        /// </summary>
        public void Clear()
        {
            _lock.EnterWriteLock();
            try
            {
                _tokens.Clear();
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Configures the scoring weights used to evaluate authentication tokens based on remaining requests and remaining cost points.
        /// </summary>
        /// <param name="requestWeight">
        /// The weight applied to the percentage of remaining requests when scoring tokens. <br />
        /// Must be a value between 0.0 and 1.0. The sum of <paramref name="requestWeight"/> and <paramref name="costWeight"/> must equal 1.0. <br />
        /// </param>
        /// <param name="costWeight">
        /// The weight applied to the percentage of remaining cost points when scoring tokens. <br />
        /// Must be a value between 0.0 and 1.0. The sum of <paramref name="requestWeight"/> and <paramref name="costWeight"/> must equal 1.0.<br />
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if either weight is outside the range 0.0 to 1.0, or if their sum does not equal 1.0.</exception>
        public void ConfigureTokenWeight(double requestWeight, double costWeight)
        {
            if (requestWeight < 0.0 || requestWeight > 1.0)
                throw new ArgumentOutOfRangeException(nameof(requestWeight), "Request weight must be between 0.0 and 1.0.");

            if (costWeight < 0.0 || costWeight > 1.0)
                throw new ArgumentOutOfRangeException(nameof(costWeight), "Cost weight must be between 0.0 and 1.0.");

            if (Math.Abs(requestWeight + costWeight - 1.0) > 0.0001)
                throw new ArgumentOutOfRangeException(nameof(costWeight), "The sum of requestWeight and costWeight must be 1.0.");

            _lock.EnterWriteLock();
            try
            {
                RequestWeight = requestWeight;
                CostWeight = costWeight;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through a thread-safe snapshot of the collection.
        /// </summary>
        /// <returns>An enumerator over the current tokens.</returns>
        public IEnumerator<AuthenticationToken> GetEnumerator()
        {
            List<AuthenticationToken> snapshot;
            _lock.EnterReadLock();
            try
            {
                snapshot = new List<AuthenticationToken>(_tokens);
            }
            finally
            {
                _lock.ExitReadLock();
            }
            return snapshot.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Releases the resources used by this <see cref="AuthenticationTokenCollection"/>.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        private void Dispose(bool disposing)
        {
            lock (_disposeLock)
            {
                if (_disposedValue)
                    throw new ObjectDisposedException(nameof(AuthenticationToken));

                if (!_disposedValue)
                {
                    if (disposing)
                    {
                        _lock?.Dispose();
                    }
                    _disposedValue = true;
                }
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
