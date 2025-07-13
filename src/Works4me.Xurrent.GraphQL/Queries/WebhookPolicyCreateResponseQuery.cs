using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WebhookPolicyCreateResponse"/> query class.
    /// </summary>
    public class WebhookPolicyCreateResponseQuery : Query<WebhookPolicyCreateResponse, WebhookPolicyCreateResponseQuery, DefaultView, WebhookPolicyCreateResponseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WebhookPolicyCreateResponseQuery"/> instance.
        /// </summary>
        public WebhookPolicyCreateResponseQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WebhookPolicyCreateResponseQuery"/>, updated to include the "Account" sub-query.</returns>
        public WebhookPolicyCreateResponseQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }
    }
}
