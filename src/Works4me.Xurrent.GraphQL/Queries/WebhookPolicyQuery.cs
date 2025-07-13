using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WebhookPolicy"/> query class.
    /// </summary>
    public class WebhookPolicyQuery : Query<WebhookPolicy, WebhookPolicyQuery, DefaultView, WebhookPolicyField, WebhookPolicyFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WebhookPolicyQuery"/> instance.
        /// </summary>
        public WebhookPolicyQuery() : base("webhookPolicies", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WebhookPolicyQuery"/>, updated to include the "Account" sub-query.</returns>
        public WebhookPolicyQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }
    }
}
