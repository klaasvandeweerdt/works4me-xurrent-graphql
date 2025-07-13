using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The discovered reference array strategy values.
    /// </summary>
    public enum DiscoveredReferenceArrayStrategy
    {
        /// <summary>
        /// Ensures the supplied reference is present. If the supplied value is already present no action is taken. If it is not it added to any existing references.
        /// </summary>
        [XurrentEnum("APPEND")]
        Append,

        /// <summary>
        /// Replaces the existing reference(s) with exactly those supplied.
        /// </summary>
        [XurrentEnum("REPLACE")]
        Replace
    }
}
