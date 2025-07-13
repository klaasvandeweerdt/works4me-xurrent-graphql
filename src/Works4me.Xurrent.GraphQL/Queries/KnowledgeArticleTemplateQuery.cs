using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="KnowledgeArticleTemplate"/> query class.
    /// </summary>
    public class KnowledgeArticleTemplateQuery : Query<KnowledgeArticleTemplate, KnowledgeArticleTemplateQuery, KnowledgeArticleTemplateView, KnowledgeArticleTemplateField, KnowledgeArticleTemplateFilterField, KnowledgeArticleTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="KnowledgeArticleTemplateQuery"/> instance.
        /// </summary>
        public KnowledgeArticleTemplateQuery() : base("knowledgeArticleTemplates", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="KnowledgeArticleTemplateQuery"/>, updated to include the "Account" sub-query.</returns>
        public KnowledgeArticleTemplateQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Service that is applied to knowledge articles using this template.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="KnowledgeArticleTemplateQuery"/>, updated to include the "Service" sub-query.</returns>
        public KnowledgeArticleTemplateQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Service instances that are applied to knowledge articles using this template.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="KnowledgeArticleTemplateQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public KnowledgeArticleTemplateQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// The UI extension that is applied to knowledge articles using this template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="KnowledgeArticleTemplateQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public KnowledgeArticleTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="KnowledgeArticleTemplateQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="KnowledgeArticleTemplateQuery">KnowledgeArticleTemplateQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public KnowledgeArticleTemplateQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
