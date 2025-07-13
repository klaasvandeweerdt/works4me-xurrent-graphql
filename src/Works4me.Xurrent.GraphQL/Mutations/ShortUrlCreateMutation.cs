namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new short URL.
    /// </summary>
    internal sealed class ShortUrlCreateMutation : Mutation<ShortUrlCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the short url mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShortUrlCreateMutation(ShortUrlCreateInput data, ShortUrlQuery query)
            : base("shortUrlCreate", "ShortUrlCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shortUrl")))
        {
        }
    }
}
