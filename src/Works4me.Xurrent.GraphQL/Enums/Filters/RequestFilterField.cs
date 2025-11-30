using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Request records are returned.
    /// </summary>
    public enum RequestFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Include only if Addressed matches supplied value.
        /// </summary>
        [XurrentEnum("addressed")]
        Addressed,

        /// <summary>
        /// Filter on Affected service.
        /// </summary>
        [XurrentEnum("affectedService")]
        AffectedService,

        /// <summary>
        /// Filter on Affected service instance.
        /// </summary>
        [XurrentEnum("affectedServiceInstance")]
        AffectedServiceInstance,

        /// <summary>
        /// Filter on Affected service provider.
        /// </summary>
        [XurrentEnum("affectedServiceProvider")]
        AffectedServiceProvider,

        /// <summary>
        /// Filter on Affected service level agreement.
        /// </summary>
        [XurrentEnum("affectedSla")]
        AffectedSla,

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
        /// Filter on Business unit.
        /// </summary>
        [XurrentEnum("businessUnit")]
        BusinessUnit,

        /// <summary>
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Filter on Configuration item.
        /// </summary>
        [XurrentEnum("ci")]
        Ci,

        /// <summary>
        /// Filter on Closure Code.
        /// </summary>
        [XurrentEnum("closureCode")]
        ClosureCode,

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
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on Created by.
        /// </summary>
        [XurrentEnum("createdBy")]
        CreatedBy,

        /// <summary>
        /// Customer target in supplied range.
        /// </summary>
        [XurrentEnum("customerTargetAt")]
        CustomerTargetAt,

        /// <summary>
        /// Desired completion in supplied range.
        /// </summary>
        [XurrentEnum("desiredCompletionAt")]
        DesiredCompletionAt,

        /// <summary>
        /// Downtime end in supplied range.
        /// </summary>
        [XurrentEnum("downtimeEndAt")]
        DowntimeEndAt,

        /// <summary>
        /// Downtime start in supplied range.
        /// </summary>
        [XurrentEnum("downtimeStartAt")]
        DowntimeStartAt,

        /// <summary>
        /// Filter on Feedback on knowledge article.
        /// </summary>
        [XurrentEnum("feedbackOnKnowledgeArticle")]
        FeedbackOnKnowledgeArticle,

        /// <summary>
        /// Filter on Grouped into.
        /// </summary>
        [XurrentEnum("groupedInto")]
        GroupedInto,

        /// <summary>
        /// Filter on Grouping.
        /// </summary>
        [XurrentEnum("grouping")]
        Grouping,

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
        /// Filter on Knowledge article.
        /// </summary>
        [XurrentEnum("knowledgeArticle")]
        KnowledgeArticle,

        /// <summary>
        /// Include only if Last note by requester matches supplied value.
        /// </summary>
        [XurrentEnum("lastNoteByRequester")]
        LastNoteByRequester,

        /// <summary>
        /// Filter on Major incident status.
        /// </summary>
        [XurrentEnum("majorIncidentStatus")]
        MajorIncidentStatus,

        /// <summary>
        /// Filter on Member.
        /// </summary>
        [XurrentEnum("member")]
        Member,

        /// <summary>
        /// Include only if Mentioning me matches supplied value.
        /// </summary>
        [XurrentEnum("mentioningMe")]
        MentioningMe,

        /// <summary>
        /// Next target in supplied range.
        /// </summary>
        [XurrentEnum("nextTargetAt")]
        NextTargetAt,

        /// <summary>
        /// Target indication filter on Next target.
        /// </summary>
        [XurrentEnum("nextTargetIndication")]
        NextTargetIndication,

        /// <summary>
        /// Filter on Operating system.
        /// </summary>
        [XurrentEnum("operatingSystem")]
        OperatingSystem,

        /// <summary>
        /// Filter on Requester organization.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// Filter on Requester organization region.
        /// </summary>
        [XurrentEnum("organizationRegion")]
        OrganizationRegion,

        /// <summary>
        /// Filter on Problem.
        /// </summary>
        [XurrentEnum("problem")]
        Problem,

        /// <summary>
        /// Filter on Product.
        /// </summary>
        [XurrentEnum("product")]
        Product,

        /// <summary>
        /// Filter on Product backlog.
        /// </summary>
        [XurrentEnum("productBacklog")]
        ProductBacklog,

        /// <summary>
        /// Filter on Product brand.
        /// </summary>
        [XurrentEnum("productBrand")]
        ProductBrand,

        /// <summary>
        /// Filter on Product category.
        /// </summary>
        [XurrentEnum("productCategory")]
        ProductCategory,

        /// <summary>
        /// Filter on Project.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// Include only if Provider not accountable matches supplied value.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// Include only if Provider was not accountable matches supplied value.
        /// </summary>
        [XurrentEnum("providerWasNotAccountable")]
        ProviderWasNotAccountable,

        /// <summary>
        /// Include only if Registered by Service Desk matches supplied value.
        /// </summary>
        [XurrentEnum("registeredBySd")]
        RegisteredBySd,

        /// <summary>
        /// Filter on Requested by.
        /// </summary>
        [XurrentEnum("requestedBy")]
        RequestedBy,

        /// <summary>
        /// Filter on Requester.
        /// </summary>
        [XurrentEnum("requestedFor")]
        RequestedFor,

        /// <summary>
        /// Filter on Site.
        /// </summary>
        [XurrentEnum("requestedForSite")]
        RequestedForSite,

        /// <summary>
        /// Include only if Requested for VIP matches supplied value.
        /// </summary>
        [XurrentEnum("requestedForVip")]
        RequestedForVip,

        /// <summary>
        /// Filter on record ID as displayed in UI.
        /// </summary>
        [XurrentEnum("requestId")]
        RequestId,

        /// <summary>
        /// Responded in supplied range.
        /// </summary>
        [XurrentEnum("respondedAt")]
        RespondedAt,

        /// <summary>
        /// Filter on Person.
        /// </summary>
        [XurrentEnum("respondent")]
        Respondent,

        /// <summary>
        /// Filter on Response.
        /// </summary>
        [XurrentEnum("response")]
        Response,

        /// <summary>
        /// Filter on Satisfaction.
        /// </summary>
        [XurrentEnum("satisfaction")]
        Satisfaction,

        /// <summary>
        /// Responded in supplied range.
        /// </summary>
        [XurrentEnum("satisfactionAt")]
        SatisfactionAt,

        /// <summary>
        /// Filter on Sentiment.
        /// </summary>
        [XurrentEnum("sentiment")]
        Sentiment,

        /// <summary>
        /// Filter on Sentiment trend.
        /// </summary>
        [XurrentEnum("sentimentTrend")]
        SentimentTrend,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service category.
        /// </summary>
        [XurrentEnum("serviceCategory")]
        ServiceCategory,

        /// <summary>
        /// Filter on Service instance.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// Filter on Service owner.
        /// </summary>
        [XurrentEnum("serviceOwner")]
        ServiceOwner,

        /// <summary>
        /// Filter on Service problem manager.
        /// </summary>
        [XurrentEnum("serviceProblemManager")]
        ServiceProblemManager,

        /// <summary>
        /// Filter on Service provider.
        /// </summary>
        [XurrentEnum("serviceProvider")]
        ServiceProvider,

        /// <summary>
        /// Filter on Customer.
        /// </summary>
        [XurrentEnum("slaCustomer")]
        SlaCustomer,

        /// <summary>
        /// Filter on Customer account.
        /// </summary>
        [XurrentEnum("slaCustomerAccount")]
        SlaCustomerAccount,

        /// <summary>
        /// Filter on Customer region.
        /// </summary>
        [XurrentEnum("slaCustomerRegion")]
        SlaCustomerRegion,

        /// <summary>
        /// Filter on Provider account.
        /// </summary>
        [XurrentEnum("slaProviderAccount")]
        SlaProviderAccount,

        /// <summary>
        /// Filter on Id.
        /// </summary>
        [XurrentEnum("slaServiceProvider")]
        SlaServiceProvider,

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
        /// Filter on Tag.
        /// </summary>
        [XurrentEnum("tag")]
        Tag,

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
        /// Filter on Workflow phase.
        /// </summary>
        [XurrentEnum("workflowPhase")]
        WorkflowPhase,

        /// <summary>
        /// Filter on Workflow status.
        /// </summary>
        [XurrentEnum("workflowStatus")]
        WorkflowStatus,

        /// <summary>
        /// Filter on Workflow template.
        /// </summary>
        [XurrentEnum("workflowTemplate")]
        WorkflowTemplate,

        /// <summary>
        /// Filter on Workflow type.
        /// </summary>
        [XurrentEnum("workflowType")]
        WorkflowType
    }
}
