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
        /// <exception cref="KeyNotFoundException">Thrown when getting and the <paramref name="key"/> does not exist in the collection.</exception>
        public new JsonElement? this[string key]
        {
            get
            {
                if (this.TryGetValue(key, out CustomField? value))
                    return value?.Value;

                throw new KeyNotFoundException($"The given key '{key}' was not present in the collection.");
            }
            set
            {
                if (this.TryGetValue(key, out CustomField? existing))
                {
                    existing!.Value = value;
                }
                else
                {
                    Add(key, value);
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
        /// <param name="Id">The unique identifier for the custom field.</param>
        /// <param name="value">
        /// The value of the field.<br/>
        /// • For <c>select</c> fields, this is the HTML value defined for the field (not the display text).<br/>
        /// • For <c>...-suggest</c> fields, this is the node identifier of the selected record.<br/>
        /// • For <c>custom-suggest</c> fields, this is the node identifier of the selected record, or an array of node IDs for multiple selections.<br/>
        /// </param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="Id"/> is <c>null</c>, empty, or whitespace.</exception>
        public void Add(string Id, JsonElement? value)
        {
            if (string.IsNullOrWhiteSpace(Id))
                throw new ArgumentException($"'{nameof(Id)}' cannot be null or whitespace.", nameof(Id));

            Add(new CustomField() { Id = Id, Value = value });
        }
    }
}
