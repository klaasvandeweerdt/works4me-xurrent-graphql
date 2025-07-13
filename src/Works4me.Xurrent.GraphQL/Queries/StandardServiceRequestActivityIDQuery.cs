using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequestActivityID"/> query class.
    /// </summary>
    public class StandardServiceRequestActivityIDQuery : Query<StandardServiceRequestActivityID, StandardServiceRequestActivityIDQuery, DefaultView, StandardServiceRequestActivityIDField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="StandardServiceRequestActivityIDQuery"/> instance.
        /// </summary>
        public StandardServiceRequestActivityIDQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The standard service request for which an activityID is provided.
        /// </summary>
        /// <param name="query">The standard service request query.</param>
        /// <returns>The same <see cref="StandardServiceRequestActivityIDQuery"/>, updated to include the "StandardServiceRequest" sub-query.</returns>
        public StandardServiceRequestActivityIDQuery SelectStandardServiceRequest(StandardServiceRequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("standardServiceRequest", query, false);
        }
    }
}
