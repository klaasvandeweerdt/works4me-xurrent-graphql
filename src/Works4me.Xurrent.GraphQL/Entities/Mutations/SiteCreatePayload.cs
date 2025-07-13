using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/sitecreatepayload/">SiteCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SiteCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("site", IsDefaultQueryProperty = true)]
        public Site? Site { get; internal set; }
    }
}
