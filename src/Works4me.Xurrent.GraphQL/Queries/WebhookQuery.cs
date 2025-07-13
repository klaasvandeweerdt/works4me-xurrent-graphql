using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Webhook"/> query class.
    /// </summary>
    public class WebhookQuery : Query<Webhook, WebhookQuery, DefaultView, WebhookField, WebhookFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WebhookQuery"/> instance.
        /// </summary>
        public WebhookQuery() : base("webhooks", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WebhookQuery"/>, updated to include the "Account" sub-query.</returns>
        public WebhookQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="WebhookQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public WebhookQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// The webhook policy to use for cryptographic signing of the messages.
        /// </summary>
        /// <param name="query">The webhook policy query.</param>
        /// <returns>The same <see cref="WebhookQuery"/>, updated to include the "WebhookPolicy" sub-query.</returns>
        public WebhookQuery SelectWebhookPolicy(WebhookPolicyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("webhookPolicy", query, false);
        }
    }
}
