using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Service can be ordered on.
    /// </summary>
    public enum ServiceOrderField
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
        /// Order by <c>Keywords</c>.
        /// </summary>
        [XurrentEnum("keywords")]
        Keywords,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>ProviderName</c>.
        /// </summary>
        [XurrentEnum("providerName")]
        ProviderName,

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
