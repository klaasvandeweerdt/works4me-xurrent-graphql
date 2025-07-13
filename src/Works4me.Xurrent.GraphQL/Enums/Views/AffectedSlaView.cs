using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on AffectedSlas.
    /// </summary>
    public enum AffectedSlaView
    {
        /// <summary>
        /// Affected SLAs.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All AffectedSlas which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
