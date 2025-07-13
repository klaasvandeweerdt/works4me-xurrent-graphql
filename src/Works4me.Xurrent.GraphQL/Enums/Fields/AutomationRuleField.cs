using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRule">AutomationRule</see> fields.
    /// </summary>
    public enum AutomationRuleField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The actions field.
        /// </summary>
        [XurrentEnum("actions")]
        Actions,

        /// <summary>
        /// The condition field.
        /// </summary>
        [XurrentEnum("condition")]
        Condition,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The expressions field.
        /// </summary>
        [XurrentEnum("expressions")]
        Expressions,

        /// <summary>
        /// The generic field.
        /// </summary>
        [XurrentEnum("generic")]
        Generic,

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
        /// The owner field.
        /// </summary>
        [XurrentEnum("owner")]
        Owner,

        /// <summary>
        /// The position field.
        /// </summary>
        [XurrentEnum("position")]
        Position,

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
        /// The trigger field.
        /// </summary>
        [XurrentEnum("trigger")]
        Trigger,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
