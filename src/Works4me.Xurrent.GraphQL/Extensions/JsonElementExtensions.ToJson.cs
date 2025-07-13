using System;
using System.Globalization;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Utilities;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    public static partial class JsonElementExtensions
    {
        /// <summary>
        /// Converts an <see cref="int"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this int value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="long"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this long value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="short"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this short value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="sbyte"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this sbyte value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="uint"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this uint value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="ulong"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this ulong value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="ushort"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this ushort value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="byte"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this byte value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="float"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this float value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="double"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this double value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="decimal"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this decimal value)
        {
            return JsonDocument.Parse(value.ToString(CultureInfo.InvariantCulture)).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="bool"/> value to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement(this bool value)
        {
            return JsonDocument.Parse(value ? "true" : "false").RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="char"/> value to a <see cref="JsonElement"/>.
        /// Serialized as a JSON string.
        /// </summary>
        public static JsonElement ToJsonElement(this char value)
        {
            string json = JsonSerializer.Serialize(value.ToString());
            return JsonDocument.Parse(json).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="string"/> value to a <see cref="JsonElement"/>.
        /// Serialized as a JSON string.
        /// </summary>
        public static JsonElement ToJsonElement(this string value)
        {
            string json = JsonSerializer.Serialize(value);
            return JsonDocument.Parse(json).RootElement.Clone();
        }

        /// <summary>
        /// Converts an array to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement<T>(this T[] value)
        {
            string json = JsonSerializer.Serialize(value);
            return JsonDocument.Parse(json).RootElement.Clone();
        }

        /// <summary>
        /// Converts an object to a <see cref="JsonElement"/>.
        /// </summary>
        public static JsonElement ToJsonElement<T>(this T value)
        {
            string json = JsonSerializer.Serialize(value);
            return JsonDocument.Parse(json).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> value to a <see cref="JsonElement"/> using the format yyyy-MM-dd'T'HH:mm:sszzz.
        /// </summary>
        public static JsonElement ToJsonElement(this DateTime value)
        {
            string json = JsonSerializer.Serialize(value.ToString(Constants.DateTimeFormat, CultureInfo.InvariantCulture));
            return JsonDocument.Parse(json).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> value to a <see cref="JsonElement"/> using the format yyyy-MM-dd'T'HH:mm:sszzz.
        /// </summary>
        public static JsonElement ToJsonElement(this DateTimeOffset value)
        {
            string json = JsonSerializer.Serialize(value.ToString(Constants.DateTimeFormat, CultureInfo.InvariantCulture));
            return JsonDocument.Parse(json).RootElement.Clone();
        }

#if NET6_0_OR_GREATER
        /// <summary>
        /// Converts a <see cref="DateOnly"/> value to a <see cref="JsonElement"/> using the format yyyy-MM-dd.
        /// </summary>
        public static JsonElement ToJsonElement(this DateOnly value)
        {
            string json = JsonSerializer.Serialize(value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            return JsonDocument.Parse(json).RootElement.Clone();
        }

        /// <summary>
        /// Converts a <see cref="TimeOnly"/> value to a <see cref="JsonElement"/> using the format HH:mm:ss.
        /// </summary>
        public static JsonElement ToJsonElement(this TimeOnly value)
        {
            string json = JsonSerializer.Serialize(value.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
            return JsonDocument.Parse(json).RootElement.Clone();
        }
#endif
    }
}
