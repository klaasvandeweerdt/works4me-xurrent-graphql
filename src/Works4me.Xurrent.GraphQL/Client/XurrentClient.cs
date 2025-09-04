using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Builders;
using Works4me.Xurrent.GraphQL.Extensions;
using Works4me.Xurrent.GraphQL.Serialization;
using Works4me.Xurrent.GraphQL.Utilities;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Mutations;
using System.Reflection;
using Works4me.Xurrent.GraphQL.Attributes;
using System.Collections.Immutable;
using Microsoft.Extensions.Logging;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Provides the primary client for interacting with the Xurrent GraphQL API, including query, mutation, paging, and attachment operations.
    /// </summary>
    public partial class XurrentClient : IDisposable
    {
        private readonly JsonSerializerOptions _defaultJsonOptions;
        private readonly HttpClient _httpClient;
        private readonly HttpClient _httpImportExportClient;

        private readonly AuthenticationTokenCollection _authenticationTokens;
        private readonly RateLimiter _rateLimiter;
        private readonly SemaphoreSlim _refreshLock = new(1, 1);
        private readonly object _accountIdLock = new();
        private readonly XurrentClientBulkOperations _bulkOperations;

        private readonly string _url;
        private readonly string _restUrl;
        private readonly string _oauth2Url;
        private readonly bool _disposeAuthenticationTokens;

        private string _accountId; 
        private bool _disposedValue;
        private int _defaultItemsPerRequest = 100;
        private int _maxRequestsPerQuery = 1000;
        private int _maxConnectionDepth = 2;

        /// <summary>
        /// Gets or sets the current account ID. Cannot be null or whitespace.
        /// </summary>
        public string AccountId
        {
            get
            {
                lock (_accountIdLock) 
                {
                    return _accountId; 
                }
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"'{nameof(value)}' cannot be null or empty.", nameof(value));

                _accountId = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum number of consecutive requests the SDK will make to retrieve additional items for a single query.
        /// </summary>
        /// <remarks>
        /// This setting controls how many follow-up requests the SDK is allowed to perform automatically when fetching large result sets that exceed the per-request item limit.<br />
        /// The default value is 1000, which ensures complete data retrieval for most scenarios.<br />
        /// However, when working with very large datasets, it is recommended to lower this value to reduce the risk of exceeding API rate limits, such as the 3600 requests per hour restriction when using a single token.<br />
        /// </remarks>
        /// <value>The default value is 1000. Must be between 1 and 10000, inclusive.</value>
        /// <exception cref="XurrentQueryException">Thrown if the value is less than 1 or greater than 10000.</exception>
        public int MaximumRequestsPerQuery
        {
            get => _maxRequestsPerQuery;
            set
            {
                if (value < 1 || value > 10000)
                    throw new XurrentQueryException($"Invalid maximum requests: {value}. {nameof(MaximumRequestsPerQuery)} must be between 1 and 10000, inclusive.");

                _maxRequestsPerQuery = value;
            }
        }

        /// <summary>
        /// Gets or sets the default number of items to return per request.
        /// </summary>
        /// <value>The default value is 100. Must be between 1 and 100, inclusive.</value>
        /// <exception cref="XurrentQueryException">Thrown if the value is less than 1 or greater than 100.</exception>
        public int DefaultItemsPerRequest
        {
            get => _defaultItemsPerRequest;
            set
            {
                if (value < 1 || value > 100)
                    throw new XurrentQueryException($"Invalid item per request: {value}. {nameof(DefaultItemsPerRequest)} must be between 1 and 100, inclusive.");

                _defaultItemsPerRequest = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum allowed depth of nested connection fields in the GraphQL query.
        /// <para><b>Warning:</b> Increasing this value can significantly impact performance due to additional pagination handling in deeply nested connection queries.</para>
        /// </summary>
        /// <value>The default value is 2. Must be between 1 and 13, inclusive.</value>
        public int MaximumConnectionDepth
        {
            get => _maxConnectionDepth;
            set
            {
                if (value < 1 || value > 13)
                    throw new XurrentQueryException($"Invalid maximum query depth: {value}. {nameof(MaximumConnectionDepth)} must be between 1 and 13, inclusive.");

                _maxConnectionDepth = value;
            }
        }

        /// <summary>
        /// Gets the set of bulk import and export operations for this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="Bulk"/> property provides grouped access to all bulk data transfer operations, including starting exports and imports, polling for status, and downloading results.
        /// </remarks>
        public XurrentClientBulkOperations Bulk
        {
            get => _bulkOperations;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="XurrentClient"/> using a single <see cref="AuthenticationToken"/>.
        /// </summary>
        /// <param name="authenticationToken">The authentication token to use for requests.</param>
        /// <param name="accountId">The account ID associated with this client.</param>
        /// <param name="environment">The environment (e.g., production, staging) to target.</param>
        /// <param name="environmentRegion">The region of the environment (e.g., EU, US) to target.</param>
        /// <param name="logger">The logger instance to use for diagnostic and trace output, or <c>null</c> to disable logging.</param>
        public XurrentClient(AuthenticationToken authenticationToken, string accountId, EnvironmentType environment, EnvironmentRegion environmentRegion, ILogger<XurrentClient>? logger = null)
            : this(new AuthenticationTokenCollection(authenticationToken), accountId, EndpointUrlBuilder.GetBaseUrl(environmentRegion, environment), logger)
        {
            _disposeAuthenticationTokens = true;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="XurrentClient"/> using a single <see cref="AuthenticationToken"/> and domain name.
        /// </summary>
        /// <param name="authenticationToken">The authentication token to use for requests.</param>
        /// <param name="accountId">The account ID associated with this client.</param>
        /// <param name="domainName">The domain name of the Xurrent API endpoint.</param>
        /// <param name="logger">The logger instance to use for diagnostic and trace output, or <c>null</c> to disable logging.</param>
        public XurrentClient(AuthenticationToken authenticationToken, string accountId, string domainName, ILogger<XurrentClient>? logger = null)
            : this(new AuthenticationTokenCollection(authenticationToken), accountId, domainName, logger)
        {
            _disposeAuthenticationTokens = true;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="XurrentClient"/> using a collection of authentication tokens.
        /// </summary>
        /// <param name="authenticationTokens">The collection of authentication tokens to use.</param>
        /// <param name="accountId">The account ID associated with this client.</param>
        /// <param name="environment">The environment (e.g., production, staging) to target.</param>
        /// <param name="environmentRegion">The region of the environment (e.g., EU, US) to target.</param>
        /// <param name="logger">The logger instance to use for diagnostic and trace output, or <c>null</c> to disable logging.</param>
        public XurrentClient(AuthenticationTokenCollection authenticationTokens, string accountId, EnvironmentType environment, EnvironmentRegion environmentRegion, ILogger<XurrentClient>? logger = null)
            : this(authenticationTokens, accountId, EndpointUrlBuilder.GetBaseUrl(environmentRegion, environment), logger)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="XurrentClient"/> using a collection of authentication tokens and domain name.
        /// </summary>
        /// <param name="authenticationTokens">The collection of authentication tokens to use.</param>
        /// <param name="accountId">The account ID associated with this client.</param>
        /// <param name="domainName">The domain name of the Xurrent API endpoint.</param>
        /// <param name="logger">The logger instance to use for diagnostic and trace output, or <c>null</c> to disable logging.</param>
        public XurrentClient(AuthenticationTokenCollection authenticationTokens, string accountId, string domainName, ILogger<XurrentClient>? logger = null)
        {
            if (string.IsNullOrWhiteSpace(accountId))
                throw new ArgumentException($"'{nameof(accountId)}' cannot be null or empty.", nameof(accountId));

            if (string.IsNullOrWhiteSpace(domainName))
                throw new ArgumentException($"'{nameof(domainName)}' cannot be null or empty.", nameof(domainName));

            if (authenticationTokens is null || !authenticationTokens.Any())
                throw new ArgumentException($"'{nameof(authenticationTokens)}' cannot be null or empty.", nameof(authenticationTokens));

            _rateLimiter = RateLimiter.Instance;
            _url = EndpointUrlBuilder.Get(domainName);
            _restUrl = EndpointUrlBuilder.GetRest(domainName);
            _oauth2Url = EndpointUrlBuilder.GetOAuth2(domainName);

            _authenticationTokens = authenticationTokens;
            _accountId = accountId;

            _defaultJsonOptions = SerializationConfiguration.CreateJsonOptions();

#if NET5_0_OR_GREATER
            _httpClient = new HttpClient(new SocketsHttpHandler() { PooledConnectionLifetime = TimeSpan.FromMinutes(5) }, disposeHandler: true);
#else
            _httpClient = new(new ServicePointLifetimeHandler(TimeSpan.FromMinutes(5), new HttpClientHandler()), disposeHandler: true);
#endif

            _logger = logger;

            _httpImportExportClient = new();

            _bulkOperations = new(this);
        }

        /// <summary>
        /// Executes a GraphQL query and returns a single entity of type <typeparamref name="TEntity"/> or null if none found.
        /// </summary>
        /// <typeparam name="TEntity">The entity type, which must implement <see cref="IDataItem"/> and have a parameterless constructor.</typeparam>
        /// <param name="accountId">The account ID against which to execute the query.</param>
        /// <param name="query">The <see cref="IQuery"/> to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing the single <typeparamref name="TEntity"/> or <c>null</c>.</returns>
        private async Task<TEntity?> GetAsync<TEntity>(string accountId, IQuery query, CancellationToken ct)
            where TEntity : IDataItem, new()
        {
            ReadOnlyDataCollection<TEntity> result = await GetAsync<TEntity>(accountId, query, 1, 1, ct).ConfigureAwait(false);
            return result.FirstOrDefault();
        }

        /// <summary>
        /// Executes a GraphQL query and returns a full <see cref="DataCollection{TEntity}"/> of results, performing pagination as needed.
        /// </summary>
        /// <typeparam name="TEntity">The entity type, which must implement <see cref="IDataItem"/> and have a parameterless constructor.</typeparam>
        /// <param name="accountId">The account ID against which to execute the query.</param>
        /// <param name="query">The <see cref="IQuery"/> to execute.</param>
        /// <param name="defaultItemsPerRequest">The default number of items per request.</param>
        /// <param name="maxRequests">The maximum number of paged requests to make.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing a <see cref="DataCollection{TEntity}"/> of results.</returns>
        private async Task<ReadOnlyDataCollection<TEntity>> GetAsync<TEntity>(string accountId, IQuery query, int defaultItemsPerRequest, int maxRequests, CancellationToken ct)
            where TEntity : IDataItem, new()
        {
            ExecutionBuilder builder = new(query, defaultItemsPerRequest);

            int currentConnectionDepth = builder.GetMaximumConnectionDepth();
            if (currentConnectionDepth > _maxConnectionDepth)
                throw new XurrentExecutionException($"The query exceeds the maximum allowed connection depth. The maximum is {_maxConnectionDepth}, but the query contains a connection depth of {currentConnectionDepth}.");

            DataCollection<TEntity> results = new();
            JsonSerializerOptions localJsonOptions = SerializationConfiguration.CreateJsonOptions(builder.GetInterfaceMappings());

            while (maxRequests > 0)
            {
                string content = JsonSerializer.Serialize(new { query = builder.GetGraphQLQuery() });
                AuthenticationToken token = await GetAuthenticationTokenAsync(ct).ConfigureAwait(false);

                using (HttpRequestMessage requestMessage = CreateHttpRequest(accountId, token))
                {
                    using (JsonDocument document = await SendHttpRequestAsync(requestMessage, content, token, true, ct).ConfigureAwait(false))
                    {
                        if (!document.TryGetElementByPath(new string[] { "data", builder.GetResponseObjectName() }, out JsonElement element))
                            return new ReadOnlyDataCollection<TEntity>(results);

                        PagedResponse<TEntity> result = new();
                        if (builder.IsResponseCollection() && JsonSerializer.Deserialize<PagedResponse<TEntity>>(element, localJsonOptions) is PagedResponse<TEntity> items)
                        {
                            result = items;
                        }
                        else if (JsonSerializer.Deserialize<TEntity>(element, localJsonOptions) is TEntity item)
                        {
                            result.Data.Add(item);
                        }

                        results.AddRange(result.Data);
                        int? nextPageCursor = builder.UpdateCursors(query.Name, result);
                        
                        if (nextPageCursor is null)
                        {
                            break;
                        }
                        
                        if (nextPageCursor == 0)
                        {
                            maxRequests--;
                        }
                    }
                }
            }

            return new ReadOnlyDataCollection<TEntity>(results);
        }

        /// <summary>
        /// Executes a GraphQL query and streams individual results, performing underlying pagination as needed.
        /// </summary>
        /// <typeparam name="TEntity">The entity type, which must implement <see cref="IDataItem"/> and have a parameterless constructor.</typeparam>
        /// <param name="accountId">The account ID against which to execute the query.</param>
        /// <param name="query">The <see cref="IQuery"/> to execute.</param>
        /// <param name="defaultItemsPerRequest">The default number of items per request.</param>
        /// <param name="maxRequests">The maximum number of paged requests to make.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>An asynchronous stream of <typeparamref name="TEntity"/> results.</returns>
        private async IAsyncEnumerable<TEntity> StreamAsync<TEntity>(string accountId, IQuery query, int defaultItemsPerRequest, int maxRequests, [EnumeratorCancellation] CancellationToken ct)
            where TEntity : IDataItem, new()
        {
            ExecutionBuilder builder = new(query, defaultItemsPerRequest);

            int currentConnectionDepth = builder.GetMaximumConnectionDepth();
            if (currentConnectionDepth > _maxConnectionDepth)
                throw new XurrentExecutionException($"The query exceeds the maximum allowed connection depth. The maximum is {_maxConnectionDepth}, but the query contains a connection depth of {currentConnectionDepth}.");

            JsonSerializerOptions localJsonOptions = SerializationConfiguration.CreateJsonOptions(builder.GetInterfaceMappings());

            while (maxRequests > 0)
            {
                string content = JsonSerializer.Serialize(new { query = builder.GetGraphQLQuery() });
                AuthenticationToken token = await GetAuthenticationTokenAsync(ct).ConfigureAwait(false);

                using (HttpRequestMessage requestMessage = CreateHttpRequest(accountId, token))
                {
                    using (JsonDocument document = await SendHttpRequestAsync(requestMessage, content, token, true, ct).ConfigureAwait(false))
                    {
                        if (!document.TryGetElementByPath(new string[] { "data", builder.GetResponseObjectName() }, out JsonElement element))
                            yield break;

                        PagedResponse<TEntity> result = new();
                        if (builder.IsResponseCollection() && JsonSerializer.Deserialize<PagedResponse<TEntity>>(element, localJsonOptions) is PagedResponse<TEntity> items)
                        {
                            result = items;
                        }
                        else if (JsonSerializer.Deserialize<TEntity>(element, localJsonOptions) is TEntity item)
                        {
                            result.Data.Add(item);
                        }

                        foreach (TEntity dataItem in result.Data)
                            yield return dataItem;

                        int? nextPageCursor = builder.UpdateCursors(query.Name, result);

                        if (nextPageCursor is null)
                            yield break;

                        if (nextPageCursor == 0)
                            maxRequests--;
                    }
                }
            }
        }

        /// <summary>
        /// Executes a GraphQL mutation and returns the result as an instance of <typeparamref name="TOutEntity"/>.
        /// </summary>
        /// <typeparam name="TOutEntity">The output entity type returned by the mutation.</typeparam>
        /// <typeparam name="TInEntity">The input entity type used for the mutation.</typeparam>
        /// <param name="accountId">The account ID to use for the mutation request.</param>
        /// <param name="mutation">The mutation to execute.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{TOutEntity}"/> representing the asynchronous operation, containing the mutation result entity.</returns>
        private async Task<TOutEntity> MutationAsync<TOutEntity, TInEntity>(string accountId, Mutation<TInEntity> mutation, CancellationToken ct)
            where TOutEntity : MutationResultBase
            where TInEntity : PropertyChangeSet
        {
            PropertyInfo[] properties = mutation.Data.GetType().GetProperties();
            Dictionary<string, string> fieldToPropertyMap = properties
                .SelectMany(p => p.GetCustomAttributes(typeof(XurrentFieldAttribute), true)
                    .OfType<XurrentFieldAttribute>()
                    .Where(x => x.IsRequiredForMutation)
                    .Select(x => new { x.FieldName, PropertyName = p.Name }))
                .ToDictionary(x => x.FieldName, x => x.PropertyName);

            ImmutableHashSet<string> usedFields = mutation.GetFields();
            string? missingField = fieldToPropertyMap.Keys.FirstOrDefault(field => !usedFields.Contains(field));

            if (missingField is not null)
                throw new XurrentExecutionException($"The value of the '{fieldToPropertyMap[missingField]}' property is required and cannot be null, empty, or the default.");

            ExecutionBuilder builder = new(mutation);
            JsonSerializerOptions localJsonOptions = SerializationConfiguration.CreateJsonOptions(typeof(TInEntity), mutation.GetFields());

            string content = JsonSerializer.Serialize(new { query = builder.GetGraphQLQuery(), variables = new { input = mutation.Data } }, localJsonOptions);

            AuthenticationToken token = await GetAuthenticationTokenAsync(ct).ConfigureAwait(false);
            using (HttpRequestMessage requestMessage = CreateHttpRequest(accountId, token))
            {
                using (JsonDocument document = await SendHttpRequestAsync(requestMessage, content, token, true, ct).ConfigureAwait(false))
                {
                    if (document.TryGetElementByPath(new string[] { "data", builder.GetResponseObjectName() }, out JsonElement element))
                    {
                        if (JsonSerializer.Deserialize<TOutEntity>(element, localJsonOptions) is TOutEntity item)
                        {
                            element.ThrowIfGraphQLError();
                            return item;
                        }
                            
                    }
                }
            }
            throw new XurrentExecutionException("Unprocessable mutation response.");
        }

        /// <summary>
        /// Creates an <see cref="HttpRequestMessage"/> configured for a GraphQL or REST POST, including authorization and account headers.
        /// </summary>
        /// <param name="accountId">The account ID to include in the request headers.</param>
        /// <param name="token">The <see cref="AuthenticationToken"/> providing authorization.</param>
        /// <param name="url">An optional endpoint URL to use for the request. This may be a GraphQL or REST endpoint. If <c>null</c>, the default GraphQL endpoint URL is used.</param>
        /// <returns>An <see cref="HttpRequestMessage"/> ready to send to the specified endpoint.</returns>
        private HttpRequestMessage CreateHttpRequest(string accountId, AuthenticationToken token, string? url = null)
        {
            HttpRequestMessage retval = new(HttpMethod.Post, url ?? _url);
            retval.Headers.Authorization = new AuthenticationHeaderValue(token.TokenType, token.Token);
            retval.Headers.Add(Constants.AccountHeader, accountId);
            return retval;
        }

        /// <summary>
        /// Sends an HTTP request to the GraphQL endpoint, applies rate limiting, and parses the JSON response into a <see cref="JsonDocument"/>.
        /// </summary>
        /// <param name="requestMessage">The <see cref="HttpRequestMessage"/> to send.</param>
        /// <param name="content">The JSON-serialized GraphQL query payload.</param>
        /// <param name="token">The <see cref="AuthenticationToken"/> used for rate-limiter tracking.</param>
        /// <param name="allowRetry">If <c>true</c>, the method will automatically retry the request once after a 429 Too Many Requests response, honoring the server's <c>Retry-After</c> header. If <c>false</c>, no further retries are attempted.</param>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing the parsed <see cref="JsonDocument"/>.</returns>
        private async Task<JsonDocument> SendHttpRequestAsync(HttpRequestMessage requestMessage, string? content, AuthenticationToken token, bool allowRetry, CancellationToken ct)
        {
            if (!string.IsNullOrWhiteSpace(content))
                requestMessage.Content = new StringContent(content, Encoding.UTF8, Constants.ApplicationJsonMediaType);

            Guid logId = Guid.NewGuid();
            WriteDebug(logId, requestMessage, content);

            await _rateLimiter.WaitForToken(token, ct).ConfigureAwait(false);
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            using (HttpResponseMessage responseMessage = await _httpClient.SendAsync(requestMessage, ct).ConfigureAwait(false))
            {
                stopwatch.Stop();
                WriteDebug(logId, requestMessage, null, stopwatch.Elapsed, responseMessage);

                if ((int)responseMessage.StatusCode == 429)
                {
                    token.UpdateRetryAfter(responseMessage.Headers);
                    if (allowRetry)
                    {
                        using (HttpRequestMessage newRequestMessage = new(requestMessage.Method, requestMessage.RequestUri))
                        {
                            foreach (KeyValuePair<string, IEnumerable<string>> header in requestMessage.Headers)
                                newRequestMessage.Headers.Add(header.Key, header.Value);
                            if (!string.IsNullOrWhiteSpace(content))
                                newRequestMessage.Content = new StringContent(content, Encoding.UTF8, Constants.ApplicationJsonMediaType);
                            return await SendHttpRequestAsync(newRequestMessage, content, token, false, ct).ConfigureAwait(false);
                        }
                    }
                }

                token.UpdateLimitsFromHeaders(responseMessage.Headers);
                await responseMessage.ThrowIfInvalidResponse().ConfigureAwait(false);

#if NET5_0_OR_GREATER
                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync(ct).ConfigureAwait(false))
#else
                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false))
#endif
                {
                    JsonDocument document = await JsonDocument.ParseAsync(responseStream, default, ct).ConfigureAwait(false);
                    document.ThrowIfGraphQLError();
                    return document;
                }
            }
        }

        /// <summary>
        /// Safely retrieves the current account ID under lock.
        /// </summary>
        /// <returns>The current account ID.</returns>
        internal string GetAccountId()
        {
            lock (_accountIdLock)
            {
                return _accountId;
            }
        }

        /// <summary>
        /// Retrieves a valid <see cref="AuthenticationToken"/>, refreshing it if expired.
        /// </summary>
        /// <param name="ct">The <see cref="CancellationToken"/> for request cancellation.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, containing a valid <see cref="AuthenticationToken"/>.</returns>
        private async Task<AuthenticationToken> GetAuthenticationTokenAsync(CancellationToken ct)
        {
            AuthenticationToken token = _authenticationTokens.Get();

            if (token.IsTokenExpired())
            {
                await _refreshLock.WaitAsync(ct).ConfigureAwait(false);

                try
                {
                    if (token.IsTokenExpired())
                    {
                        using (HttpRequestMessage requestMessage = new(HttpMethod.Post, _oauth2Url))
                        {
                            requestMessage.Content = new FormUrlEncodedContent(new Dictionary<string, string?>()
                            {
                                { "grant_type", "client_credentials" },
                                { "client_id", token.ClientId },
                                { "client_secret", token.ClientSecret }
                            });

                            Guid logId = Guid.NewGuid();
                            WriteDebug(logId, requestMessage, "***");

                            await _rateLimiter.WaitForToken(token, ct).ConfigureAwait(false);

                            Stopwatch stopwatch = Stopwatch.StartNew();
                            using (HttpResponseMessage responseMessage = await _httpClient.SendAsync(requestMessage, ct).ConfigureAwait(false))
                            {
                                stopwatch.Stop();
                                WriteDebug(logId, requestMessage, null, stopwatch.Elapsed, responseMessage);

                                await responseMessage.ThrowIfInvalidResponse().ConfigureAwait(false);

#if NET5_0_OR_GREATER
                                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync(ct).ConfigureAwait(false))
#else
                                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false))
#endif
                                {
                                    AuthenticationOAuth2Response? oauthResponse = await JsonSerializer.DeserializeAsync<AuthenticationOAuth2Response>(responseStream, _defaultJsonOptions, ct).ConfigureAwait(false);
                                    if (oauthResponse is not null)
                                    {
                                        token.SetToken(oauthResponse.AccessToken, oauthResponse.TokenType, oauthResponse.ExpiresIn);
                                    }
                                    else
                                    {
                                        throw new XurrentExecutionException("Invalid authentication response.");
                                    }
                                }
                            }
                        }
                    }
                }
                finally
                {
                    _refreshLock.Release();
                }
            }

            return token;
        }

        /// <summary>
        /// Releases the unmanaged and managed resources used by this client.
        /// </summary>
        /// <param name="disposing"><c>true</c> if called from <see cref="Dispose()"/>; otherwise, <c>false</c>.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _httpClient?.Dispose();
                    _httpImportExportClient?.Dispose();
                    _refreshLock?.Dispose();
                    if (_disposeAuthenticationTokens)
                        _authenticationTokens?.Dispose();
                }

                _disposedValue = true;
            }
        }

        /// <summary>
        /// Disposes the client, releasing all managed resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
