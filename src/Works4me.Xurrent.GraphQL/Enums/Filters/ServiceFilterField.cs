using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Service records are returned.
    /// </summary>
    public enum ServiceFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on Availability manager.
        /// </summary>
        [XurrentEnum("availabilityManager")]
        AvailabilityManager,

        /// <summary>
        /// Filter on Capacity manager.
        /// </summary>
        [XurrentEnum("capacityManager")]
        CapacityManager,

        /// <summary>
        /// Filter on Change manager.
        /// </summary>
        [XurrentEnum("changeManager")]
        ChangeManager,

        /// <summary>
        /// Filter on Continuity manager.
        /// </summary>
        [XurrentEnum("continuityManager")]
        ContinuityManager,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

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
        /// Filter on Knowledge manager.
        /// </summary>
        [XurrentEnum("knowledgeManager")]
        KnowledgeManager,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Problem manager.
        /// </summary>
        [XurrentEnum("problemManager")]
        ProblemManager,

        /// <summary>
        /// Filter on Service provider.
        /// </summary>
        [XurrentEnum("provider")]
        Provider,

        /// <summary>
        /// Filter on Release manager.
        /// </summary>
        [XurrentEnum("releaseManager")]
        ReleaseManager,

        /// <summary>
        /// Filter on Service owner.
        /// </summary>
        [XurrentEnum("serviceOwner")]
        ServiceOwner,

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
        /// Filter on Support team.
        /// </summary>
        [XurrentEnum("supportTeam")]
        SupportTeam,

        /// <summary>
        /// Filter on Survey.
        /// </summary>
        [XurrentEnum("survey")]
        Survey,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
