using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/goldensetitemdeletemutationinput/">GoldenSetItemDeleteMutationInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class GoldenSetItemDeleteMutationInput : PropertyChangeSet
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
        /// Initializes a new instance of the <see cref="GoldenSetItemDeleteMutationInput"/> class without providing the required values.
        /// </summary>
        public GoldenSetItemDeleteMutationInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemDeleteMutationInput"/> class.
        /// </summary>
        public GoldenSetItemDeleteMutationInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
