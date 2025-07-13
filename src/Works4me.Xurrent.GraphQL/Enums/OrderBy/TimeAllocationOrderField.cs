using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields TimeAllocation can be ordered on.
    /// </summary>
    public enum TimeAllocationOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>CustomerCategoryId</c>.
        /// </summary>
        [XurrentEnum("customerCategoryId")]
        CustomerCategoryId,

        /// <summary>
        /// Order by <c>Disabled</c>.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Order by <c>GroupName</c>.
        /// </summary>
        [XurrentEnum("groupName")]
        GroupName,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>ServiceCategoryId</c>.
        /// </summary>
        [XurrentEnum("serviceCategoryId")]
        ServiceCategoryId,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
