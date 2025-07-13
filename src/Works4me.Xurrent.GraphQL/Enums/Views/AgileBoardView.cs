using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on AgileBoards.
    /// </summary>
    public enum AgileBoardView
    {
        /// <summary>
        /// Agile Boards.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All AgileBoards which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
