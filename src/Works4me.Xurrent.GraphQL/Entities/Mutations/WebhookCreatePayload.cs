using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookcreatepayload/">WebhookCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WebhookCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("webhook", IsDefaultQueryProperty = true)]
        public Webhook? Webhook { get; internal set; }
    }
}
