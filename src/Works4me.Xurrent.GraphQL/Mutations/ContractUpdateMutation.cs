namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing contract.
    /// </summary>
    internal sealed class ContractUpdateMutation : Mutation<ContractUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ContractUpdateMutation(ContractUpdateInput data, ContractQuery query)
            : base("contractUpdate", "ContractUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "contract")))
        {
        }
    }
}
