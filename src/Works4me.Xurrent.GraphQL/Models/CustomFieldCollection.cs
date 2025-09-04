using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Extensions;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents a collection of <see cref="CustomField"/> objects, keyed by their unique identifier.
    /// </summary>
    public class CustomFieldCollection : KeyedCollection<string, CustomField>
    {
        /// <summary>
        /// Initializes a new, empty instance of the <see cref="CustomFieldCollection"/> class.
        /// </summary>
        public CustomFieldCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldCollection"/> class and populates it with the specified items.
        /// </summary>
        /// <param name="items">The custom fields to add to the collection.</param>
        public CustomFieldCollection(IEnumerable<CustomField> items)
            : this()
        {
            if (items is not null)
            {
                foreach (CustomField item in items)
                    Add(item);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="CustomField"/> with the specified key.
        /// </summary>
        /// <param name="key">The identifier of the custom field to get or set.</param>
        /// <returns>The <see cref="CustomField"/> associated with the specified <paramref name="key"/>.</returns>
        /// <exception cref="ArgumentException">Thrown if <paramref name="key"/> is <c>null</c>.</exception>
        public new JsonElement? this[string key]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new ArgumentException($"'{nameof(key)}' cannot be null or whitespace.", nameof(key));

                if (this.TryGetValue(key, out CustomField? value))
                    return value?.Value;

                return null;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new ArgumentException($"'{nameof(key)}' cannot be null or whitespace.", nameof(key));

                if (this.TryGetValue(key, out CustomField? existing))
                {
                    existing!.Value = value;
                }
                else
                {
                    base.Add(new CustomField() { Id = key, Value = value });
                }
            }
        }

        /// <summary>
        /// Returns the key for the specified <see cref="CustomField"/> item.
        /// </summary>
        /// <param name="item">The <see cref="CustomField"/> instance from which to extract the key.</param>
        /// <returns>The value of the <see cref="CustomField.Id"/> property for the specified <paramref name="item"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the <paramref name="item"/> is <c>null</c>.</exception>
        protected override string GetKeyForItem(CustomField item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            return item.Id;
        }

        /// <summary>
        /// Adds a new <see cref="CustomField"/> to the collection, using the specified identifier and value.
        /// </summary>
        /// <param name="item">The object to be added to the end of the collection.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="item"/> is <c>null</c>.</exception>
        public new void Add(CustomField item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            this[item.Id] = item.Value;
        }

        /// <summary>
        /// Adds a new <see cref="CustomField"/> to the collection, using the specified identifier and value.
        /// </summary>
        /// <param name="id">The unique identifier for the custom field.</param>
        /// <param name="value">
        /// The value of the field.<br/>
        /// • For <c>select</c> fields, this is the HTML value defined for the field (not the display text).<br/>
        /// • For <c>...-suggest</c> fields, this is the node identifier of the selected record.<br/>
        /// • For <c>custom-suggest</c> fields, this is the node identifier of the selected record, or an array of node IDs for multiple selections.<br/>
        /// </param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="id"/> is <c>null</c>, empty, or whitespace.</exception>
        public void Add(string id, JsonElement? value)
        {
            this[id] = value;
        }
    }
}
