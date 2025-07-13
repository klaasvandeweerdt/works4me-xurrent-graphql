namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new release.
    /// </summary>
    internal sealed class ReleaseCreateMutation : Mutation<ReleaseCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the release mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ReleaseCreateMutation(ReleaseCreateInput data, ReleaseQuery query)
            : base("releaseCreate", "ReleaseCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "release")))
        {
        }
    }
}
