namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Deletes a webhook.
    /// </summary>
    internal sealed class WebhookDeleteMutation : Mutation<WebhookDeleteMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeleteMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal WebhookDeleteMutation(WebhookDeleteMutationInput data)
            : base("webhookDelete", "WebhookDeleteMutationInput!", data, new MutationResponseQuery().SelectAll())
        {
        }
    }
}
