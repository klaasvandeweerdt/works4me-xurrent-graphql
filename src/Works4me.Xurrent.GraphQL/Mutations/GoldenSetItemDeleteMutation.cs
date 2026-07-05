namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Deletes a golden set item.
    /// </summary>
    internal sealed class GoldenSetItemDeleteMutation : Mutation<GoldenSetItemDeleteMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemDeleteMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal GoldenSetItemDeleteMutation(GoldenSetItemDeleteMutationInput data)
            : base("goldenSetItemDelete", "GoldenSetItemDeleteMutationInput!", data, new GoldenSetItemDeleteMutationPayloadQuery())
        {
        }
    }
}
