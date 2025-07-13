namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Deletes an existing app offering automation rule.
    /// </summary>
    internal sealed class AppOfferingAutomationRuleDeleteMutation : Mutation<AppOfferingAutomationRuleDeleteMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleDeleteMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal AppOfferingAutomationRuleDeleteMutation(AppOfferingAutomationRuleDeleteMutationInput data)
            : base("appOfferingAutomationRuleDelete", "AppOfferingAutomationRuleDeleteMutationInput!", data, new MutationResponseQuery().SelectAll())
        {
        }
    }
}
