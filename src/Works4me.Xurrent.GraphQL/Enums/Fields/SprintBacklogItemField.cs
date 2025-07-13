using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SprintBacklogItem">SprintBacklogItem</see> fields.
    /// </summary>
    public enum SprintBacklogItemField
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
        /// The done field.
        /// </summary>
        [XurrentEnum("done")]
        Done,

        /// <summary>
        /// The estimate field.
        /// </summary>
        [XurrentEnum("estimate")]
        Estimate,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The planned field.
        /// </summary>
        [XurrentEnum("planned")]
        Planned,

        /// <summary>
        /// The position field.
        /// </summary>
        [XurrentEnum("position")]
        Position,

        /// <summary>
        /// The record field.
        /// </summary>
        [XurrentEnum("record")]
        Record,

        /// <summary>
        /// The sprint field.
        /// </summary>
        [XurrentEnum("sprint")]
        Sprint,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
