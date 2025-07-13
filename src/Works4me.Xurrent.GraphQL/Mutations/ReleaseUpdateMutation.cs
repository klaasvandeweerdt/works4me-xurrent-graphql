namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing release.
    /// </summary>
    internal sealed class ReleaseUpdateMutation : Mutation<ReleaseUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ReleaseUpdateMutation(ReleaseUpdateInput data, ReleaseQuery query)
            : base("releaseUpdate", "ReleaseUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "release")))
        {
        }
    }
}
