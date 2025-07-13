using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which AppOffering records are returned.
    /// </summary>
    public enum AppOfferingFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

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
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Include only if Latest matches supplied value.
        /// </summary>
        [XurrentEnum("latest")]
        Latest,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Include only if Published matches supplied value.
        /// </summary>
        [XurrentEnum("published")]
        Published,

        /// <summary>
        /// Filter on Reference.
        /// </summary>
        [XurrentEnum("reference")]
        Reference,

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
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
