using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TimesheetSetting">TimesheetSetting</see> fields.
    /// </summary>
    public enum TimesheetSettingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The allocation time tracking field.
        /// </summary>
        [XurrentEnum("allocationTimeTracking")]
        AllocationTimeTracking,

        /// <summary>
        /// The allow workday overtime field.
        /// </summary>
        [XurrentEnum("allowWorkdayOvertime")]
        AllowWorkdayOvertime,

        /// <summary>
        /// The allow workweek overtime field.
        /// </summary>
        [XurrentEnum("allowWorkweekOvertime")]
        AllowWorkweekOvertime,

        /// <summary>
        /// The assignment time tracking field.
        /// </summary>
        [XurrentEnum("assignmentTimeTracking")]
        AssignmentTimeTracking,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The notify on incomplete field.
        /// </summary>
        [XurrentEnum("notifyOnIncomplete")]
        NotifyOnIncomplete,

        /// <summary>
        /// The percentage increment field.
        /// </summary>
        [XurrentEnum("percentageIncrement")]
        PercentageIncrement,

        /// <summary>
        /// The problem effort class field.
        /// </summary>
        [XurrentEnum("problemEffortClass")]
        ProblemEffortClass,

        /// <summary>
        /// The project task effort class field.
        /// </summary>
        [XurrentEnum("projectTaskEffortClass")]
        ProjectTaskEffortClass,

        /// <summary>
        /// The request effort class field.
        /// </summary>
        [XurrentEnum("requestEffortClass")]
        RequestEffortClass,

        /// <summary>
        /// The require note field.
        /// </summary>
        [XurrentEnum("requireNote")]
        RequireNote,

        /// <summary>
        /// The require time entry description field.
        /// </summary>
        [XurrentEnum("requireTimeEntryDescription")]
        RequireTimeEntryDescription,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The task effort class field.
        /// </summary>
        [XurrentEnum("taskEffortClass")]
        TaskEffortClass,

        /// <summary>
        /// The time allocation effort class field.
        /// </summary>
        [XurrentEnum("timeAllocationEffortClass")]
        TimeAllocationEffortClass,

        /// <summary>
        /// The time increment field.
        /// </summary>
        [XurrentEnum("timeIncrement")]
        TimeIncrement,

        /// <summary>
        /// The unit field.
        /// </summary>
        [XurrentEnum("unit")]
        Unit,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The workday field.
        /// </summary>
        [XurrentEnum("workday")]
        Workday,

        /// <summary>
        /// The workweek field.
        /// </summary>
        [XurrentEnum("workweek")]
        Workweek
    }
}
