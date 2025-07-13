namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing automation rule.
    /// </summary>
    internal sealed class AutomationRuleUpdateMutation : Mutation<AutomationRuleUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AutomationRuleUpdateMutation(AutomationRuleUpdateInput data, AutomationRuleQuery query)
            : base("automationRuleUpdate", "AutomationRuleUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "automationRule")))
        {
        }
    }
}
