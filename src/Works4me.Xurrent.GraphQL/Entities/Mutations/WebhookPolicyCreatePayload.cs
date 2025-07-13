using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookpolicycreatepayload/">WebhookPolicyCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WebhookPolicyCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("webhookPolicy", IsDefaultQueryProperty = true)]
        public WebhookPolicyCreateResponse? WebhookPolicy { get; internal set; }
    }
}
