using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TimeAllocation"/> query class.
    /// </summary>
    public class TimeAllocationQuery : Query<TimeAllocation, TimeAllocationQuery, TimeAllocationView, TimeAllocationField, TimeAllocationFilterField, TimeAllocationOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TimeAllocationQuery"/> instance.
        /// </summary>
        public TimeAllocationQuery() : base("timeAllocations", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TimeAllocationQuery"/>, updated to include the "Account" sub-query.</returns>
        public TimeAllocationQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Customer organizations of the time allocation.
        /// </summary>
        /// <param name="query">The customers query.</param>
        /// <returns>The same <see cref="TimeAllocationQuery"/>, updated to include the "Customers" sub-query.</returns>
        public TimeAllocationQuery SelectCustomers(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customers", query, true);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="TimeAllocationQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public TimeAllocationQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// Organizations of the time allocation.
        /// </summary>
        /// <param name="query">The organizations query.</param>
        /// <returns>The same <see cref="TimeAllocationQuery"/>, updated to include the "Organizations" sub-query.</returns>
        public TimeAllocationQuery SelectOrganizations(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organizations", query, true);
        }

        /// <summary>
        /// Services of the time allocation.
        /// </summary>
        /// <param name="query">The services query.</param>
        /// <returns>The same <see cref="TimeAllocationQuery"/>, updated to include the "Services" sub-query.</returns>
        public TimeAllocationQuery SelectServices(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("services", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="TimeAllocationQuery"/>, updated to include the "Translations" sub-query.</returns>
        public TimeAllocationQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="TimeAllocationQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="TimeAllocationQuery">TimeAllocationQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public TimeAllocationQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
