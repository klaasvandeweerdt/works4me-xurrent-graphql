using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slacoveragegroupcreatepayload/">SlaCoverageGroupCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SlaCoverageGroupCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("slaCoverageGroup", IsDefaultQueryProperty = true)]
        public SlaCoverageGroup? SlaCoverageGroup { get; internal set; }
    }
}
