using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The time allocation service category values.
    /// </summary>
    public enum TimeAllocationServiceCategory
    {
        /// <summary>
        /// Any.
        /// </summary>
        [XurrentEnum("any")]
        Any,

        /// <summary>
        /// None.
        /// </summary>
        [XurrentEnum("none")]
        None,

        /// <summary>
        /// One of the following.
        /// </summary>
        [XurrentEnum("selected")]
        Selected
    }
}
