using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which KnowledgeArticle records are returned.
    /// </summary>
    public enum KnowledgeArticleFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Archive date in supplied range.
        /// </summary>
        [XurrentEnum("archiveDate")]
        ArchiveDate,

        /// <summary>
        /// Include only if Covered specialists matches supplied value.
        /// </summary>
        [XurrentEnum("coveredSpecialists")]
        CoveredSpecialists,

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
        /// Include only if End users matches supplied value.
        /// </summary>
        [XurrentEnum("endUsers")]
        EndUsers,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Include only if Internal specialists matches supplied value.
        /// </summary>
        [XurrentEnum("internalSpecialists")]
        InternalSpecialists,

        /// <summary>
        /// Include only if Key contacts matches supplied value.
        /// </summary>
        [XurrentEnum("keyContacts")]
        KeyContacts,

        /// <summary>
        /// Filter on Knowledge manager.
        /// </summary>
        [XurrentEnum("knowledgeManager")]
        KnowledgeManager,

        /// <summary>
        /// Include only if Public matches supplied value.
        /// </summary>
        [XurrentEnum("public")]
        Public,

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
        /// Filter on Updated by.
        /// </summary>
        [XurrentEnum("updatedBy")]
        UpdatedBy
    }
}
