using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Period">Period</see> fields.
    /// </summary>
    public enum PeriodField
    {
        /// <summary>
        /// The from field.
        /// </summary>
        [XurrentEnum("from")]
        From,

        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// The to field.
        /// </summary>
        [XurrentEnum("to")]
        To
    }
}
