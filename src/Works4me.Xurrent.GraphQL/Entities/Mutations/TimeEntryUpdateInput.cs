using System;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeentryupdateinput/">TimeEntryUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class TimeEntryUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _correction;
        private string? _customerId;
#if NET6_0_OR_GREATER
        private DateOnly? _date;
#else
        private DateTime? _date;
#endif
        private bool? _deleted;
        private string? _description;
        private string? _effortClassId;
        private string? _noteId;
        private string? _organizationId;
        private string? _personId;
        private string? _serviceId;
        private DateTime? _startedAt;
        private string? _teamId;
        private string? _timeAllocationId;
        private long? _timeSpent;
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
        /// Whether the time entry should be considered a correction for a time entry that was registered for a date that has already been locked.
        /// </summary>
        [XurrentField("correction")]
        public bool? Correction
        {
            get => _correction;
            set => _correction = Set("correction", value);
        }

        /// <summary>
        /// Identifier of the organization for which the time was spent.
        /// </summary>
        [XurrentField("customerId")]
        public string? CustomerId
        {
            get => _customerId;
            set => _customerId = Set("customerId", value);
        }

        /// <summary>
        /// The date on which the time was spent.
        /// </summary>
        [XurrentField("date")]
#if NET6_0_OR_GREATER
        public DateOnly? Date
#else
        public DateTime? Date
#endif
        {
            get => _date;
            set => _date = Set("date", value);
        }

        /// <summary>
        /// Automatically checked after the time entry has been deleted. The data of a deleted time entry that is older than 3 months can no longer be retrieved.
        /// </summary>
        [XurrentField("deleted")]
        public bool? Deleted
        {
            get => _deleted;
            set => _deleted = Set("deleted", value);
        }

        /// <summary>
        /// A short description of the time spent. This field is available and required only when the Description required box is checked in the selected time allocation.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// Identifier of the effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Identifier of the note the time entry is linked to.
        /// </summary>
        [XurrentField("noteId")]
        public string? NoteId
        {
            get => _noteId;
            set => _noteId = Set("noteId", value);
        }

        /// <summary>
        /// Identifier of the organization to which the person was linked when the time entry was created.
        /// </summary>
        [XurrentField("organizationId")]
        public string? OrganizationId
        {
            get => _organizationId;
            set => _organizationId = Set("organizationId", value);
        }

        /// <summary>
        /// Identifier of the person who spent the time.
        /// </summary>
        [XurrentField("personId")]
        public string? PersonId
        {
            get => _personId;
            set => _personId = Set("personId", value);
        }

        /// <summary>
        /// Identifier of the service for which the time was spent.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// The start time of the work.
        /// </summary>
        [XurrentField("startedAt")]
        public DateTime? StartedAt
        {
            get => _startedAt;
            set => _startedAt = Set("startedAt", value);
        }

        /// <summary>
        /// Identifier of the team the person of the time entry was a member of while the work was performed.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// Identifier of the time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        [XurrentField("timeAllocationId")]
        public string? TimeAllocationId
        {
            get => _timeAllocationId;
            set => _timeAllocationId = Set("timeAllocationId", value);
        }

        /// <summary>
        /// The number of minutes that was spent on the selected time allocation. The number of minutes is allowed to be negative only when the correction field is set to <c>true</c>.
        /// </summary>
        [XurrentField("timeSpent")]
        public long? TimeSpent
        {
            get => _timeSpent;
            set => _timeSpent = Set("timeSpent", value);
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
        /// Initializes a new instance of the <see cref="TimeEntryUpdateInput"/> class without providing the required values.
        /// </summary>
        public TimeEntryUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeEntryUpdateInput"/> class.
        /// </summary>
        public TimeEntryUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
