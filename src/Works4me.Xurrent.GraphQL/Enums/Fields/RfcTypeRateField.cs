using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RfcTypeRate">RfcTypeRate</see> fields.
    /// </summary>
    public enum RfcTypeRateField
    {
        /// <summary>
        /// The charge type field.
        /// </summary>
        [XurrentEnum("chargeType")]
        ChargeType,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

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
        /// The rfc type field.
        /// </summary>
        [XurrentEnum("rfcType")]
        RfcType,

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
