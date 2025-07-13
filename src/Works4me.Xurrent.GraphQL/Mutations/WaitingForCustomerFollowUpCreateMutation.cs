namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new waiting for customer follow-up.
    /// </summary>
    internal sealed class WaitingForCustomerFollowUpCreateMutation : Mutation<WaitingForCustomerFollowUpCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WaitingForCustomerFollowUpCreateMutation(WaitingForCustomerFollowUpCreateInput data, WaitingForCustomerFollowUpQuery query)
            : base("waitingForCustomerFollowUpCreate", "WaitingForCustomerFollowUpCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "waitingForCustomerFollowUp")))
        {
        }
    }
}
