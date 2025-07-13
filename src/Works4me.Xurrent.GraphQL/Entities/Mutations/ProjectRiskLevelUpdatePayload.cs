using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectrisklevelupdatepayload/">ProjectRiskLevelUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectRiskLevelUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectRiskLevel", IsDefaultQueryProperty = true)]
        public ProjectRiskLevel? ProjectRiskLevel { get; internal set; }
    }
}
