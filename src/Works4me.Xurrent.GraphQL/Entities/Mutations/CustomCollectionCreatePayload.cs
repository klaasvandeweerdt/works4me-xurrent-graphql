using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/customcollectioncreatepayload/">CustomCollectionCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class CustomCollectionCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("customCollection", IsDefaultQueryProperty = true)]
        public CustomCollection? CustomCollection { get; internal set; }
    }
}
