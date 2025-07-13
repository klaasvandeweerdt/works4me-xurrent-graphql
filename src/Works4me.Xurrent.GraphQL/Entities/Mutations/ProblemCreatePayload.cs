using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/problemcreatepayload/">ProblemCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProblemCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("problem", IsDefaultQueryProperty = true)]
        public Problem? Problem { get; internal set; }
    }
}
