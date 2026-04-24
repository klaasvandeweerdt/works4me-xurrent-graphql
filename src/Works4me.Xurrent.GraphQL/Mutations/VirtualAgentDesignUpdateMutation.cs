namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing virtual agent design.
    /// </summary>
    internal sealed class VirtualAgentDesignUpdateMutation : Mutation<VirtualAgentDesignUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualAgentDesignUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the virtual agent design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal VirtualAgentDesignUpdateMutation(VirtualAgentDesignUpdateInput data, VirtualAgentDesignQuery query)
            : base("virtualAgentDesignUpdate", "VirtualAgentDesignUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "virtualAgentDesign")))
        {
        }
    }
}
