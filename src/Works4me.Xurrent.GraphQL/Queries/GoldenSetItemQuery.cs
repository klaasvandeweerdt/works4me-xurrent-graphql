using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="GoldenSetItem"/> query class.
    /// </summary>
    public class GoldenSetItemQuery : Query<GoldenSetItem, GoldenSetItemQuery, DefaultView, GoldenSetItemField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="GoldenSetItemQuery"/> instance.
        /// </summary>
        public GoldenSetItemQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="GoldenSetItemQuery"/>, updated to include the "Account" sub-query.</returns>
        public GoldenSetItemQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The Knowledge Article or Request Template the agent is expected to surface.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="knowledgeArticleQuery">The knowledge article query.</param>
        /// <param name="requestTemplateQuery">The request template query.</param>
        /// <returns>The same <see cref="GoldenSetItemQuery"/>, updated to include the sub-queries.</returns>
        public GoldenSetItemQuery SelectExpectedHitAll(
            KnowledgeArticleQuery? knowledgeArticleQuery = null,
            RequestTemplateQuery? requestTemplateQuery = null)
        {
            GoldenSetItemQuery query = SelectOnType("expectedHit", knowledgeArticleQuery ?? new(), false);
            query = query.SelectOnType("expectedHit", requestTemplateQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The Knowledge Article or Request Template the agent is expected to surface.<br />
        /// Use this method along with other <c>SelectExpectedHit()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectExpectedHit()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The expected hit query.</param>
        /// <returns>The same <see cref="GoldenSetItemQuery"/>, updated to include the "ExpectedHit" sub-query.</returns>
        public GoldenSetItemQuery SelectExpectedHit(KnowledgeArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("expectedHit", query, false);
        }

        /// <summary>
        /// The Knowledge Article or Request Template the agent is expected to surface.<br />
        /// Use this method along with other <c>SelectExpectedHit()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectExpectedHit()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The expected hit query.</param>
        /// <returns>The same <see cref="GoldenSetItemQuery"/>, updated to include the "ExpectedHit" sub-query.</returns>
        public GoldenSetItemQuery SelectExpectedHit(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("expectedHit", query, false);
        }

        /// <summary>
        /// Person whose role and locale the evaluation impersonates.
        /// </summary>
        /// <param name="query">The run as query.</param>
        /// <returns>The same <see cref="GoldenSetItemQuery"/>, updated to include the "RunAs" sub-query.</returns>
        public GoldenSetItemQuery SelectRunAs(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("runAs", query, false);
        }

        /// <summary>
        /// Sera AI Studio that owns this golden set item.
        /// </summary>
        /// <param name="query">The sera ai studio query.</param>
        /// <returns>The same <see cref="GoldenSetItemQuery"/>, updated to include the "SeraAiStudio" sub-query.</returns>
        public GoldenSetItemQuery SelectSeraAiStudio(SeraAiStudioQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("seraAiStudio", query, false);
        }
    }
}
