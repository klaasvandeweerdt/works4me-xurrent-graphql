using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The ci relation relation type values.
    /// </summary>
    public enum CiRelationRelationType
    {
        /// <summary>
        /// Child.
        /// </summary>
        [XurrentEnum("child")]
        Child,

        /// <summary>
        /// Continuity.
        /// </summary>
        [XurrentEnum("continuity")]
        Continuity,

        /// <summary>
        /// Network connection.
        /// </summary>
        [XurrentEnum("network_connection")]
        NetworkConnection,

        /// <summary>
        /// Parent.
        /// </summary>
        [XurrentEnum("parent")]
        Parent,

        /// <summary>
        /// Redundancy.
        /// </summary>
        [XurrentEnum("redundancy")]
        Redundancy,

        /// <summary>
        /// Software dependency.
        /// </summary>
        [XurrentEnum("software_dependency")]
        SoftwareDependency
    }
}
