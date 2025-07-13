using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timesheetsetting/">TimesheetSetting</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("TimesheetSetting")]
    public sealed class TimesheetSetting : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether people of the related organizations need to be able to register time entries for the time allocations that are linked to their organizations.
        /// </summary>
        [XurrentField("allocationTimeTracking")]
        public bool? AllocationTimeTracking { get; internal set; }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single day than the amount of time specified in the Workday field.
        /// </summary>
        [XurrentField("allowWorkdayOvertime")]
        public bool? AllowWorkdayOvertime { get; internal set; }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked are allowed to register more time for a single week than the amount of time specified in the Workweek field.
        /// </summary>
        [XurrentField("allowWorkweekOvertime")]
        public bool? AllowWorkweekOvertime { get; internal set; }

        /// <summary>
        /// Whether the Time spent field needs to be available in requests, problems and tasks for specialists of the related organizations to specify how long they have worked on their assignments.
        /// </summary>
        [XurrentField("assignmentTimeTracking")]
        public bool? AssignmentTimeTracking { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the timesheet settings may no longer be related to any more organizations.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        [XurrentField("effortClasses")]
        internal PagedResponse<EffortClass>? EffortClassesCollection { get; set; }
        /// <summary>
        /// Effort classes of the timesheet setting.
        /// </summary>
        public ReadOnlyDataCollection<EffortClass>? EffortClasses { get => EffortClassesCollection?.Data is null ? null : new ReadOnlyDataCollection<EffortClass>(EffortClassesCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the timesheet settings.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Whether an email notification should be sent to each person who registered fewer hours for the past week than the workweek hours.
        /// </summary>
        [XurrentField("notifyOnIncomplete")]
        public bool? NotifyOnIncomplete { get; internal set; }

        [XurrentField("organizations")]
        internal PagedResponse<Organization>? OrganizationsCollection { get; set; }
        /// <summary>
        /// Organizations of the timesheet setting.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Organizations { get => OrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(OrganizationsCollection.Data); }

        /// <summary>
        /// The minimum amount percentage of a workday that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This percentage of a workday is also the increment by which they can increase this minimum percentage of a workday.
        /// </summary>
        [XurrentField("percentageIncrement")]
        public TimesheetSettingPercentageIncrement? PercentageIncrement { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a problem.
        /// </summary>
        [XurrentField("problemEffortClass")]
        public EffortClass? ProblemEffortClass { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a project task.
        /// </summary>
        [XurrentField("projectTaskEffortClass")]
        public EffortClass? ProjectTaskEffortClass { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a request.
        /// </summary>
        [XurrentField("requestEffortClass")]
        public EffortClass? RequestEffortClass { get; internal set; }

        /// <summary>
        /// Whether the Note field needs to become required, when someone in an organization linked to the timesheet settings registers time on a request, problem or task.
        /// </summary>
        [XurrentField("requireNote")]
        public bool? RequireNote { get; internal set; }

        /// <summary>
        /// Whether the Description field needs to become required, when someone in an organization linked to the timesheet settings registers time on a request, problem, task or on a time allocation.
        /// </summary>
        [XurrentField("requireTimeEntryDescription")]
        public bool? RequireTimeEntryDescription { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a workflow task.
        /// </summary>
        [XurrentField("taskEffortClass")]
        public EffortClass? TaskEffortClass { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a time allocation.
        /// </summary>
        [XurrentField("timeAllocationEffortClass")]
        public EffortClass? TimeAllocationEffortClass { get; internal set; }

        /// <summary>
        /// The minimum amount of time that the people of the organizations to which the timesheet settings are linked can select when they register a time entry. This amount of time is also the increment by which they can increase this minimum amount of time.
        /// </summary>
        [XurrentField("timeIncrement")]
        public TimesheetSettingTimeIncrement? TimeIncrement { get; internal set; }

        /// <summary>
        /// Whether the people of the organizations to which the timesheet settings are linked need to register their time in hours and minutes, or as a percentage of a workday.
        /// </summary>
        [XurrentField("unit")]
        public TimesheetSettingUnit? Unit { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The duration of a workday in minutes.
        /// </summary>
        [XurrentField("workday")]
        public long? Workday { get; internal set; }

        /// <summary>
        /// The duration of a workweek in minutes.
        /// </summary>
        [XurrentField("workweek")]
        public long? Workweek { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is TimesheetSetting timesheetSetting)
            {
                EffortClassesCollection?.Data?.AddRange(timesheetSetting.EffortClasses);
                OrganizationsCollection?.Data?.AddRange(timesheetSetting.Organizations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (EffortClassesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in EffortClassesCollection.GetPageInfo("effortClasses", depth))
                    yield return pageInfo;

            if (OrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OrganizationsCollection.GetPageInfo("organizations", depth))
                    yield return pageInfo;
        }
    }
}
