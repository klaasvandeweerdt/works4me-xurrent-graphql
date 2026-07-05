namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing site.
    /// </summary>
    internal sealed class SiteUpdateMutation : Mutation<SiteUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SiteUpdateMutation(SiteUpdateInput data, SiteQuery? query)
            : base("siteUpdate", "SiteUpdateInput!", data, query is null ? new SiteUpdatePayloadQuery() : new SiteUpdatePayloadQuery().Select(UpdateQuery(query, "site")))
        {
        }
    }
}
