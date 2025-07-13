using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The service offering review frequency values.
    /// </summary>
    public enum ServiceOfferingReviewFrequency
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [XurrentEnum("daily")]
        Daily,

        /// <summary>
        /// Monthly.
        /// </summary>
        [XurrentEnum("monthly")]
        Monthly,

        /// <summary>
        /// No commitment.
        /// </summary>
        [XurrentEnum("no_commitment")]
        NoCommitment,

        /// <summary>
        /// Once every 2 months.
        /// </summary>
        [XurrentEnum("once_every_2_months")]
        OnceEvery2Months,

        /// <summary>
        /// Once every 2 weeks.
        /// </summary>
        [XurrentEnum("once_every_2_weeks")]
        OnceEvery2Weeks,

        /// <summary>
        /// Once every 2 years.
        /// </summary>
        [XurrentEnum("once_every_2_years")]
        OnceEvery2Years,

        /// <summary>
        /// Once every 6 months.
        /// </summary>
        [XurrentEnum("once_every_6_months")]
        OnceEvery6Months,

        /// <summary>
        /// Quarterly.
        /// </summary>
        [XurrentEnum("quarterly")]
        Quarterly,

        /// <summary>
        /// Weekly.
        /// </summary>
        [XurrentEnum("weekly")]
        Weekly,

        /// <summary>
        /// Yearly.
        /// </summary>
        [XurrentEnum("yearly")]
        Yearly
    }
}
