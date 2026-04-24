using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/virtualagentdesignupdateinput/">VirtualAgentDesignUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class VirtualAgentDesignUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _agentInstructions;
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
        /// Instructions for the virtual agent in markdown format.
        /// </summary>
        [XurrentField("agentInstructions")]
        public string? AgentInstructions
        {
            get => _agentInstructions;
            set => _agentInstructions = Set("agentInstructions", value);
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
        /// Initializes a new instance of the <see cref="VirtualAgentDesignUpdateInput"/> class without providing the required values.
        /// </summary>
        public VirtualAgentDesignUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualAgentDesignUpdateInput"/> class.
        /// </summary>
        public VirtualAgentDesignUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
