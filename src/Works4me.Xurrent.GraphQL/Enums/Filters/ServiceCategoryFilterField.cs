using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Attributes to filter service categories.
    /// </summary>
    public enum ServiceCategoryFilterField
    {
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// IDs to select.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Name of service category.
        /// </summary>
        [XurrentEnum("name", FilterBehavior = FilterBehavior.Simple)]
        Name,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on SourceID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
