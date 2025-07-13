using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SlaNotificationScheme"/> query class.
    /// </summary>
    public class SlaNotificationSchemeQuery : Query<SlaNotificationScheme, SlaNotificationSchemeQuery, DefaultView, SlaNotificationSchemeField, SlaNotificationSchemeFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SlaNotificationSchemeQuery"/> instance.
        /// </summary>
        public SlaNotificationSchemeQuery() : base("slaNotificationSchemes", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SlaNotificationSchemeQuery"/>, updated to include the "Account" sub-query.</returns>
        public SlaNotificationSchemeQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Rules of the SLA notification scheme.
        /// </summary>
        /// <param name="query">The sla notification rules query.</param>
        /// <returns>The same <see cref="SlaNotificationSchemeQuery"/>, updated to include the "SlaNotificationRules" sub-query.</returns>
        public SlaNotificationSchemeQuery SelectSlaNotificationRules(SlaNotificationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("slaNotificationRules", query, true);
        }
    }
}
