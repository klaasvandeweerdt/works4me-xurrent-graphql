using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which SurveyResponse records are returned.
    /// </summary>
    public enum SurveyResponseFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Include only if Completed matches supplied value.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on Customer account.
        /// </summary>
        [XurrentEnum("customerAccount")]
        CustomerAccount,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Rating.
        /// </summary>
        [XurrentEnum("rating")]
        Rating,

        /// <summary>
        /// Responded in supplied range.
        /// </summary>
        [XurrentEnum("respondedAt")]
        RespondedAt,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service level agreement.
        /// </summary>
        [XurrentEnum("sla")]
        Sla,

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
