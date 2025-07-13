using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TimeAllocation">TimeAllocation</see> fields.
    /// </summary>
    public enum TimeAllocationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The customer category field.
        /// </summary>
        [XurrentEnum("customerCategory")]
        CustomerCategory,

        /// <summary>
        /// The description category field.
        /// </summary>
        [XurrentEnum("descriptionCategory")]
        DescriptionCategory,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The effort class field.
        /// </summary>
        [XurrentEnum("effortClass")]
        EffortClass,

        /// <summary>
        /// The group field.
        /// </summary>
        [XurrentEnum("group")]
        Group,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The service category field.
        /// </summary>
        [XurrentEnum("serviceCategory")]
        ServiceCategory,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
