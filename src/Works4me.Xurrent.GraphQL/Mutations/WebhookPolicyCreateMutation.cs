namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new webhook policy.
    /// </summary>
    internal sealed class WebhookPolicyCreateMutation : Mutation<WebhookPolicyCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WebhookPolicyCreateMutation(WebhookPolicyCreateInput data, WebhookPolicyCreateResponseQuery query)
            : base("webhookPolicyCreate", "WebhookPolicyCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "webhookPolicy")))
        {
        }
    }
}
