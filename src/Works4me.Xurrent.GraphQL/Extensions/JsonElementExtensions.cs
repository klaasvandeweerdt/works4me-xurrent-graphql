using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides a comprehensive set of extension methods for working with <see cref="System.Text.Json.JsonElement"/> instances, making it easy to extract strongly-typed values, convert primitives and common .NET types to <see cref="JsonElement"/>, and handle common GraphQL response patterns (such as error extraction and navigation by property path).
    /// <para>These extensions are especially useful when dealing with GraphQL APIs that use custom scalars (such as <c>JSON</c>),or when flexible, strongly-typed access to JSON payloads is required.</para>
    ///
    /// <para>
    /// Core capabilities include: <br />
    /// • Type-safe extraction of values (including null/nullable support) using <c>GetValue&lt;T&gt;()</c>. <br />
    /// • Converting .NET primitive, enum, date/time, string, array, and object values to <see cref="JsonElement"/> using <c>ToJsonElement()</c> overloads. <br />
    /// • Convenient navigation of JSON property paths via <c>TryGetElementByPath()</c>. <br />
    /// • GraphQL-specific helpers for error detection and extraction of error messages and paths.
    /// </para>
    /// </summary>
    public static partial class JsonElementExtensions
    {
        /// <summary>
        /// If the element contains a non-empty GraphQL <c>"errors"</c> array, throws an <see cref="XurrentExecutionException"/> initialized from its first entry.
        /// </summary>
        /// <param name="element">The <see cref="JsonElement"/> to inspect for GraphQL errors.</param>
        /// <exception cref="XurrentExecutionException">Thrown if a non-empty GraphQL <c>"errors"</c> array is present in the element.</exception>
        internal static void ThrowIfGraphQLError(this JsonElement element)
        {
            if (element.TryGetProperty("errors", out JsonElement errors) && errors.ValueKind == JsonValueKind.Array && errors.GetArrayLength() > 0)
            {
                JsonElement firstError = errors.EnumerateArray().First();
                string message = firstError.GetGraphQLErrorMessage();
                Collection<string> pathList = firstError.GetGraphQLErrorPath();

                throw new XurrentExecutionException(message, pathList);
            }
        }

        /// <summary>
        /// Extracts the <c>"message"</c> field (with a safe fallback) from a single GraphQL error element.
        /// </summary>
        /// <param name="element">A <see cref="JsonElement"/> representing a single GraphQL error object.</param>
        /// <returns>The string value of the <c>"message"</c> property, or a generic fallback message if not present.</returns>
        internal static string GetGraphQLErrorMessage(this JsonElement element)
        {
            if (element.TryGetProperty("message", out JsonElement msg) && msg.ValueKind == JsonValueKind.String && msg.GetString() is string value)
                return value;

            return "A GraphQL error occurred.";
        }

        /// <summary>
        /// Extracts the <c>"path"</c> array of strings (or returns an empty list) from a single GraphQL error element.
        /// </summary>
        /// <param name="element">A <see cref="JsonElement"/> representing a single GraphQL error object.</param>
        /// <returns>A list of strings representing the <c>"path"</c> property, or an empty list if not present or not an array.</returns>
        internal static Collection<string> GetGraphQLErrorPath(this JsonElement element)
        {
            Collection<string> pathList = new();

            if (element.TryGetProperty("path", out JsonElement path) && path.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement item in path.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.String && item.GetString() is string s)
                        pathList.Add(s);
                }
            }

            return pathList;
        }

        /// <summary>
        /// Attempts to retrieve a nested <see cref="JsonElement"/> specified by a sequence of property names.
        /// </summary>
        /// <param name="element">The root <see cref="JsonElement"/> to search from.</param>
        /// <param name="names">An ordered sequence of property names that defines the path to the desired element.</param>
        /// <param name="jsonElement">When this method returns, contains the <see cref="JsonElement"/> found at the specified path, or the default value if the path could not be fully traversed.</param>
        /// <returns><c>true</c> if the full path exists and the value was retrieved successfully; otherwise, <c>false</c>.</returns>
        internal static bool TryGetElementByPath(this JsonElement element, IEnumerable<string> names, out JsonElement jsonElement)
        {
            if (names is null)
                throw new ArgumentNullException(nameof(names));

            List<string> nameList = names.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            if (nameList.Count == 0)
            {
                jsonElement = default;
                return false;
            }

            JsonElement currentElement = element;
            for (int i = 0; i < nameList.Count; i++)
            {
                string name = nameList[i];

                if (currentElement.ValueKind == JsonValueKind.Object)
                {
                    if (currentElement.TryGetProperty(name, out JsonElement nextElement))
                    {
                        currentElement = nextElement;
                    }
                    else
                    {
                        jsonElement = default;
                        return false;
                    }
                }
                else
                {
                    if (i == nameList.Count - 1)
                    {
                        jsonElement = currentElement;
                        return true;
                    }

                    jsonElement = default;
                    return false;
                }
            }

            jsonElement = currentElement;
            return true;
        }

    }
}
