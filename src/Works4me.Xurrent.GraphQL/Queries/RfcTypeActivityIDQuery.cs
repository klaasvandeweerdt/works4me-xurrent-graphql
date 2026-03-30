using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RfcTypeActivityID"/> query class.
    /// </summary>
    public class RfcTypeActivityIDQuery : Query<RfcTypeActivityID, RfcTypeActivityIDQuery, DefaultView, RfcTypeActivityIDField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RfcTypeActivityIDQuery"/> instance.
        /// </summary>
        public RfcTypeActivityIDQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The request for change type for which an activityID is provided.
        /// </summary>
        /// <param name="query">The rfc type query.</param>
        /// <returns>The same <see cref="RfcTypeActivityIDQuery"/>, updated to include the "RfcType" sub-query.</returns>
        public RfcTypeActivityIDQuery SelectRfcType(RfcTypeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("rfcType", query, false);
        }
    }
}
