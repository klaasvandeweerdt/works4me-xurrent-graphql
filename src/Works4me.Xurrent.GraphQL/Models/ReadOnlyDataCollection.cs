using System;
using System.Collections;
using System.Collections.Generic;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Provides a read-only wrapper around a <see cref="DataCollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of data item, which must implement <see cref="IDataItem"/>.</typeparam>
    public sealed class ReadOnlyDataCollection<T> : IReadOnlyDataCollection<T> where T : IDataItem
    {
        private readonly DataCollection<T> inner;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyDataCollection{T}"/> class.
        /// </summary>
        /// <param name="dataList">The <see cref="DataCollection{T}"/> to wrap.</param>
        internal ReadOnlyDataCollection(DataCollection<T> dataList)
        {
            if (dataList is null)
                throw new ArgumentNullException(nameof(dataList));
            inner = dataList;
        }

        /// <inheritdoc/>
        public T this[string key]
        {
            get => inner[key];
        }

        /// <inheritdoc/>
        public int Count
        {
            get => inner.Count;
        }
        
        /// <inheritdoc/>
        public bool Contains(string key)
        {
            return inner.Contains(key);
        }

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator()
        {
            return inner.GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return inner.GetEnumerator();
        }
    }
}
