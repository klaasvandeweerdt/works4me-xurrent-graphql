namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new site.
    /// </summary>
    internal sealed class SiteCreateMutation : Mutation<SiteCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the site mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SiteCreateMutation(SiteCreateInput data, SiteQuery query)
            : base("siteCreate", "SiteCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "site")))
        {
        }
    }
}
