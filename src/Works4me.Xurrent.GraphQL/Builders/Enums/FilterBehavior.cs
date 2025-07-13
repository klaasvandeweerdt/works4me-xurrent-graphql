namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Specifies the filter behavior to apply when using a field or enum in a GraphQL query.
    /// </summary>
    internal enum FilterBehavior
    {
        /// <summary>
        /// No special filter behavior is applied.
        /// </summary>
        None,

        /// <summary>
        /// Applies simple filter behavior.
        /// </summary>
        Simple,

        /// <summary>
        /// Applies the default filter behavior.
        /// </summary>
        Default
    }
}
