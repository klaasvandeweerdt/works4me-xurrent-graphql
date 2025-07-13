namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Specifies the value type to use for filtering in a GraphQL query.
    /// </summary>
    internal enum FilterValueType
    {
        /// <summary>
        /// The filter value is treated as a string.
        /// </summary>
        String,

        /// <summary>
        /// The filter value is treated as a boolean.
        /// </summary>
        Boolean,

        /// <summary>
        /// The filter value is treated as an integer.
        /// </summary>
        Integer,

        /// <summary>
        /// The filter value is treated as a date/time value.
        /// </summary>
        DateTime,

        /// <summary>
        /// The filter value is treated as a custom type.
        /// </summary>
        Custom,

        /// <summary>
        /// The filter value is treated as a full-text or query-based value.
        /// </summary>
        Query
    }
}
