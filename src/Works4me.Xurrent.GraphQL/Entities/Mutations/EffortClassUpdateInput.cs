using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/effortclassupdateinput/">EffortClassUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class EffortClassUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private decimal? _costMultiplier;
        private bool? _disabled;
        private string? _name;
        private long? _position;
        private Collection<string>? _timesheetSettingIds;
        private Collection<string>? _serviceOfferingIds;
        private Collection<string>? _skillPoolIds;
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
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The amount with which to multiply the cost of time entries with this effort class.
        /// </summary>
        [XurrentField("costMultiplier")]
        public decimal? CostMultiplier
        {
            get => _costMultiplier;
            set => _costMultiplier = Set("costMultiplier", value);
        }

        /// <summary>
        /// Whether the effort class may no longer be related to any more timesheet settings.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the effort class.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The position that the effort class takes when it is displayed in a sorted list.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }

        /// <summary>
        /// IDs of the timesheet settings of this effort class.
        /// </summary>
        [XurrentField("timesheetSettingIds")]
        public Collection<string>? TimesheetSettingIds
        {
            get => _timesheetSettingIds;
            set => _timesheetSettingIds = Set("timesheetSettingIds", value);
        }

        /// <summary>
        /// IDs of the service offerings of this effort class.
        /// </summary>
        [XurrentField("serviceOfferingIds")]
        public Collection<string>? ServiceOfferingIds
        {
            get => _serviceOfferingIds;
            set => _serviceOfferingIds = Set("serviceOfferingIds", value);
        }

        /// <summary>
        /// IDs of the skill pools of this effort class.
        /// </summary>
        [XurrentField("skillPoolIds")]
        public Collection<string>? SkillPoolIds
        {
            get => _skillPoolIds;
            set => _skillPoolIds = Set("skillPoolIds", value);
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
        /// Initializes a new instance of the <see cref="EffortClassUpdateInput"/> class without providing the required values.
        /// </summary>
        public EffortClassUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffortClassUpdateInput"/> class.
        /// </summary>
        public EffortClassUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
