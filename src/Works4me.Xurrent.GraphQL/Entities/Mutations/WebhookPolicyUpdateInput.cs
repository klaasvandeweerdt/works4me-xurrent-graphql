using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookpolicyupdateinput/">WebhookPolicyUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WebhookPolicyUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private bool? _disabled;
        private WebhookPolicyJwtAlg? _jwtAlg;
        private long? _jwtClaimExpiresIn;
        private string? _jwtAudience;
        private string _id;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Whether the webhook policy will be applied.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The algorithm to use for cryptographic signing of webhook messages.
        /// </summary>
        [XurrentField("jwtAlg")]
        public WebhookPolicyJwtAlg? JwtAlg
        {
            get => _jwtAlg;
            set => _jwtAlg = Set("jwtAlg", value);
        }

        /// <summary>
        /// The number of minutes within which the claim expires.
        /// </summary>
        [XurrentField("jwtClaimExpiresIn")]
        public long? JwtClaimExpiresIn
        {
            get => _jwtClaimExpiresIn;
            set => _jwtClaimExpiresIn = Set("jwtClaimExpiresIn", value);
        }

        /// <summary>
        /// The audience claim identifies the recipients that the encrypted message is intended for.
        /// </summary>
        [XurrentField("jwtAudience")]
        public string? JwtAudience
        {
            get => _jwtAudience;
            set => _jwtAudience = Set("jwtAudience", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyUpdateInput"/> class without providing the required values.
        /// </summary>
        public WebhookPolicyUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyUpdateInput"/> class.
        /// </summary>
        public WebhookPolicyUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
