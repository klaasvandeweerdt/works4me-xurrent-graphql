using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The workflow justification values.
    /// </summary>
    public enum WorkflowJustification
    {
        /// <summary>
        /// Compliance.
        /// </summary>
        [XurrentEnum("compliance")]
        Compliance,

        /// <summary>
        /// Correction.
        /// </summary>
        [XurrentEnum("correction")]
        Correction,

        /// <summary>
        /// Expansion.
        /// </summary>
        [XurrentEnum("expansion")]
        Expansion,

        /// <summary>
        /// Improvement.
        /// </summary>
        [XurrentEnum("improvement")]
        Improvement,

        /// <summary>
        /// Maintenance.
        /// </summary>
        [XurrentEnum("maintenance")]
        Maintenance,

        /// <summary>
        /// Move.
        /// </summary>
        [XurrentEnum("move")]
        Move,

        /// <summary>
        /// Purchase.
        /// </summary>
        [XurrentEnum("purchase")]
        Purchase,

        /// <summary>
        /// Removal.
        /// </summary>
        [XurrentEnum("removal")]
        Removal,

        /// <summary>
        /// Replacement.
        /// </summary>
        [XurrentEnum("replacement")]
        Replacement
    }
}
