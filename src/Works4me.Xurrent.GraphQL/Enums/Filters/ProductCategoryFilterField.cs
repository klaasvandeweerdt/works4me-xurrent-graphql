using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which ProductCategory records are returned.
    /// </summary>
    public enum ProductCategoryFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Filter on Group.
        /// </summary>
        [XurrentEnum("group")]
        Group,

        /// <summary>
        /// DEPRECATED: Use <c>group</c> instead. Groups to select.
        /// </summary>
        [XurrentEnum("groups")]
        Groups,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Reference.
        /// </summary>
        [XurrentEnum("reference")]
        Reference,

        /// <summary>
        /// DEPRECATED: Use <c>reference</c> instead. References to select.
        /// </summary>
        [XurrentEnum("references")]
        References,

        /// <summary>
        /// Filter on Rule set.
        /// </summary>
        [XurrentEnum("ruleSet")]
        RuleSet,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
