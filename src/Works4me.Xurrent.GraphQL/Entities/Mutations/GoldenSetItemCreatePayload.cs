using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/goldensetitemcreatepayload/">GoldenSetItemCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class GoldenSetItemCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("goldenSetItem")]
        public GoldenSetItem? GoldenSetItem { get; internal set; }
    }
}
