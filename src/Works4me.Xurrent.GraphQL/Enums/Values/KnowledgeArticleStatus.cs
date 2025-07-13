using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The knowledge article status values.
    /// </summary>
    public enum KnowledgeArticleStatus
    {
        /// <summary>
        /// Archived.
        /// </summary>
        [XurrentEnum("archived")]
        Archived,

        /// <summary>
        /// Not validated.
        /// </summary>
        [XurrentEnum("not_validated")]
        NotValidated,

        /// <summary>
        /// Validated.
        /// </summary>
        [XurrentEnum("validated")]
        Validated,

        /// <summary>
        /// Work in progress.
        /// </summary>
        [XurrentEnum("work_in_progress")]
        WorkInProgress
    }
}
