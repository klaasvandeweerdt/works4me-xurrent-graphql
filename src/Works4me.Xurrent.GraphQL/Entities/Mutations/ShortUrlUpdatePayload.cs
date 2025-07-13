using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shorturlupdatepayload/">ShortUrlUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ShortUrlUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("shortUrl", IsDefaultQueryProperty = true)]
        public ShortUrl? ShortUrl { get; internal set; }
    }
}
