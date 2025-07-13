namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new app offering automation rule.
    /// </summary>
    internal sealed class AppOfferingAutomationRuleCreateMutation : Mutation<AppOfferingAutomationRuleCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app offering automation rule mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppOfferingAutomationRuleCreateMutation(AppOfferingAutomationRuleCreateInput data, AppOfferingAutomationRuleQuery query)
            : base("appOfferingAutomationRuleCreate", "AppOfferingAutomationRuleCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "appOfferingAutomationRule")))
        {
        }
    }
}
