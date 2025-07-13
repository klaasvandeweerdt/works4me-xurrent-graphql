using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which AffectedSla records are returned.
    /// </summary>
    public enum AffectedSlaFilterField
    {
        /// <summary>
        /// Filter on Accountability.
        /// </summary>
        [XurrentEnum("accountability")]
        Accountability,

        /// <summary>
        /// Actual resolution in supplied range.
        /// </summary>
        [XurrentEnum("actualResolutionAt")]
        ActualResolutionAt,

        /// <summary>
        /// Actual response in supplied range.
        /// </summary>
        [XurrentEnum("actualResponseAt")]
        ActualResponseAt,

        /// <summary>
        /// Include only if Best effort resolution target matches supplied value.
        /// </summary>
        [XurrentEnum("bestEffortResolutionTarget")]
        BestEffortResolutionTarget,

        /// <summary>
        /// Filter on Business unit.
        /// </summary>
        [XurrentEnum("businessUnit")]
        BusinessUnit,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on First line team.
        /// </summary>
        [XurrentEnum("firstLineTeam")]
        FirstLineTeam,

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
        /// Filter on Request.
        /// </summary>
        [XurrentEnum("request")]
        Request,

        /// <summary>
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("requestCategory")]
        RequestCategory,

        /// <summary>
        /// Filter on Completion reason.
        /// </summary>
        [XurrentEnum("requestCompletionReason")]
        RequestCompletionReason,

        /// <summary>
        /// Filter on Requester.
        /// </summary>
        [XurrentEnum("requestedFor")]
        RequestedFor,

        /// <summary>
        /// Include only if Requester covered matches supplied value.
        /// </summary>
        [XurrentEnum("requesterCovered")]
        RequesterCovered,

        /// <summary>
        /// Filter on Requester organization.
        /// </summary>
        [XurrentEnum("requesterOrganization")]
        RequesterOrganization,

        /// <summary>
        /// Filter on Requester organization region.
        /// </summary>
        [XurrentEnum("requesterOrganizationRegion")]
        RequesterOrganizationRegion,

        /// <summary>
        /// Filter on Requester site.
        /// </summary>
        [XurrentEnum("requesterSite")]
        RequesterSite,

        /// <summary>
        /// Filter on Member.
        /// </summary>
        [XurrentEnum("requestMember")]
        RequestMember,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("requestSource")]
        RequestSource,

        /// <summary>
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("requestStatus")]
        RequestStatus,

        /// <summary>
        /// Filter on Team.
        /// </summary>
        [XurrentEnum("requestTeam")]
        RequestTeam,

        /// <summary>
        /// Resolution target in supplied range.
        /// </summary>
        [XurrentEnum("resolutionTargetAt")]
        ResolutionTargetAt,

        /// <summary>
        /// Target indication filter on Resolution target.
        /// </summary>
        [XurrentEnum("resolutionTargetIndication")]
        ResolutionTargetIndication,

        /// <summary>
        /// Response target in supplied range.
        /// </summary>
        [XurrentEnum("responseTargetAt")]
        ResponseTargetAt,

        /// <summary>
        /// Target indication filter on Response target.
        /// </summary>
        [XurrentEnum("responseTargetIndication")]
        ResponseTargetIndication,

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
        /// Filter on Service level agreement.
        /// </summary>
        [XurrentEnum("serviceLevelAgreement")]
        ServiceLevelAgreement,

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
        /// Filter on Provider account.
        /// </summary>
        [XurrentEnum("slaAccount")]
        SlaAccount,

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
        /// Filter on Support team.
        /// </summary>
        [XurrentEnum("supportTeam")]
        SupportTeam,

        /// <summary>
        /// Filter on Template.
        /// </summary>
        [XurrentEnum("template")]
        Template,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
