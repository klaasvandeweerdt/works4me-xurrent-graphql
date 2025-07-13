namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing webhook.
    /// </summary>
    internal sealed class WebhookUpdateMutation : Mutation<WebhookUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WebhookUpdateMutation(WebhookUpdateInput data, WebhookQuery query)
            : base("webhookUpdate", "WebhookUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "webhook")))
        {
        }
    }
}
