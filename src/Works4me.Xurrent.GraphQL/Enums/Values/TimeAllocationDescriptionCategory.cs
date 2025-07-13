using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The time allocation description category values.
    /// </summary>
    public enum TimeAllocationDescriptionCategory
    {
        /// <summary>
        /// Hidden.
        /// </summary>
        [XurrentEnum("hidden")]
        Hidden,

        /// <summary>
        /// Optional.
        /// </summary>
        [XurrentEnum("optional")]
        Optional,

        /// <summary>
        /// Required.
        /// </summary>
        [XurrentEnum("required")]
        Required
    }
}
