using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="VirtualAgentDesign">VirtualAgentDesign</see> fields.
    /// </summary>
    public enum VirtualAgentDesignField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The agent instructions field.
        /// </summary>
        [XurrentEnum("agentInstructions")]
        AgentInstructions,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The validation reasoning field.
        /// </summary>
        [XurrentEnum("validationReasoning")]
        ValidationReasoning,

        /// <summary>
        /// The validation status field.
        /// </summary>
        [XurrentEnum("validationStatus")]
        ValidationStatus
    }
}
