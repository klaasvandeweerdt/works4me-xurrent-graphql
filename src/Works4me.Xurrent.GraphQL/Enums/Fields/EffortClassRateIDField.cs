using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRateID">EffortClassRateID</see> fields.
    /// </summary>
    public enum EffortClassRateIDField
    {
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
        /// The rate id field.
        /// </summary>
        [XurrentEnum("rateID")]
        RateID
    }
}
