using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Specifies the available fields in a GraphQL mutation response.
    /// </summary>
    internal enum MutationResponseField
    {
        /// <summary>
        /// Indicates that all scalar fields in the mutation response should be selected.
        /// </summary>
        [XurrentEnum(null)]
        All
    }
}
