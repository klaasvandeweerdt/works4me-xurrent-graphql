using System.Collections.Generic;
using System.Text.Json;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="JsonDocument"/>.
    /// </summary>
    internal static class JsonDocumentExtensions
    {
        /// <summary>
        /// Throws an <see cref="XurrentExecutionException"/> if the <see cref="JsonDocument"/> contains GraphQL errors.
        /// </summary>
        /// <param name="document">The <see cref="JsonDocument"/> to inspect for GraphQL errors.</param>
        /// <exception cref="XurrentExecutionException">Thrown if a non-empty GraphQL <c>"errors"</c> array is present in the document.</exception>
        public static void ThrowIfGraphQLError(this JsonDocument document)
        {
            document.RootElement.ThrowIfGraphQLError();
        }

        /// <summary>
        /// Attempts to retrieve a nested <see cref="JsonElement"/> from the root of the <see cref="JsonDocument"/> specified by a sequence of property names.
        /// </summary>
        /// <param name="document">The <see cref="JsonDocument"/> to search from its root element.</param>
        /// <param name="names">An ordered sequence of property names that defines the path to the desired element.</param>
        /// <param name="jsonElement">When this method returns, contains the <see cref="JsonElement"/> found at the specified path, or the default value if the path could not be fully traversed.</param>
        /// <returns><c>true</c> if the full path exists and the value was retrieved successfully; otherwise, <c>false</c>.</returns>
        public static bool TryGetElementByPath(this JsonDocument document, IEnumerable<string> names, out JsonElement jsonElement)
        {
            return document.RootElement.TryGetElementByPath(names, out jsonElement);
        }
    }
}
