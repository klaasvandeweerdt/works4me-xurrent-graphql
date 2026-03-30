using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RfcTypeRate"/> query class.
    /// </summary>
    public class RfcTypeRateQuery : Query<RfcTypeRate, RfcTypeRateQuery, DefaultView, RfcTypeRateField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RfcTypeRateQuery"/> instance.
        /// </summary>
        public RfcTypeRateQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The request for change type of the RFC type rate.
        /// </summary>
        /// <param name="query">The rfc type query.</param>
        /// <returns>The same <see cref="RfcTypeRateQuery"/>, updated to include the "RfcType" sub-query.</returns>
        public RfcTypeRateQuery SelectRfcType(RfcTypeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("rfcType", query, false);
        }

        /// <summary>
        /// The service offering of the RFC type rate.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>The same <see cref="RfcTypeRateQuery"/>, updated to include the "ServiceOffering" sub-query.</returns>
        public RfcTypeRateQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOffering", query, false);
        }
    }
}
