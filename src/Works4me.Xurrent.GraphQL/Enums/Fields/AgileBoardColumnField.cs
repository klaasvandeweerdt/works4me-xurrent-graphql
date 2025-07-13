using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoardColumn">AgileBoardColumn</see> fields.
    /// </summary>
    public enum AgileBoardColumnField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The action type field.
        /// </summary>
        [XurrentEnum("actionType")]
        ActionType,

        /// <summary>
        /// The agile board field.
        /// </summary>
        [XurrentEnum("agileBoard")]
        AgileBoard,

        /// <summary>
        /// The clear member field.
        /// </summary>
        [XurrentEnum("clearMember")]
        ClearMember,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The dialog type field.
        /// </summary>
        [XurrentEnum("dialogType")]
        DialogType,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The member field.
        /// </summary>
        [XurrentEnum("member")]
        Member,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The position field.
        /// </summary>
        [XurrentEnum("position")]
        Position,

        /// <summary>
        /// The remove after field.
        /// </summary>
        [XurrentEnum("removeAfter")]
        RemoveAfter,

        /// <summary>
        /// The team field.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The wip limit field.
        /// </summary>
        [XurrentEnum("wipLimit")]
        WipLimit
    }
}
