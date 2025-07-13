using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents the default filter field used when no specific filters are defined for an entity.
    /// </summary>
    public enum DefaultFilterField
    {
        /// <summary>
        /// Indicates that no filter is applied.
        /// </summary>
        [XurrentEnum(null)]
        None
    }
}
