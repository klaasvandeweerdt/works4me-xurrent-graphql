using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRateID"/> query class.
    /// </summary>
    public class EffortClassRateIDQuery : Query<EffortClassRateID, EffortClassRateIDQuery, DefaultView, EffortClassRateIDField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="EffortClassRateIDQuery"/> instance.
        /// </summary>
        public EffortClassRateIDQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The effort class for which a rateID is provided.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="EffortClassRateIDQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public EffortClassRateIDQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }
    }
}
