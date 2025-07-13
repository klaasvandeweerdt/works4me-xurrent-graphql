using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WaitingForCustomerFollowUp"/> query class.
    /// </summary>
    public class WaitingForCustomerFollowUpQuery : Query<WaitingForCustomerFollowUp, WaitingForCustomerFollowUpQuery, DefaultView, WaitingForCustomerFollowUpField, WaitingForCustomerFollowUpFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WaitingForCustomerFollowUpQuery"/> instance.
        /// </summary>
        public WaitingForCustomerFollowUpQuery() : base("waitingForCustomerFollowUps", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WaitingForCustomerFollowUpQuery"/>, updated to include the "Account" sub-query.</returns>
        public WaitingForCustomerFollowUpQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Rules of the waiting for customer follow-up.
        /// </summary>
        /// <param name="query">The waiting for customer rules query.</param>
        /// <returns>The same <see cref="WaitingForCustomerFollowUpQuery"/>, updated to include the "WaitingForCustomerRules" sub-query.</returns>
        public WaitingForCustomerFollowUpQuery SelectWaitingForCustomerRules(WaitingForCustomerRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("waitingForCustomerRules", query, true);
        }
    }
}
