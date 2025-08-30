using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Translation"/> query class.
    /// </summary>
    public class TranslationQuery : Query<Translation, TranslationQuery, TranslationView, TranslationField, TranslationFilterField, TranslationOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TranslationQuery"/> instance.
        /// </summary>
        public TranslationQuery() : base("translations", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Account" sub-query.</returns>
        public TranslationQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="accountDesignQuery">The account design query.</param>
        /// <param name="closureCodeQuery">The closure code query.</param>
        /// <param name="customCollectionElementQuery">The custom collection element query.</param>
        /// <param name="emailTemplateQuery">The email template query.</param>
        /// <param name="knowledgeArticleQuery">The knowledge article query.</param>
        /// <param name="pdfDesignQuery">The pdf design query.</param>
        /// <param name="productCategoryQuery">The product category query.</param>
        /// <param name="requestTemplateQuery">The request template query.</param>
        /// <param name="riskSeverityQuery">The risk severity query.</param>
        /// <param name="serviceQuery">The service query.</param>
        /// <param name="serviceCategoryQuery">The service category query.</param>
        /// <param name="serviceInstanceQuery">The service instance query.</param>
        /// <param name="shopArticleQuery">The shop article query.</param>
        /// <param name="shopArticleCategoryQuery">The shop article category query.</param>
        /// <param name="surveyQuery">The survey query.</param>
        /// <param name="surveyQuestionQuery">The survey question query.</param>
        /// <param name="timeAllocationQuery">The time allocation query.</param>
        /// <param name="uiExtensionQuery">The ui extension query.</param>
        /// <param name="workflowTemplatePhaseQuery">The workflow template phase query.</param>
        /// <param name="workflowTypeQuery">The workflow type query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the sub-queries.</returns>
        public TranslationQuery SelectOwnerAll(
            AccountDesignQuery? accountDesignQuery = null,
            ClosureCodeQuery? closureCodeQuery = null,
            CustomCollectionElementQuery? customCollectionElementQuery = null,
            EmailTemplateQuery? emailTemplateQuery = null,
            KnowledgeArticleQuery? knowledgeArticleQuery = null,
            PdfDesignQuery? pdfDesignQuery = null,
            ProductCategoryQuery? productCategoryQuery = null,
            RequestTemplateQuery? requestTemplateQuery = null,
            RiskSeverityQuery? riskSeverityQuery = null,
            ServiceQuery? serviceQuery = null,
            ServiceCategoryQuery? serviceCategoryQuery = null,
            ServiceInstanceQuery? serviceInstanceQuery = null,
            ShopArticleQuery? shopArticleQuery = null,
            ShopArticleCategoryQuery? shopArticleCategoryQuery = null,
            SurveyQuery? surveyQuery = null,
            SurveyQuestionQuery? surveyQuestionQuery = null,
            TimeAllocationQuery? timeAllocationQuery = null,
            UiExtensionQuery? uiExtensionQuery = null,
            WorkflowTemplatePhaseQuery? workflowTemplatePhaseQuery = null,
            WorkflowTypeQuery? workflowTypeQuery = null)
        {
            TranslationQuery query = SelectOnType("owner", accountDesignQuery ?? new(), false);
            query = query.SelectOnType("owner", closureCodeQuery ?? new(), false);
            query = query.SelectOnType("owner", customCollectionElementQuery ?? new(), false);
            query = query.SelectOnType("owner", emailTemplateQuery ?? new(), false);
            query = query.SelectOnType("owner", knowledgeArticleQuery ?? new(), false);
            query = query.SelectOnType("owner", pdfDesignQuery ?? new(), false);
            query = query.SelectOnType("owner", productCategoryQuery ?? new(), false);
            query = query.SelectOnType("owner", requestTemplateQuery ?? new(), false);
            query = query.SelectOnType("owner", riskSeverityQuery ?? new(), false);
            query = query.SelectOnType("owner", serviceQuery ?? new(), false);
            query = query.SelectOnType("owner", serviceCategoryQuery ?? new(), false);
            query = query.SelectOnType("owner", serviceInstanceQuery ?? new(), false);
            query = query.SelectOnType("owner", shopArticleQuery ?? new(), false);
            query = query.SelectOnType("owner", shopArticleCategoryQuery ?? new(), false);
            query = query.SelectOnType("owner", surveyQuery ?? new(), false);
            query = query.SelectOnType("owner", surveyQuestionQuery ?? new(), false);
            query = query.SelectOnType("owner", timeAllocationQuery ?? new(), false);
            query = query.SelectOnType("owner", uiExtensionQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowTemplatePhaseQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowTypeQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(AccountDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ClosureCodeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(CustomCollectionElementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(EmailTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(KnowledgeArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(PdfDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ProductCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(RiskSeverityQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ServiceCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ShopArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(ShopArticleCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(SurveyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(SurveyQuestionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(TimeAllocationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(WorkflowTemplatePhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record from which the translation is obtained.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="TranslationQuery"/>, updated to include the "Owner" sub-query.</returns>
        public TranslationQuery SelectOwner(WorkflowTypeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="TranslationQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="TranslationQuery">TranslationQuery</see>, updated to include the "Search" sub-query.</returns>
        public TranslationQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
