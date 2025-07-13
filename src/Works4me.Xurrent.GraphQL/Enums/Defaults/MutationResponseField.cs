using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Specifies the available fields in a GraphQL mutation response.
    /// </summary>
    internal enum MutationResponseField
    {
        /// <summary>
        /// The client mutation ID used to correlate requests and responses.
        /// </summary>
        [XurrentEnum("clientMutationId")]
        ClientMutationId,

        /// <summary>
        /// Indicates whether the mutation was successful.
        /// </summary>
        [XurrentEnum("success")]
        Success,

        /// <summary>
        /// The list of error messages returned by the mutation, if any.
        /// </summary>
        [XurrentEnum("errors")]
        Errors
    }
}
