using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The scope effect values.
    /// </summary>
    public enum ScopeEffect
    {
        /// <summary>
        /// Allow.
        /// </summary>
        [XurrentEnum("allow")]
        Allow,

        /// <summary>
        /// Deny.
        /// </summary>
        [XurrentEnum("deny")]
        Deny
    }
}
