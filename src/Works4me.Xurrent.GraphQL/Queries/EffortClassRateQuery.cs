using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRate"/> query class.
    /// </summary>
    public class EffortClassRateQuery : Query<EffortClassRate, EffortClassRateQuery, DefaultView, EffortClassRateField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="EffortClassRateQuery"/> instance.
        /// </summary>
        public EffortClassRateQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The effort class of the effort class rate.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="EffortClassRateQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public EffortClassRateQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// The service offering of the effort class rate.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>The same <see cref="EffortClassRateQuery"/>, updated to include the "ServiceOffering" sub-query.</returns>
        public EffortClassRateQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOffering", query, false);
        }
    }
}
