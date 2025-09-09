using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookpolicydeletemutationinput/">WebhookPolicyDeleteMutationInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WebhookPolicyDeleteMutationInput : PropertyChangeSet
    {
        private string? _clientMutationId;
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
        /// The node ID of the record to delete.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyDeleteMutationInput"/> class without providing the required values.
        /// </summary>
        public WebhookPolicyDeleteMutationInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyDeleteMutationInput"/> class.
        /// </summary>
        public WebhookPolicyDeleteMutationInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
