using System.Collections.Generic;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents a read-only collection of keyed data items that can be accessed by their merge key.
    /// </summary>
    /// <typeparam name="T">The type of data item, which must implement <see cref="IDataItem"/>.</typeparam>
    public interface IReadOnlyDataCollection<T> : IReadOnlyCollection<T> where T : IDataItem
    {
        /// <summary>
        /// Determines whether the collection contains an item with the specified merge key.
        /// </summary>
        /// <param name="key">The merge key of the item to locate.</param>
        /// <returns>
        /// <c>true</c> if the collection contains an item with the specified key; otherwise, <c>false</c>.
        /// </returns>
        bool Contains(string key);

        /// <summary>
        /// Gets the item with the specified merge key.
        /// </summary>
        /// <param name="key">The merge key of the item to get.</param>
        /// <returns>
        /// The data item associated with the specified key.
        /// </returns>
        T this[string key] { get; }
    }
}
