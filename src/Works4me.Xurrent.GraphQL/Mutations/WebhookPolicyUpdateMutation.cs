namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing webhook policy.
    /// </summary>
    internal sealed class WebhookPolicyUpdateMutation : Mutation<WebhookPolicyUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the webhook policy mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WebhookPolicyUpdateMutation(WebhookPolicyUpdateInput data, WebhookPolicyQuery query)
            : base("webhookPolicyUpdate", "WebhookPolicyUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "webhookPolicy")))
        {
        }
    }
}
