using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="KnowledgeArticle"/> query class.
    /// </summary>
    public class KnowledgeArticleQuery : Query<KnowledgeArticle, KnowledgeArticleQuery, KnowledgeArticleView, KnowledgeArticleField, KnowledgeArticleFilterField, KnowledgeArticleOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="KnowledgeArticleQuery"/> instance.
        /// </summary>
        public KnowledgeArticleQuery() : base("knowledgeArticles", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "Account" sub-query.</returns>
        public KnowledgeArticleQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The person who created the knowledge article.
        /// </summary>
        /// <param name="query">The created by query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "CreatedBy" sub-query.</returns>
        public KnowledgeArticleQuery SelectCreatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("createdBy", query, false);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public KnowledgeArticleQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public KnowledgeArticleQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public KnowledgeArticleQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public KnowledgeArticleQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// Requests linked to this knowledge article.
        /// </summary>
        /// <param name="query">The requests query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "Requests" sub-query.</returns>
        public KnowledgeArticleQuery SelectRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requests", query, true);
        }

        /// <summary>
        /// Service for which the knowledge article is made available.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "Service" sub-query.</returns>
        public KnowledgeArticleQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Service instances linked to this knowledge article.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public KnowledgeArticleQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// The knowledge article template that this knowledge article is based on.
        /// </summary>
        /// <param name="query">The template query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "Template" sub-query.</returns>
        public KnowledgeArticleQuery SelectTemplate(KnowledgeArticleTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("template", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "Translations" sub-query.</returns>
        public KnowledgeArticleQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// The person who last updated the knowledge article.
        /// </summary>
        /// <param name="query">The updated by query.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery"/>, updated to include the "UpdatedBy" sub-query.</returns>
        public KnowledgeArticleQuery SelectUpdatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("updatedBy", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="KnowledgeArticle">KnowledgeArticle</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/knowledgearticlecustomfilter/">Xurrent developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">
        /// Use value <c>null</c> to indicate "None".
        /// 
        /// For "text" fields:
        /// • One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).
        /// 
        /// For "number" and "time" fields:
        /// • One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.
        /// • Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.
        /// • <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.
        /// • <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.
        /// 
        /// For "date" and "date-time" fields:
        /// • One must supply a single value (and <c>null</c> is not supported).
        /// • Matches are always relative with an optional upper bound.
        /// • Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).
        /// • Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).
        /// • <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.
        /// 
        /// For "select" fields:
        /// • One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).
        /// • Matches are case-sensitive.
        /// </param>
        public KnowledgeArticleQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="KnowledgeArticleQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="KnowledgeArticleQuery">KnowledgeArticleQuery</see>, updated to include the "Search" sub-query.</returns>
        public KnowledgeArticleQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
