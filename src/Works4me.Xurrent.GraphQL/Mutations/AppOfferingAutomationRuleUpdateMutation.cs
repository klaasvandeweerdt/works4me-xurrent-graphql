namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing app offering automation rule.
    /// </summary>
    internal sealed class AppOfferingAutomationRuleUpdateMutation : Mutation<AppOfferingAutomationRuleUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppOfferingAutomationRuleUpdateMutation(AppOfferingAutomationRuleUpdateInput data, AppOfferingAutomationRuleQuery query)
            : base("appOfferingAutomationRuleUpdate", "AppOfferingAutomationRuleUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "appOfferingAutomationRule")))
        {
        }
    }
}
