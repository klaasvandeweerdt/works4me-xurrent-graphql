using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which ProjectTask records are returned.
    /// </summary>
    public enum ProjectTaskFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on Agile board.
        /// </summary>
        [XurrentEnum("agileBoard")]
        AgileBoard,

        /// <summary>
        /// Filter on Agile board column.
        /// </summary>
        [XurrentEnum("agileBoardColumn")]
        AgileBoardColumn,

        /// <summary>
        /// Filter on Assignee.
        /// </summary>
        [XurrentEnum("assignee")]
        Assignee,

        /// <summary>
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Completion target in supplied range.
        /// </summary>
        [XurrentEnum("completionTargetAt")]
        CompletionTargetAt,

        /// <summary>
        /// Target indication filter on Completion target.
        /// </summary>
        [XurrentEnum("completionTargetIndication")]
        CompletionTargetIndication,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Finished in supplied range.
        /// </summary>
        [XurrentEnum("finishedAt")]
        FinishedAt,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Manager.
        /// </summary>
        [XurrentEnum("manager")]
        Manager,

        /// <summary>
        /// Include only if Mentioning me matches supplied value.
        /// </summary>
        [XurrentEnum("mentioningMe")]
        MentioningMe,

        /// <summary>
        /// Filter on Project.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// Filter on Program.
        /// </summary>
        [XurrentEnum("projectProgram")]
        ProjectProgram,

        /// <summary>
        /// Filter on record ID as displayed in UI.
        /// </summary>
        [XurrentEnum("projectTaskId")]
        ProjectTaskId,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Skill pool.
        /// </summary>
        [XurrentEnum("skillPool")]
        SkillPool,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Filter on Subject.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// Filter on Supplier.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// Filter on Team.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// Filter on Template.
        /// </summary>
        [XurrentEnum("template")]
        Template,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Include only if Urgent matches supplied value.
        /// </summary>
        [XurrentEnum("urgent")]
        Urgent
    }
}
