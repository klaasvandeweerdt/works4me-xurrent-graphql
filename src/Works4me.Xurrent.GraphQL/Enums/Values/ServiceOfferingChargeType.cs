using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The service offering charge type values.
    /// </summary>
    public enum ServiceOfferingChargeType
    {
        /// <summary>
        /// Fixed price.
        /// </summary>
        [XurrentEnum("fixed_price")]
        FixedPrice,

        /// <summary>
        /// Time material.
        /// </summary>
        [XurrentEnum("time_material")]
        TimeMaterial
    }
}
