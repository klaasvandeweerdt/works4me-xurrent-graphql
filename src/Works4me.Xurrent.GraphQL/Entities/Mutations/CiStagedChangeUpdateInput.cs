using System.Diagnostics;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/cistagedchangeupdateinput/">CiStagedChangeUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class CiStagedChangeUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _id;
        private CiStagedChangeStatus _status;
        private JsonElement? _proposedValues;
        private string? _reviewerNote;

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
        /// The node ID of the CI staged change to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// The new status for the staged change (approved or rejected).
        /// </summary>
        [XurrentField("status")]
        public CiStagedChangeStatus Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Optional JSON object with edited proposed values. Only used when approving. Keys must be a subset of the original proposed values.
        /// </summary>
        [XurrentField("proposedValues")]
        public JsonElement? ProposedValues
        {
            get => _proposedValues;
            set => _proposedValues = Set("proposedValues", value);
        }

        /// <summary>
        /// Optional note from the reviewer explaining the decision.
        /// </summary>
        [XurrentField("reviewerNote")]
        public string? ReviewerNote
        {
            get => _reviewerNote;
            set => _reviewerNote = Set("reviewerNote", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiStagedChangeUpdateInput"/> class without providing the required values.
        /// </summary>
        public CiStagedChangeUpdateInput()
        {
            _id = string.Empty;
            _status = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiStagedChangeUpdateInput"/> class.
        /// </summary>
        public CiStagedChangeUpdateInput(string id, CiStagedChangeStatus status)
        {
            _id = Set("id", id);
            _status = Set("status", status);
        }
    }
}
