using System.Collections.Immutable;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Defines the contract for GraphQL mutations, including the mutation name, data type, underlying query, and affected fields.
    /// </summary>
    internal interface IMutation
    {
        /// <summary>
        /// Gets the name of the mutation.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the GraphQL data type name for the mutation.
        /// </summary>
        string DataTypeName { get; }

        /// <summary>
        /// Gets the underlying <see cref="IQuery"/> associated with this mutation.
        /// </summary>
        IQuery Query { get; }

        /// <summary>
        /// Gets the set of field names that are affected by this mutation.
        /// </summary>
        /// <returns>An <see cref="ImmutableHashSet{String}"/> of changed or included field names.</returns>
        ImmutableHashSet<string> GetFields();
    }
}
