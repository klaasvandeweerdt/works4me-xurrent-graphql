using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requesttemplateupdatepayload/">RequestTemplateUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class RequestTemplateUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("requestTemplate", IsDefaultQueryProperty = true)]
        public RequestTemplate? RequestTemplate { get; internal set; }
    }
}
