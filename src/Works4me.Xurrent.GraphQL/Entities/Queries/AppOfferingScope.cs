using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingscope/">AppOfferingScope</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("AppOfferingScope")]
    public sealed class AppOfferingScope : IDataItem
    {
        /// <summary>
        /// Actions this scope applies to.
        /// </summary>
        [XurrentField("actions")]
        public IReadOnlyList<string>? Actions { get; internal set; }

        /// <summary>
        /// Conditions for this scope.
        /// </summary>
        [XurrentField("conditions")]
        public IReadOnlyList<string>? Conditions { get; internal set; }

        /// <summary>
        /// Whether this scope allows or prevents access.
        /// </summary>
        [XurrentField("effect")]
        public ScopeEffect? Effect { get; internal set; }

        /// <summary>
        /// Whether this scope is for the app's OAuth application using <a href="https://developer.xurrent.com/v1/oauth/client_credentials_grant/">client credentials</a> or <a href="https://developer.xurrent.com/v1/oauth/authorization_code_grant/">authorization code grant</a>.
        /// </summary>
        [XurrentField("grantType")]
        public OauthApplicationGrantType? GrantType { get; internal set; }

        /// <summary>
        /// Unique identifier of the scope.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
