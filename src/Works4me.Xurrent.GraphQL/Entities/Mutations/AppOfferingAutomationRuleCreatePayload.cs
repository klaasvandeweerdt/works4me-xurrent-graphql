using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingautomationrulecreatepayload/">AppOfferingAutomationRuleCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class AppOfferingAutomationRuleCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("appOfferingAutomationRule", IsDefaultQueryProperty = true)]
        public AppOfferingAutomationRule? AppOfferingAutomationRule { get; internal set; }
    }
}
