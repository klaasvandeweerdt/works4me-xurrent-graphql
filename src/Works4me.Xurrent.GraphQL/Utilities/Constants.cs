namespace Works4me.Xurrent.GraphQL.Utilities
{
    /// <summary>
    /// Provides commonly used constant values throughout the application.
    /// </summary>
    internal static class Constants
    {
        /// <summary>
        /// The HTTP header key for the Xurrent account identifier.
        /// </summary>
        public const string AccountHeader = "x-xurrent-account";

        /// <summary>
        /// The media type for JSON content in HTTP requests and responses.
        /// </summary>
        public const string ApplicationJsonMediaType = "application/json";

        /// <summary>
        /// The standard date and time format used for serializing and parsing date-time values.
        /// </summary>
        public const string DateTimeFormat = "yyyy-MM-dd'T'HH:mm:sszzz";
    }
}
