namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing waiting for customer follow-up.
    /// </summary>
    internal sealed class WaitingForCustomerFollowUpUpdateMutation : Mutation<WaitingForCustomerFollowUpUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the waiting for customer follow up mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WaitingForCustomerFollowUpUpdateMutation(WaitingForCustomerFollowUpUpdateInput data, WaitingForCustomerFollowUpQuery query)
            : base("waitingForCustomerFollowUpUpdate", "WaitingForCustomerFollowUpUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "waitingForCustomerFollowUp")))
        {
        }
    }
}
