using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/riskcreatepayload/">RiskCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class RiskCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("risk", IsDefaultQueryProperty = true)]
        public Risk? Risk { get; internal set; }
    }
}
