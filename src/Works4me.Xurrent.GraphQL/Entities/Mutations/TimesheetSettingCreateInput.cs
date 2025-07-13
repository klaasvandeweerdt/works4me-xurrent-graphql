using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timesheetsettingcreateinput/">TimesheetSettingCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class TimesheetSettingCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _allocationTimeTracking;
        private bool? _allowWorkdayOvertime;
        private bool? _allowWorkweekOvertime;
        private bool? _assignmentTimeTracking;
        private bool? _disabled;
        private bool? _notifyOnIncomplete;
        private TimesheetSettingPercentageIncrement? _percentageIncrement;
        private string? _problemEffortClassId;
        private string? _projectTaskEffortClassId;
        private string? _requestEffortClassId;
        private bool? _requireNote;
        private bool? _requireTimeEntryDescription;
        private string? _taskEffortClassId;
        private string? _timeAllocationEffortClassId;
        private TimesheetSettingTimeIncrement? _timeIncrement;
        private long? _workday;
        private long? _workweek;
        private Collection<string>? _effortClassIds;
        private Collection<string>? _organizationIds;
        private string _name;
        private TimesheetSettingUnit _unit;

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
        /// Whether people of the related organizations need to be able to register time entries for the time allocations that are linked to their organizations.
        /// </summary>
        [XurrentField("allocationTimeTracking")]
        public bool? AllocationTimeTracking
        {
            get => _allocationTimeTracking;
            set => _allocationTimeTracking = Set("allocationTimeTracking", value);
        }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single day than the amount of time specified in the Workday field.
        /// </summary>
        [XurrentField("allowWorkdayOvertime")]
        public bool? AllowWorkdayOvertime
        {
            get => _allowWorkdayOvertime;
            set => _allowWorkdayOvertime = Set("allowWorkdayOvertime", value);
        }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single week than the amount of time specified in the Workweek field.
        /// </summary>
        [XurrentField("allowWorkweekOvertime")]
        public bool? AllowWorkweekOvertime
        {
            get => _allowWorkweekOvertime;
            set => _allowWorkweekOvertime = Set("allowWorkweekOvertime", value);
        }

        /// <summary>
        /// Whether the Time spent field needs to be available in requests, problems and tasks for specialists of the related organizations to specify how long they have worked on their assignments.
        /// </summary>
        [XurrentField("assignmentTimeTracking")]
        public bool? AssignmentTimeTracking
        {
            get => _assignmentTimeTracking;
            set => _assignmentTimeTracking = Set("assignmentTimeTracking", value);
        }

        /// <summary>
        /// Whether the timesheet settings may no longer be related to any more organizations.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Whether an email notification should be sent to each person who registered fewer hours for the past week than the workweek hours.
        /// </summary>
        [XurrentField("notifyOnIncomplete")]
        public bool? NotifyOnIncomplete
        {
            get => _notifyOnIncomplete;
            set => _notifyOnIncomplete = Set("notifyOnIncomplete", value);
        }

        /// <summary>
        /// The minimum amount percentage of a workday that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This percentage of a workday is also the increment by which they can increase this minimum percentage of a workday.
        /// </summary>
        [XurrentField("percentageIncrement")]
        public TimesheetSettingPercentageIncrement? PercentageIncrement
        {
            get => _percentageIncrement;
            set => _percentageIncrement = Set("percentageIncrement", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a problem.
        /// </summary>
        [XurrentField("problemEffortClassId")]
        public string? ProblemEffortClassId
        {
            get => _problemEffortClassId;
            set => _problemEffortClassId = Set("problemEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a project task.
        /// </summary>
        [XurrentField("projectTaskEffortClassId")]
        public string? ProjectTaskEffortClassId
        {
            get => _projectTaskEffortClassId;
            set => _projectTaskEffortClassId = Set("projectTaskEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a request.
        /// </summary>
        [XurrentField("requestEffortClassId")]
        public string? RequestEffortClassId
        {
            get => _requestEffortClassId;
            set => _requestEffortClassId = Set("requestEffortClassId", value);
        }

        /// <summary>
        /// Whether the Note field needs to become required, when someone in an organization linked to the timesheet settings registers time on a request, problem or task.
        /// </summary>
        [XurrentField("requireNote")]
        public bool? RequireNote
        {
            get => _requireNote;
            set => _requireNote = Set("requireNote", value);
        }

        /// <summary>
        /// Whether the Time entry description field needs to become required, when someone in an organization linked to the timesheet settings registers time on a request, problem, task or on a time allocation.
        /// </summary>
        [XurrentField("requireTimeEntryDescription")]
        public bool? RequireTimeEntryDescription
        {
            get => _requireTimeEntryDescription;
            set => _requireTimeEntryDescription = Set("requireTimeEntryDescription", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a workflow task.
        /// </summary>
        [XurrentField("taskEffortClassId")]
        public string? TaskEffortClassId
        {
            get => _taskEffortClassId;
            set => _taskEffortClassId = Set("taskEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a time allocation.
        /// </summary>
        [XurrentField("timeAllocationEffortClassId")]
        public string? TimeAllocationEffortClassId
        {
            get => _timeAllocationEffortClassId;
            set => _timeAllocationEffortClassId = Set("timeAllocationEffortClassId", value);
        }

        /// <summary>
        /// The minimum amount of time that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This amount of time is also the increment by which they can increase this minimum amount of time.
        /// </summary>
        [XurrentField("timeIncrement")]
        public TimesheetSettingTimeIncrement? TimeIncrement
        {
            get => _timeIncrement;
            set => _timeIncrement = Set("timeIncrement", value);
        }

        /// <summary>
        /// The duration of a workday in minutes.
        /// </summary>
        [XurrentField("workday")]
        public long? Workday
        {
            get => _workday;
            set => _workday = Set("workday", value);
        }

        /// <summary>
        /// The duration of a workweek in minutes.
        /// </summary>
        [XurrentField("workweek")]
        public long? Workweek
        {
            get => _workweek;
            set => _workweek = Set("workweek", value);
        }

        /// <summary>
        /// Identifiers of effort classes of the timesheet setting.
        /// </summary>
        [XurrentField("effortClassIds")]
        public Collection<string>? EffortClassIds
        {
            get => _effortClassIds;
            set => _effortClassIds = Set("effortClassIds", value);
        }

        /// <summary>
        /// Identifiers of organizations of the timesheet setting.
        /// </summary>
        [XurrentField("organizationIds")]
        public Collection<string>? OrganizationIds
        {
            get => _organizationIds;
            set => _organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// The name of the timesheet settings.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked need to register their time in hours and minutes, or as a percentage of a workday.
        /// </summary>
        [XurrentField("unit")]
        public TimesheetSettingUnit Unit
        {
            get => _unit;
            set => _unit = Set("unit", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetSettingCreateInput"/> class without providing the required values.
        /// </summary>
        public TimesheetSettingCreateInput()
        {
            _name = string.Empty;
            _unit = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetSettingCreateInput"/> class.
        /// </summary>
        public TimesheetSettingCreateInput(string name, TimesheetSettingUnit unit)
        {
            _name = Set("name", name);
            _unit = Set("unit", unit);
        }
    }
}
