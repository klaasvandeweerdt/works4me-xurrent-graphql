using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/goldensetitemcreateinput/">GoldenSetItemCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class GoldenSetItemCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _runAsId;
        private string _promptQuery;
        private string _expectedHitId;

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
        public string RunAsId
        {
            get => _runAsId;
            set => _runAsId = Set("runAsId", value);
        }

        /// <summary>
        /// Free-text search prompt sent to the virtual agent during evaluation.
        /// </summary>
        [XurrentField("promptQuery")]
        public string PromptQuery
        {
            get => _promptQuery;
            set => _promptQuery = Set("promptQuery", value);
        }

        /// <summary>
        /// Global node ID of the Knowledge Article or Request Template the agent is expected to surface. The node ID encodes both the type and the record ID, so no separate <c>expected_hit_type</c> argument is required.
        /// </summary>
        [XurrentField("expectedHitId")]
        public string ExpectedHitId
        {
            get => _expectedHitId;
            set => _expectedHitId = Set("expectedHitId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemCreateInput"/> class without providing the required values.
        /// </summary>
        public GoldenSetItemCreateInput()
        {
            _runAsId = string.Empty;
            _promptQuery = string.Empty;
            _expectedHitId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemCreateInput"/> class.
        /// </summary>
        public GoldenSetItemCreateInput(string runAsId, string promptQuery, string expectedHitId)
        {
            _runAsId = Set("runAsId", runAsId);
            _promptQuery = Set("promptQuery", promptQuery);
            _expectedHitId = Set("expectedHitId", expectedHitId);
        }
    }
}
