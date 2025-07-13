using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Workflow records are returned.
    /// </summary>
    public enum WorkflowFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// Filter on Completion reason.
        /// </summary>
        [XurrentEnum("completionReason")]
        CompletionReason,

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
        /// Filter on Justification.
        /// </summary>
        [XurrentEnum("justification")]
        Justification,

        /// <summary>
        /// Filter on Manager.
        /// </summary>
        [XurrentEnum("manager")]
        Manager,

        /// <summary>
        /// Filter on Manager organization.
        /// </summary>
        [XurrentEnum("managerOrganization")]
        ManagerOrganization,

        /// <summary>
        /// Include only if Mentioning me matches supplied value.
        /// </summary>
        [XurrentEnum("mentioningMe")]
        MentioningMe,

        /// <summary>
        /// Filter on Phase.
        /// </summary>
        [XurrentEnum("phase")]
        Phase,

        /// <summary>
        /// Filter on Project.
        /// </summary>
        [XurrentEnum("project")]
        Project,

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
        /// Filter on Service owner.
        /// </summary>
        [XurrentEnum("serviceOwner")]
        ServiceOwner,

        /// <summary>
        /// Filter on Service provider.
        /// </summary>
        [XurrentEnum("serviceProvider")]
        ServiceProvider,

        /// <summary>
        /// Filter on Service support team.
        /// </summary>
        [XurrentEnum("serviceSupportTeam")]
        ServiceSupportTeam,

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
        /// Start in supplied range.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

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
        /// Filter on record ID as displayed in UI.
        /// </summary>
        [XurrentEnum("workflowId")]
        WorkflowId,

        /// <summary>
        /// Filter on Type.
        /// </summary>
        [XurrentEnum("workflowType")]
        WorkflowType
    }
}
