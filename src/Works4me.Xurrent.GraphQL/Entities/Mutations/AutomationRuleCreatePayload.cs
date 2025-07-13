using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/automationrulecreatepayload/">AutomationRuleCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class AutomationRuleCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("automationRule", IsDefaultQueryProperty = true)]
        public AutomationRule? AutomationRule { get; internal set; }
    }
}
