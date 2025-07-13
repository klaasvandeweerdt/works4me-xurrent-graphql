using System.Collections.Generic;
using System.Collections.Immutable;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Tracks the names of properties that have been modified and provides access to the change set.
    /// </summary>
    public class PropertyChangeSet
    {
        private readonly HashSet<string> _fieldNames = new();

        /// <summary>
        /// Records that the specified field has been changed.
        /// </summary>
        /// <typeparam name="T">The type of the value being set.</typeparam>
        /// <param name="fieldName">The name of the field to mark as changed.</param>
        /// <param name="value">The value to assign to the field.</param>
        /// <returns>The <paramref name="value"/> parameter.</returns>
        internal protected T Set<T>(string fieldName, T value)
        {
            _fieldNames.Add(fieldName);
            return value;
        }

        /// <summary>
        /// Gets the set of field names that have been recorded as changed.
        /// </summary>
        /// <returns>An <see cref="ImmutableHashSet{String}"/> containing the names of changed fields.</returns>
        public ImmutableHashSet<string> GetFields()
        {
            return _fieldNames.ToImmutableHashSet();
        }
    }
}
