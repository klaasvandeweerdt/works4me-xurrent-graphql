namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new automation rule.
    /// </summary>
    internal sealed class AutomationRuleCreateMutation : Mutation<AutomationRuleCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AutomationRuleCreateMutation(AutomationRuleCreateInput data, AutomationRuleQuery query)
            : base("automationRuleCreate", "AutomationRuleCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "automationRule")))
        {
        }
    }
}
