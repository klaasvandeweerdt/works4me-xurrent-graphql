using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookpolicydeletemutationpayload/">WebhookPolicyDeleteMutationPayload</see> in Xurrent.
    /// </summary>
    public sealed class WebhookPolicyDeleteMutationPayload : MutationResultBase
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [XurrentField("success", IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
