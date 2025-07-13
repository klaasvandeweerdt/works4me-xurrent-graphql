#if NETFRAMEWORK || NETSTANDARD2_0
using System;
using System.Collections.Generic;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="IDictionary{TKey, TValue}"/>.
    /// </summary>
    internal static class DictionaryExtensions
    {
        /// <summary>
        /// Tries to add the specified key and value to the dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">A dictionary with keys of type TKey and values of type TValue.</param>
        /// <param name="key">The key of the value to add.</param>
        /// <param name="value">The value to add.</param>
        /// <returns>True when the key and value are successfully added to the dictionary; false when the dictionary already contains the specified key, in which case nothing gets added.</returns>
        internal static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
            where TKey : notnull
        {
            if (dictionary is null)
                throw new ArgumentNullException(nameof(dictionary));

            if (dictionary.ContainsKey(key))
                return false;

            dictionary.Add(key, value);
            return true;
        }
    }
}
#endif
