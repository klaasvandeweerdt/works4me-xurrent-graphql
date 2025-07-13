namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Deletes an out of office period.
    /// </summary>
    internal sealed class OutOfOfficePeriodDeleteMutation : Mutation<OutOfOfficePeriodDeleteMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodDeleteMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal OutOfOfficePeriodDeleteMutation(OutOfOfficePeriodDeleteMutationInput data)
            : base("outOfOfficePeriodDelete", "OutOfOfficePeriodDeleteMutationInput!", data, new MutationResponseQuery().SelectAll())
        {
        }
    }
}
