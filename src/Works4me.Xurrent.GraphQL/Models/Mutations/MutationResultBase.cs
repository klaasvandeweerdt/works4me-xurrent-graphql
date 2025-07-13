using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Base class for GraphQL mutation responses, providing common fields such as client mutation ID and errors.
    /// </summary>
    public class MutationResultBase
    {
        /// <summary>
        /// Gets the client mutation ID used to correlate mutation requests and responses.
        /// </summary>
        [XurrentField("clientMutationId", IsDefaultQueryProperty = true)]
        public string? ClientMutationId { get; internal set; }

        /// <summary>
        /// Gets the list of error messages returned by the mutation, if any.
        /// </summary>
        [XurrentField("errors", IsDefaultQueryProperty = true)]
        internal IReadOnlyList<ValidationError>? Errors { get; set; }
    }
}
