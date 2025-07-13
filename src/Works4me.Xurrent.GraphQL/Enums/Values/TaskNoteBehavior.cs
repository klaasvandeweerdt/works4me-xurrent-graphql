using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The task note behavior values.
    /// </summary>
    public enum TaskNoteBehavior
    {
        /// <summary>
        /// Hidden.
        /// </summary>
        [XurrentEnum("hidden")]
        Hidden,

        /// <summary>
        /// Optional on approval.
        /// </summary>
        [XurrentEnum("optional_on_approval")]
        OptionalOnApproval,

        /// <summary>
        /// Optional on completion.
        /// </summary>
        [XurrentEnum("optional_on_completion")]
        OptionalOnCompletion,

        /// <summary>
        /// Required on approval.
        /// </summary>
        [XurrentEnum("required_on_approval")]
        RequiredOnApproval,

        /// <summary>
        /// Required on completion.
        /// </summary>
        [XurrentEnum("required_on_completion")]
        RequiredOnCompletion
    }
}
