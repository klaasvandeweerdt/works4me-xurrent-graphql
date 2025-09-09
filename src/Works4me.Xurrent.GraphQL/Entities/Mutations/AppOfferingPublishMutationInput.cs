using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingpublishmutationinput/">AppOfferingPublishMutationInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class AppOfferingPublishMutationInput : PropertyChangeSet
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
        /// Identifier of the draft app offering that should be copied to created a new published app offering version.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingPublishMutationInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingPublishMutationInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingPublishMutationInput"/> class.
        /// </summary>
        public AppOfferingPublishMutationInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
