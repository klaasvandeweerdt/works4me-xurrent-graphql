using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CiStagedChange"/> query class.
    /// </summary>
    public class CiStagedChangeQuery : Query<CiStagedChange, CiStagedChangeQuery, CiStagedChangeView, CiStagedChangeField, CiStagedChangeFilterField, CiStagedChangeOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="CiStagedChangeQuery"/> instance.
        /// </summary>
        public CiStagedChangeQuery() : base("ciStagedChanges", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="CiStagedChangeQuery"/>, updated to include the "Account" sub-query.</returns>
        public CiStagedChangeQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The automation rule that triggered this staged change.
        /// </summary>
        /// <param name="query">The automation rule query.</param>
        /// <returns>The same <see cref="CiStagedChangeQuery"/>, updated to include the "AutomationRule" sub-query.</returns>
        public CiStagedChangeQuery SelectAutomationRule(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRule", query, false);
        }

        /// <summary>
        /// The configuration item this staged change proposes to modify.
        /// </summary>
        /// <param name="query">The ci query.</param>
        /// <returns>The same <see cref="CiStagedChangeQuery"/>, updated to include the "Ci" sub-query.</returns>
        public CiStagedChangeQuery SelectCi(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("ci", query, false);
        }

        /// <summary>
        /// The person who initiated the change that was intercepted.
        /// </summary>
        /// <param name="query">The created by query.</param>
        /// <returns>The same <see cref="CiStagedChangeQuery"/>, updated to include the "CreatedBy" sub-query.</returns>
        public CiStagedChangeQuery SelectCreatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("createdBy", query, false);
        }

        /// <summary>
        /// The person who reviewed this staged change.
        /// </summary>
        /// <param name="query">The reviewed by query.</param>
        /// <returns>The same <see cref="CiStagedChangeQuery"/>, updated to include the "ReviewedBy" sub-query.</returns>
        public CiStagedChangeQuery SelectReviewedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("reviewedBy", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="CiStagedChangeQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="CiStagedChangeQuery">CiStagedChangeQuery</see>, updated to include the "Search" sub-query.</returns>
        public CiStagedChangeQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
