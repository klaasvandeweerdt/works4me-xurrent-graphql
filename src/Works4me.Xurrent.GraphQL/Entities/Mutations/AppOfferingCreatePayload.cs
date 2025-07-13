using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingcreatepayload/">AppOfferingCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class AppOfferingCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("appOffering", IsDefaultQueryProperty = true)]
        public AppOffering? AppOffering { get; internal set; }
    }
}
