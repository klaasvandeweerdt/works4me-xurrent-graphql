using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/goldensetitemupdatepayload/">GoldenSetItemUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class GoldenSetItemUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("goldenSetItem", IsDefaultQueryProperty = true)]
        public GoldenSetItem? GoldenSetItem { get; internal set; }
    }
}
