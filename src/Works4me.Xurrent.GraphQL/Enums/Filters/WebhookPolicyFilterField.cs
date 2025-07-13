using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum WebhookPolicyFilterField
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
        /// Updated at in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
