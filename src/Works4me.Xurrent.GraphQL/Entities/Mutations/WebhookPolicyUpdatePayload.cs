using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookpolicyupdatepayload/">WebhookPolicyUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WebhookPolicyUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("webhookPolicy", IsDefaultQueryProperty = true)]
        public WebhookPolicy? WebhookPolicy { get; internal set; }
    }
}
