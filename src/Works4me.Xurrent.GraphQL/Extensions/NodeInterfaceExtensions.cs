using System;
using System.Text;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for decoding and parsing GraphQL node identifiers used in the Xurrent platform.
    /// </summary>
    public static class NodeInterfaceExtensions
    {
        /// <summary>
        /// Extracts the Xurrent instance from a GraphQL node's encoded ID.
        /// </summary>
        /// <param name="node">The node whose ID will be decoded.</param>
        /// <returns>The instance as a string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="node"/> is <c>null</c>.</exception>
        /// <exception cref="XurrentException">Thrown when the ID cannot be decoded or has an unexpected format.</exception>
        internal static string GetInstance(this INode node)
        {
            if (node is null)
                throw new ArgumentNullException(nameof(node));

            string[] data = FromBase64(node.Id);
            return data[0];
        }

        /// <summary>
        /// Extracts the object type from a GraphQL node's encoded ID.
        /// </summary>
        /// <param name="node">The node whose ID will be decoded.</param>
        /// <returns>The type of the object as a string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="node"/> is <c>null</c>.</exception>
        /// <exception cref="XurrentException">Thrown when the ID cannot be decoded or has an unexpected format.</exception>
        internal static string GetObjectType(this INode node)
        {
            if (node is null)
                throw new ArgumentNullException(nameof(node));

            string[] data = FromBase64(node.Id);
            return data[1];
        }

        /// <summary>
        /// Extracts the REST API numerical identifier portion from a GraphQL node's encoded ID.
        /// </summary>
        /// <param name="node">The node whose ID will be decoded.</param>
        /// <returns>The REST API numerical identifier as a <see cref="long"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="node"/> is <c>null</c>.</exception>
        /// <exception cref="XurrentException">Thrown when the ID cannot be decoded or has an unexpected format.</exception>
        public static long GetIdentifier(this INode node)
        {
            if (node is null)
                throw new ArgumentNullException(nameof(node));

            string[] data = FromBase64(node.Id);
            if (long.TryParse(data[2], out long result))
                return result;
            return 0;
        }

        private static string[] FromBase64(string identifier)
        {
            if (string.IsNullOrWhiteSpace(identifier))
                throw new XurrentException("Unsupported GraphQL identifier value.");

            string[] retval = (identifier.Length % 4) switch
            {
                0 => Encoding.UTF8.GetString(Convert.FromBase64String(identifier)).Split('/'),
                2 => Encoding.UTF8.GetString(Convert.FromBase64String(identifier + "==")).Split('/'),
                3 => Encoding.UTF8.GetString(Convert.FromBase64String(identifier + "=")).Split('/'),
                _ => throw new XurrentException("Unsupported GraphQL identifier value.")
            };

            if (retval.Length != 3)
                throw new XurrentException("Unsupported GraphQL identifier value.");

            return retval;
        }
    }
}
