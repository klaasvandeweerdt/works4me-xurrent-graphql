using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerfollowupcreatepayload/">WaitingForCustomerFollowUpCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WaitingForCustomerFollowUpCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("waitingForCustomerFollowUp", IsDefaultQueryProperty = true)]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }
    }
}
