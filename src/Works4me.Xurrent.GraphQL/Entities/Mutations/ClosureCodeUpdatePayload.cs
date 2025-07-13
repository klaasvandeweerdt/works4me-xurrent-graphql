using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/closurecodeupdatepayload/">ClosureCodeUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ClosureCodeUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("closureCode", IsDefaultQueryProperty = true)]
        public ClosureCode? ClosureCode { get; internal set; }
    }
}
