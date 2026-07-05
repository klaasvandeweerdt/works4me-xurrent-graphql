using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slacoveragegroupupdatepayload/">SlaCoverageGroupUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SlaCoverageGroupUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("slaCoverageGroup")]
        public SlaCoverageGroup? SlaCoverageGroup { get; internal set; }
    }
}
