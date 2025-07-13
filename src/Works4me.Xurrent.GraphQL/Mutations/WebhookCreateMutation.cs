namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new webhook.
    /// </summary>
    internal sealed class WebhookCreateMutation : Mutation<WebhookCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the webhook mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WebhookCreateMutation(WebhookCreateInput data, WebhookQuery query)
            : base("webhookCreate", "WebhookCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "webhook")))
        {
        }
    }
}
