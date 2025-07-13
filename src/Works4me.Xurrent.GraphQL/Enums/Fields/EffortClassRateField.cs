using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRate">EffortClassRate</see> fields.
    /// </summary>
    public enum EffortClassRateField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The effort class field.
        /// </summary>
        [XurrentEnum("effortClass")]
        EffortClass,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The rate field.
        /// </summary>
        [XurrentEnum("rate")]
        Rate,

        /// <summary>
        /// The rate currency field.
        /// </summary>
        [XurrentEnum("rateCurrency")]
        RateCurrency,

        /// <summary>
        /// The service offering field.
        /// </summary>
        [XurrentEnum("serviceOffering")]
        ServiceOffering,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
