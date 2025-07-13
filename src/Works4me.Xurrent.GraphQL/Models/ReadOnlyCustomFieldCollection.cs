using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Provides a read-only wrapper around a <see cref="CustomFieldCollection"/>.
    /// </summary>
    public sealed class ReadOnlyCustomFieldCollection : IReadOnlyCustomFieldCollection
    {
        private readonly CustomFieldCollection inner;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyCustomFieldCollection"/> class.
        /// </summary>
        public ReadOnlyCustomFieldCollection()
        {
            inner = new();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyCustomFieldCollection"/> class.
        /// </summary>
        /// <param name="collection">The underlying <see cref="CustomFieldCollection"/> to wrap.</param>
        public ReadOnlyCustomFieldCollection(CustomFieldCollection collection)
        {
            if (collection is null)
                throw new ArgumentNullException(nameof(collection));

            inner = collection;
        }

        /// <inheritdoc/>
        public JsonElement? this[string id]
        {
            get => inner[id];
        }

        /// <inheritdoc/>
        public int Count
        {
            get => inner.Count;
        }

        /// <inheritdoc/>
        public bool Contains(string id)
        {
            return inner.Contains(id);
        }

        /// <inheritdoc/>
        public IEnumerator<CustomField> GetEnumerator()
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
