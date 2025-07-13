using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requestupdatepayload/">RequestUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class RequestUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("request", IsDefaultQueryProperty = true)]
        public Request? Request { get; internal set; }
    }
}
