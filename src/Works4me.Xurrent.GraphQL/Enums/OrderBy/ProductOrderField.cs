using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Product can be ordered on.
    /// </summary>
    public enum ProductOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Disabled</c>.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>RuleSet</c>.
        /// </summary>
        [XurrentEnum("ruleSet")]
        RuleSet,

        /// <summary>
        /// Order by <c>SupportTeamName</c>.
        /// </summary>
        [XurrentEnum("supportTeamName")]
        SupportTeamName,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
