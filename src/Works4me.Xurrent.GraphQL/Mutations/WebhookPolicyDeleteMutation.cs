namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Deletes a webhook policy.
    /// </summary>
    internal sealed class WebhookPolicyDeleteMutation : Mutation<WebhookPolicyDeleteMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPolicyDeleteMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal WebhookPolicyDeleteMutation(WebhookPolicyDeleteMutationInput data)
            : base("webhookPolicyDelete", "WebhookPolicyDeleteMutationInput!", data, new MutationResponseQuery().SelectAll())
        {
        }
    }
}
