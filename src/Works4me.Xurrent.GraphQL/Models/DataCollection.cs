using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// A collection that ensures unique items based on their merge key and merges connection data when duplicates are added.
    /// </summary>
    /// <typeparam name="T">The type of data item, which must implement <see cref="IDataItem"/>.</typeparam>
    internal sealed class DataCollection<T> : KeyedCollection<string, T> where T : IDataItem
    {
        /// <summary>
        /// Retrieves the key for the given item by invoking its <see cref="IDataItem.GetMergeKey"/> method.
        /// </summary>
        /// <param name="item">The data item whose merge key is to be retrieved.</param>
        /// <returns>The merge key string for the specified <paramref name="item"/>.</returns>
        protected override string GetKeyForItem(T item)
        {
            return item.GetMergeKey();
        }

        /// <summary>
        /// Adds a new item to the collection. If an item with the same merge key already exists, merges connection data instead.
        /// </summary>
        /// <param name="item">The item to add or merge.</param>
        public new void Add(T item)
        {
            if (Contains(item.GetMergeKey()))
                this[item.GetMergeKey()].MergeConnectionData(item);
            else
                base.Add(item);
        }

        /// <summary>
        /// Inserts an item at the specified index. If an item with the same merge key already exists, merges connection data instead.
        /// </summary>
        /// <param name="index">The zero-based index at which to insert the <paramref name="item"/>.</param>
        /// <param name="item">The item to insert or merge.</param>
        protected override void InsertItem(int index, T item)
        {
            if (Contains(item.GetMergeKey()))
                this[item.GetMergeKey()].MergeConnectionData(item);
            else
                base.InsertItem(index, item);
        }

        /// <summary>
        /// Adds a range of items to the collection. For each item, merges connection data if a duplicate merge key exists.
        /// </summary>
        /// <param name="collection">The collection of items to add or merge.</param>
        public void AddRange(IEnumerable<T>? collection)
        {
            if (collection is not null)
            {
                foreach (T item in collection)
                {
                    Add(item);
                }   
            }
        }
    }
}
