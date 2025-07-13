using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/riskseveritycreatepayload/">RiskSeverityCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class RiskSeverityCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("riskSeverity", IsDefaultQueryProperty = true)]
        public RiskSeverity? RiskSeverity { get; internal set; }
    }
}
