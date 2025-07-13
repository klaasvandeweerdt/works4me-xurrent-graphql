using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/riskseverityupdatepayload/">RiskSeverityUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class RiskSeverityUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("riskSeverity", IsDefaultQueryProperty = true)]
        public RiskSeverity? RiskSeverity { get; internal set; }
    }
}
