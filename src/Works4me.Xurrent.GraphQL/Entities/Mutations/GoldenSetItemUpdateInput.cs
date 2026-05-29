using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/goldensetitemupdateinput/">GoldenSetItemUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class GoldenSetItemUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _runAsId;
        private string? _promptQuery;
        private string? _expectedHitId;
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
        /// ID of the person whose role and locale the evaluation impersonates.
        /// </summary>
        [XurrentField("runAsId")]
        public string? RunAsId
        {
            get => _runAsId;
            set => _runAsId = Set("runAsId", value);
        }

        /// <summary>
        /// Free-text search prompt sent to the virtual agent during evaluation.
        /// </summary>
        [XurrentField("promptQuery")]
        public string? PromptQuery
        {
            get => _promptQuery;
            set => _promptQuery = Set("promptQuery", value);
        }

        /// <summary>
        /// Global node ID of the Knowledge Article or Request Template the agent is expected to surface. The node ID encodes both the type and the record ID, so no separate <c>expected_hit_type</c> argument is required.
        /// </summary>
        [XurrentField("expectedHitId")]
        public string? ExpectedHitId
        {
            get => _expectedHitId;
            set => _expectedHitId = Set("expectedHitId", value);
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
        /// Initializes a new instance of the <see cref="GoldenSetItemUpdateInput"/> class without providing the required values.
        /// </summary>
        public GoldenSetItemUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemUpdateInput"/> class.
        /// </summary>
        public GoldenSetItemUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
