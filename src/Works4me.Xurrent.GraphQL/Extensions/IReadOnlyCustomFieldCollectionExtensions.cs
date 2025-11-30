using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text.Json;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for retrieving strongly typed values from an <see cref="IReadOnlyCustomFieldCollection"/>.
    /// </summary>
    public static class IReadOnlyCustomFieldCollectionExtensions
    {
        /// <summary>
        /// Attempts to retrieve the value of a custom field as a string.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the string value associated with <paramref name="key"/> if the key exists and its value is a JSON string; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON string; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out string value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.String, element => element.GetString()!, out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of strings.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the string array associated with <paramref name="key"/> if the key exists and its value is a JSON array of strings; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of strings; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out string[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.String, element => element.GetString()!, out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of strings.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of strings; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of strings; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<string> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.String, element => element.GetString()!, out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="short"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="short"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="short"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="short"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out short value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetInt16(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="short"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="short"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="short"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="short"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out short[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetInt16(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="short"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="short"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="short"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<short> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetInt16(), out value);
        }


        /// <summary>
        /// Attempts to retrieve the value of a custom field as an <see cref="int"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="int"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to an <see cref="int"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to an <see cref="int"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out int value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetInt32(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="int"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="int"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="int"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="int"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out int[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetInt32(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="int"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="int"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="int"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<int> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetInt32(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="long"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="long"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="long"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="long"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out long value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetInt64(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="long"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="long"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="long"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="long"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out long[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetInt64(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="long"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="long"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="long"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<long> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetInt64(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="ushort"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="ushort"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="ushort"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="ushort"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out ushort value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetUInt16(), out value);
        }


        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="ushort"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="ushort"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="ushort"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="ushort"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out ushort[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetUInt16(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="ushort"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="ushort"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="ushort"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<ushort> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetUInt16(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="uint"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="uint"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="uint"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="uint"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out uint value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetUInt32(), out value);
        }


        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="uint"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="uint"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="uint"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="uint"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out uint[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetUInt32(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="uint"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="uint"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="uint"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<uint> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetUInt32(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="ulong"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="ulong"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="ulong"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="ulong"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out ulong value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetUInt64(), out value);
        }


        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="ulong"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="ulong"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="ulong"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="ulong"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out ulong[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetUInt64(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="ulong"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="ulong"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="ulong"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<ulong> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetUInt64(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="float"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="float"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="float"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="float"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out float value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetSingle(), out value);
        }


        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="float"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="float"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="float"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="float"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out float[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetSingle(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="float"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="float"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="float"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<float> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetSingle(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="double"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="double"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="double"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="double"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out double value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetDouble(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="double"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="double"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="double"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="double"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out double[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetDouble(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="double"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="double"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="double"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<double> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetDouble(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="decimal"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="decimal"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON number that can be converted to a <see cref="decimal"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON number that can be converted to a <see cref="decimal"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out decimal value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.Number, element => element.GetDecimal(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="decimal"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="decimal"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="decimal"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="decimal"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out decimal[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.Number, element => element.GetDecimal(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="decimal"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="decimal"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="decimal"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<decimal> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.Number, element => element.GetDecimal(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="bool"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="bool"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON boolean; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON boolean (<c>true</c> or <c>false</c>); otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out bool value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.True, element => element.GetBoolean(), out value)
                || TryGetValueInternal(fields, key, JsonValueKind.False, element => element.GetBoolean(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="bool"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="bool"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array containing only boolean values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of boolean values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out bool[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.True, element => element.GetBoolean(), out value)
                || TryGetArrayInternal(fields, key, JsonValueKind.False, element => element.GetBoolean(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="bool"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="bool"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="bool"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<bool> value)
        {
            return TryGetCollectionInternal(fields, key, JsonValueKind.True, element => element.GetBoolean(), out value)
                || TryGetCollectionInternal(fields, key, JsonValueKind.False, element => element.GetBoolean(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="DateTime"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON string that can be parsed as a <see cref="DateTime"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON string that can be parsed as a <see cref="DateTime"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out DateTime value)
        {
            bool success = TryGetValueInternal(fields, key, JsonValueKind.String, ParseDateTimeFromJsonElement, out DateTime temp);
            value = success ? temp : default;
            return success;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="DateTime"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="DateTime"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of strings that can be parsed as <see cref="DateTime"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of strings that can be parsed as <see cref="DateTime"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out DateTime[] value)
        {
            bool success = TryGetArrayInternal(fields, key, JsonValueKind.String, ParseDateTimeFromJsonElement, out DateTime[]? temp);
            value = success && temp is not null ? temp : Array.Empty<DateTime>();
            return success;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="DateTime"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="DateTime"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="DateTime"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<DateTime> value)
        {
            bool success = TryGetCollectionInternal(fields, key, JsonValueKind.String, ParseDateTimeFromJsonElement, out Collection<DateTime> temp);
            value = success && temp is not null ? temp : new Collection<DateTime>();
            return success;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="DateTimeOffset"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON string that can be parsed as a <see cref="DateTimeOffset"/>; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON string that can be parsed as a <see cref="DateTimeOffset"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out DateTimeOffset value)
        {
            return TryGetValueInternal(fields, key, JsonValueKind.String, element => element.GetDateTimeOffset(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="DateTimeOffset"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="DateTimeOffset"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of strings that can be parsed as <see cref="DateTimeOffset"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of strings that can be parsed as <see cref="DateTimeOffset"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out DateTimeOffset[] value)
        {
            return TryGetArrayInternal(fields, key, JsonValueKind.String, element => element.GetDateTimeOffset(), out value);
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="DateTimeOffset"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="DateTimeOffset"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="DateTimeOffset"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<DateTimeOffset> value)
        {
            bool success = TryGetCollectionInternal(fields, key, JsonValueKind.String, element => element.GetDateTimeOffset(), out Collection<DateTimeOffset> temp);
            value = success && temp is not null ? temp : new Collection<DateTimeOffset>();
            return success;
        }

#if NET6_0_OR_GREATER

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="DateOnly"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="DateOnly"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON string that can be parsed as a <see cref="DateOnly"/>; otherwise, the default value.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON string that can be parsed as a <see cref="DateOnly"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out DateOnly value)
        {
            if (TryGetValue(fields, key, out DateTime dateTime))
            {
                value = DateOnly.FromDateTime(dateTime);
                return true;
            }

            value = default;
            return false;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="DateOnly"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="DateOnly"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of strings that can be parsed as <see cref="DateOnly"/> values; otherwise, an empty array.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of strings that can be parsed as <see cref="DateOnly"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out DateOnly[] value)
        {
            if (fields.TryGetValue(key, out Collection<DateOnly> values))
            {
                value = values.ToArray();
                return true;
            }

            value = Array.Empty<DateOnly>();
            return true;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="DateOnly"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="DateOnly"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="DateOnly"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<DateOnly> value)
        {
            if (!TryGetValue(fields, key, out DateTime[] dateTimes))
            {
                value = new Collection<DateOnly>();
                return false;
            }

            int length = dateTimes.Length;
            Collection<DateOnly> result = new();

            for (int i = 0; i < length; i++)
                result.Add(DateOnly.FromDateTime(dateTimes[i]));

            value = result;
            return true;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a <see cref="TimeOnly"/>.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the <see cref="TimeOnly"/> value associated with <paramref name="key"/> if the key exists and its value is a JSON string that can be parsed as a time or date/time; otherwise, the default value.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON string that can be parsed as a time or date/time;otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out TimeOnly value)
        {
            if (TryGetValue(fields, key, out DateTime dateTime))
            {
                value = TimeOnly.FromDateTime(dateTime);
                return true;
            }

            value = default;
            return false;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as an array of <see cref="TimeOnly"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains the array of <see cref="TimeOnly"/> values associated with <paramref name="key"/> if the key exists and its value is a JSON array of strings that can be parsed as times or date/times; otherwise, an empty array.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of strings that can be parsed as times or date/times; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out TimeOnly[] value)
        {
            if (fields.TryGetValue(key, out Collection<TimeOnly> values))
            {
                value = values.ToArray();
                return true;
            }

            value = Array.Empty<TimeOnly>();
            return true;
        }

        /// <summary>
        /// Attempts to retrieve the value of a custom field as a collection of <see cref="TimeOnly"/> values.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the custom field to retrieve.</param>
        /// <param name="value">When this method returns, contains a <see cref="Collection{T}"/> with the values associated with <paramref name="key"/> if the key exists and its value is a JSON array of numbers that can be converted to <see cref="TimeOnly"/> values; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists and its value is a JSON array of numbers that can be converted to <see cref="TimeOnly"/> values; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        public static bool TryGetValue(this IReadOnlyCustomFieldCollection fields, string key, out Collection<TimeOnly> value)
        {
            if (!TryGetValue(fields, key, out DateTime[] dateTimes))
            {
                value = new Collection<TimeOnly>();
                return false;
            }

            int length = dateTimes.Length;
            Collection<TimeOnly> result = new();

            for (int i = 0; i < length; i++)
                result.Add(TimeOnly.FromDateTime(dateTimes[i]));

            value = result;
            return true;
        }

#endif


        /// <summary>
        /// Attempts to retrieve a single JSON value, convert it to the specified type, and return it.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the field to retrieve.</param>
        /// <param name="expectedKind">The expected <see cref="JsonValueKind"/> of the JSON value.</param>
        /// <param name="getter">A conversion function that extracts the target type from the <see cref="JsonElement"/>.</param>
        /// <param name="value">When this method returns, contains the converted value if successful; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists, has the expected JSON type, and conversion succeeds; otherwise, <c>false</c>.</returns>
        private static bool TryGetValueInternal<T>(IReadOnlyCustomFieldCollection fields, string key, JsonValueKind expectedKind, Func<JsonElement, T> getter, out T value)
        {
            JsonElement? element = GetJsonElement(fields, key);

            if (element is null || element.Value.ValueKind != expectedKind)
            {
                value = default!;
                return false;
            }

            try
            {
                value = getter(element.Value);
                return true;
            }
            catch (InvalidOperationException)
            {
                value = default!;
                return false;
            }
            catch (FormatException)
            {
                value = default!;
                return false;
            }
            catch (OverflowException)
            {
                value = default!;
                return false;
            }
        }

        /// <summary>
        /// Attempts to retrieve a JSON array, convert each element to the specified type, and return the resulting collection.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the field to retrieve.</param>
        /// <param name="elementKind">The expected <see cref="JsonValueKind"/> of each array element.</param>
        /// <param name="getter">A conversion function that extracts the target type from each <see cref="JsonElement"/>.</param>
        /// <param name="value">When this method returns, contains the converted array if successful; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists, is a JSON array, its elements have the expected JSON type, and all conversions succeed; otherwise, <c>false</c>.</returns>
        private static bool TryGetCollectionInternal<T>(IReadOnlyCustomFieldCollection fields, string key, JsonValueKind elementKind, Func<JsonElement, T> getter, out Collection<T> value)
        {
            JsonElement? element = GetJsonElement(fields, key);

            if (element is null || element.Value.ValueKind != JsonValueKind.Array)
            {
                value = new Collection<T>();
                return false;
            }

            Collection<T> items = new();
            JsonElement.ArrayEnumerator enumerator = element.Value.EnumerateArray();

            try
            {
                foreach (JsonElement item in enumerator)
                {
                    if (item.ValueKind != elementKind)
                    {
                        value = new Collection<T>();
                        return false;
                    }

                    T convertedItem = getter(item);
                    items.Add(convertedItem);
                }
            }
            catch (InvalidOperationException)
            {
                value = new Collection<T>();
                return false;
            }
            catch (FormatException)
            {
                value = new Collection<T>();
                return false;
            }
            catch (OverflowException)
            {
                value = new Collection<T>();
                return false;
            }

            value = items;
            return true;
        }

        /// <summary>
        /// Attempts to retrieve a JSON array, convert each element to the specified type, and return the resulting array.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the field to retrieve.</param>
        /// <param name="elementKind">The expected <see cref="JsonValueKind"/> of each array element.</param>
        /// <param name="getter">A conversion function that extracts the target type from each <see cref="JsonElement"/>.</param>
        /// <param name="value">When this method returns, contains the converted array if successful; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the field exists, is a JSON array, its elements have the expected JSON type, and all conversions succeed; otherwise, <c>false</c>.</returns>
        private static bool TryGetArrayInternal<T>(IReadOnlyCustomFieldCollection fields, string key, JsonValueKind elementKind, Func<JsonElement, T> getter, out T[] value)
        {
            if (TryGetCollectionInternal(fields, key, elementKind, getter, out Collection<T> temp))
            {
                value = temp.ToArray();
                return true;
            }

            value = Array.Empty<T>();
            return false;
        }

        /// <summary>
        /// Retrieves the raw <see cref="JsonElement"/> for the specified field key, or <c>null</c> if the key does not exist.
        /// </summary>
        /// <param name="fields">The <see cref="IReadOnlyCustomFieldCollection"/> containing the custom fields.</param>
        /// <param name="key">The key of the field to retrieve.</param>
        /// <returns>The <see cref="JsonElement"/> associated with <paramref name="key"/> if it exists; otherwise, <c>null</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fields"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="key"/> is <c>null</c> or empty.</exception>
        private static JsonElement? GetJsonElement(this IReadOnlyCustomFieldCollection fields, string key)
        {
            if (fields is null)
                throw new ArgumentNullException(nameof(fields));
            
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException($"'{nameof(key)}' cannot be null or empty.", nameof(key));
            
            if (!fields.Contains(key))
                return null;
           
            return fields[key];
        }

        /// <summary>
        /// Parses a <see cref="JsonElement"/> containing a JSON string into a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="element">The <see cref="JsonElement"/> whose string value should be parsed.</param>
        /// <returns>The parsed <see cref="DateTime"/> value.</returns>
        /// <exception cref="FormatException">Thrown when the JSON string cannot be parsed as a valid date, time, or date/time value.</exception>
        private static DateTime ParseDateTimeFromJsonElement(JsonElement element)
        {
            string? text = element.GetString();

            if (!TryParseDateTime(text, out DateTime result))
            {
                throw new FormatException($"Value '{text}' cannot be parsed as DateTime.");
            }

            return result;
        }

        /// <summary>
        /// Attempts to parse a string as a <see cref="DateTime"/> using multiple supported formats.
        /// </summary>
        /// <param name="text">The input string containing a date, time, or date/time value.</param>
        /// <param name="value">hen this method returns, contains the parsed <see cref="DateTime"/> value if parsing succeeds; otherwise, the default value.</param>
        /// <returns><c>true</c> if the input string could be parsed as a <see cref="DateTime"/>; otherwise, <c>false</c>.</returns>
        private static bool TryParseDateTime(string? text, out DateTime value)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                value = default;
                return false;
            }

            if (DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out value))
                return true;

            if (DateTime.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out value))
                return true;

            if (DateTime.TryParseExact(text, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out value))
                return true;

            value = default;
            return false;
        }
    }
}
