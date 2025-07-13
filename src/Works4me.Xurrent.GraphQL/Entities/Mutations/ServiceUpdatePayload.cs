using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceupdatepayload/">ServiceUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ServiceUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("service", IsDefaultQueryProperty = true)]
        public Service? Service { get; internal set; }
    }
}
