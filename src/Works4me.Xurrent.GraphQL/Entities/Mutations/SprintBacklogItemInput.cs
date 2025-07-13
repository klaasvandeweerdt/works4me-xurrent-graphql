using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/sprintbacklogiteminput/">SprintBacklogItemInput</see> in Xurrent.
    /// </summary>
    public sealed class SprintBacklogItemInput : PropertyChangeSet
    {
        private string? _id;
        private bool? _done;
        private bool? _planned;
        private long? _position;
        private long? _estimate;
        private string? _recordId;

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
        /// Whether this item has been completed in this sprint. <c>null</c> indicates the item was removed from the sprint.
        /// </summary>
        [XurrentField("done")]
        public bool? Done
        {
            get => _done;
            set => _done = Set("done", value);
        }

        /// <summary>
        /// Whether this item was part of the sprint backlog when the sprint was started.
        /// </summary>
        [XurrentField("planned")]
        public bool? Planned
        {
            get => _planned;
            set => _planned = Set("planned", value);
        }

        /// <summary>
        /// Position of the record on the sprint backlog.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }

        /// <summary>
        /// Estimate of the relative size of this item on the sprint backlog.
        /// </summary>
        [XurrentField("estimate")]
        public long? Estimate
        {
            get => _estimate;
            set => _estimate = Set("estimate", value);
        }

        /// <summary>
        /// Identifier of the record on the sprint backlog.
        /// </summary>
        [XurrentField("recordId")]
        public string? RecordId
        {
            get => _recordId;
            set => _recordId = Set("recordId", value);
        }
    }
}
