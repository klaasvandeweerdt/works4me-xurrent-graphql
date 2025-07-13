using System;
using System.Globalization;
using System.Text.Json;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    public static partial class JsonElementExtensions
    {
        /// <summary>
        /// Gets the value of the specified type from a JsonElement, supporting nulls and nullable value types.
        /// </summary>
        public static T? GetValue<T>(this JsonElement? element)
        {
            if (element is null || element.Value.ValueKind == JsonValueKind.Null || element.Value.ValueKind == JsonValueKind.Undefined)
                return default;

            Type type = typeof(T);
            Type? underlying = Nullable.GetUnderlyingType(type);

            if (underlying is not null)
                return (T?)element.Value.GetValue(underlying);

            return (T?)element.Value.GetValue(type);
        }

        /// <summary>
        /// Gets the value of the specified <paramref name="type"/> from a <see cref="JsonElement"/>.<br />
        /// Handles common primitive types, strings, arrays, objects, and certain date/time types.<br />
        /// Returns <c>null</c> if the JSON value is null or undefined.<br />
        /// </summary>
        /// <param name="element">The <see cref="JsonElement"/> to extract the value from.</param>
        /// <param name="type">The target <see cref="Type"/> to convert to.</param>
        /// <returns>An object of the specified <paramref name="type"/>, or <c>null</c> if the JSON value is null or undefined.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the specified <paramref name="type"/> is not supported.</exception>
        private static object? GetValue(this JsonElement element, Type type)
        {
            if (element.ValueKind == JsonValueKind.Null || element.ValueKind == JsonValueKind.Undefined)
                return null;

            if (type == typeof(string))
                return element.GetString();
            if (type == typeof(int))
                return element.GetInt32();
            if (type == typeof(long))
                return element.GetInt64();
            if (type == typeof(short))
                return element.GetInt16();
            if (type == typeof(byte))
                return element.GetByte();
            if (type == typeof(bool))
                return element.GetBoolean();
            if (type == typeof(double))
                return element.GetDouble();
            if (type == typeof(float))
                return element.GetSingle();
            if (type == typeof(decimal))
                return element.GetDecimal();
            if (type == typeof(DateTime))
                return DateTime.Parse(element.GetString()!, CultureInfo.InvariantCulture);
            if (type == typeof(DateTimeOffset))
                return DateTimeOffset.Parse(element.GetString()!, CultureInfo.InvariantCulture);
#if NET6_0_OR_GREATER
            if (type == typeof(DateOnly))
                return DateOnly.Parse(element.GetString()!, CultureInfo.InvariantCulture);
            if (type == typeof(TimeOnly))
                return TimeOnly.Parse(element.GetString()!, CultureInfo.InvariantCulture);
#endif
            if (type.IsArray || (!type.IsPrimitive && !type.IsEnum && type != typeof(string)))
                return JsonSerializer.Deserialize(element.GetRawText(), type);

            throw new InvalidOperationException($"GetValue<{type.Name}> is not supported for this JsonElement.");
        }
    }
}
