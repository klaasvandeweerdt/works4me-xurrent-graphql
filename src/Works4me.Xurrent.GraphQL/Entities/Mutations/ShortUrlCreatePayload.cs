using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shorturlcreatepayload/">ShortUrlCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ShortUrlCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("shortUrl", IsDefaultQueryProperty = true)]
        public ShortUrl? ShortUrl { get; internal set; }
    }
}
