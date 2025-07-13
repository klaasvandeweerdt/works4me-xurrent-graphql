using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The discovered item strategy values.
    /// </summary>
    public enum DiscoveredItemStrategy
    {
        /// <summary>
        /// Create a new record based on the information supplied if and only if one does not already exists.
        /// </summary>
        [XurrentEnum("CREATE")]
        Create,

        /// <summary>
        /// Similar to CREATE. Difference is that discovered records within this product (category) will only be linked to this record on create. So if the discovered records are already present in Xurrent they will remain linked to their current parent, the value supplied in the mutation will be ignored.
        /// </summary>
        [XurrentEnum("DEFAULT")]
        Default,

        /// <summary>
        /// Creates a new record if one does not already exists, otherwise updates the existing record using the values supplied.
        /// </summary>
        [XurrentEnum("UPDATE")]
        Update
    }
}
