using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/customcollectionelementupdatepayload/">CustomCollectionElementUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class CustomCollectionElementUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("customCollectionElement", IsDefaultQueryProperty = true)]
        public CustomCollectionElement? CustomCollectionElement { get; internal set; }
    }
}
