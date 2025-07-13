using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingscopeinput/">AppOfferingScopeInput</see> in Xurrent.
    /// </summary>
    public sealed class AppOfferingScopeInput : PropertyChangeSet
    {
        private string? _id;
        private ScopeEffect? _effect;
        private OauthApplicationGrantType? _grantType;
        private Collection<string>? _actions;
        private Collection<string>? _conditions;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Whether this scope allows or prevents access.
        /// </summary>
        [XurrentField("effect")]
        public ScopeEffect? Effect
        {
            get => _effect;
            set => _effect = Set("effect", value);
        }

        /// <summary>
        /// Whether this scope is for the app's OAuth application using <a href="https://developer.xurrent.com/v1/oauth/client_credentials_grant/">client credentials</a> or <a href="https://developer.xurrent.com/v1/oauth/authorization_code_grant/">authorization code grant</a>.
        /// </summary>
        [XurrentField("grantType")]
        public OauthApplicationGrantType? GrantType
        {
            get => _grantType;
            set => _grantType = Set("grantType", value);
        }

        /// <summary>
        /// Actions this scope applies to.
        /// </summary>
        [XurrentField("actions")]
        public Collection<string>? Actions
        {
            get => _actions;
            set => _actions = Set("actions", value);
        }

        /// <summary>
        /// Conditions for this scope.
        /// </summary>
        [XurrentField("conditions")]
        public Collection<string>? Conditions
        {
            get => _conditions;
            set => _conditions = Set("conditions", value);
        }
    }
}
