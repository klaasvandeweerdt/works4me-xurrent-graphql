using System.Collections.Generic;
using System.Text.Json;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Defines a read-only collection of <see cref="CustomField"/> objects, accessible by key.
    /// </summary>
    public interface IReadOnlyCustomFieldCollection : IReadOnlyCollection<CustomField>
    {
        /// <summary>
        /// Gets the <see cref="CustomField"/> associated with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the custom field.</param>
        /// <returns>The <see cref="CustomField"/> with the specified identifier.</returns>
        JsonElement? this[string id] { get; }

        /// <summary>
        /// Determines whether the collection contains a <see cref="CustomField"/> with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier to locate.</param>
        /// <returns><c>true</c> if found; otherwise, <c>false</c>.</returns>
        bool Contains(string id);
    }
}
