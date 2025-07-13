namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new contract.
    /// </summary>
    internal sealed class ContractCreateMutation : Mutation<ContractCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the contract mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ContractCreateMutation(ContractCreateInput data, ContractQuery query)
            : base("contractCreate", "ContractCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "contract")))
        {
        }
    }
}
