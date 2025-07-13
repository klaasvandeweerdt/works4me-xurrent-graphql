using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The contact protocol values.
    /// </summary>
    public enum ContactProtocol
    {
        /// <summary>
        /// Chat.
        /// </summary>
        [XurrentEnum("chat")]
        Chat,

        /// <summary>
        /// Email.
        /// </summary>
        [XurrentEnum("email")]
        Email,

        /// <summary>
        /// Telephone.
        /// </summary>
        [XurrentEnum("telephone")]
        Telephone,

        /// <summary>
        /// Website.
        /// </summary>
        [XurrentEnum("website")]
        Website
    }
}
