using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/seraaistudioupdateinput/">SeraAiStudioUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class SeraAiStudioUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _agentInstructionsDraft;
        private string? _runAsId;
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
        /// New agent instructions (markdown). The text is validated asynchronously — check <c>validationStatus</c> for the result. Once approved, the finalized text appears in the read-only <c>agentInstructions</c> field.
        /// </summary>
        [XurrentField("agentInstructionsDraft")]
        public string? AgentInstructionsDraft
        {
            get => _agentInstructionsDraft;
            set => _agentInstructionsDraft = Set("agentInstructionsDraft", value);
        }

        /// <summary>
        /// Default "Run as" user pre-filled in the user column when adding new golden set rows.
        /// </summary>
        [XurrentField("runAsId")]
        public string? RunAsId
        {
            get => _runAsId;
            set => _runAsId = Set("runAsId", value);
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
        /// Initializes a new instance of the <see cref="SeraAiStudioUpdateInput"/> class without providing the required values.
        /// </summary>
        public SeraAiStudioUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeraAiStudioUpdateInput"/> class.
        /// </summary>
        public SeraAiStudioUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
