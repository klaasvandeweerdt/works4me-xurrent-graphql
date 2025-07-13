using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The project task category values.
    /// </summary>
    public enum ProjectTaskCategory
    {
        /// <summary>
        /// Activity.
        /// </summary>
        [XurrentEnum("activity")]
        Activity,

        /// <summary>
        /// Approval.
        /// </summary>
        [XurrentEnum("approval")]
        Approval,

        /// <summary>
        /// Milestone.
        /// </summary>
        [XurrentEnum("milestone")]
        Milestone
    }
}
