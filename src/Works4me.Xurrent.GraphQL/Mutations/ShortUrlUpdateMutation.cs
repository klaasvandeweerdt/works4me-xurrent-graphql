namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing short URL.
    /// </summary>
    internal sealed class ShortUrlUpdateMutation : Mutation<ShortUrlUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShortUrlUpdateMutation(ShortUrlUpdateInput data, ShortUrlQuery query)
            : base("shortUrlUpdate", "ShortUrlUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shortUrl")))
        {
        }
    }
}
