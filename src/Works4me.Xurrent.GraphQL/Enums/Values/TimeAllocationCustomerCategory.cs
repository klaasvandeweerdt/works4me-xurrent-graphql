using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The time allocation customer category values.
    /// </summary>
    public enum TimeAllocationCustomerCategory
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
