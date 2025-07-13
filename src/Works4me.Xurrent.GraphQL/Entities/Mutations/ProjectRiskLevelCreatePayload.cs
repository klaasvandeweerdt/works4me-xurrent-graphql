using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectrisklevelcreatepayload/">ProjectRiskLevelCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectRiskLevelCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectRiskLevel", IsDefaultQueryProperty = true)]
        public ProjectRiskLevel? ProjectRiskLevel { get; internal set; }
    }
}
