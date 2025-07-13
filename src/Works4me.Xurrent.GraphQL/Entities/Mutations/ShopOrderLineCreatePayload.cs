using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoporderlinecreatepayload/">ShopOrderLineCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ShopOrderLineCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("shopOrderLine", IsDefaultQueryProperty = true)]
        public ShopOrderLine? ShopOrderLine { get; internal set; }
    }
}
