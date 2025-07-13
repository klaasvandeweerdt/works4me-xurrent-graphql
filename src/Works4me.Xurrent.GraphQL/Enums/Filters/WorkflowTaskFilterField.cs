using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Task records are returned.
    /// </summary>
    public enum WorkflowTaskFilterField
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
        /// Include only if Created from request matches supplied value.
        /// </summary>
        [XurrentEnum("createdFromRequest")]
        CreatedFromRequest,

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
        /// Filter on Impact.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

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
        /// Include only if Provider not accountable matches supplied value.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// Filter on Release.
        /// </summary>
        [XurrentEnum("release")]
        Release,

        /// <summary>
        /// Filter on Requester organization.
        /// </summary>
        [XurrentEnum("requesterOrganization")]
        RequesterOrganization,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service instance.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

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
        /// Filter on Supplier request ID.
        /// </summary>
        [XurrentEnum("supplierRequestID")]
        SupplierRequestID,

        /// <summary>
        /// Filter on record ID as displayed in UI.
        /// </summary>
        [XurrentEnum("taskId")]
        TaskId,

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
        /// Filter on Template team.
        /// </summary>
        [XurrentEnum("templateTeam")]
        TemplateTeam,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Include only if Urgent matches supplied value.
        /// </summary>
        [XurrentEnum("urgent")]
        Urgent,

        /// <summary>
        /// Filter on Workflow.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow,

        /// <summary>
        /// Filter on Workflow category.
        /// </summary>
        [XurrentEnum("workflowCategory")]
        WorkflowCategory,

        /// <summary>
        /// Filter on Justification.
        /// </summary>
        [XurrentEnum("workflowJustification")]
        WorkflowJustification,

        /// <summary>
        /// Filter on Workflow type.
        /// </summary>
        [XurrentEnum("workflowType")]
        WorkflowType
    }
}
