using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SeraAiStudio"/> query class.
    /// </summary>
    public class SeraAiStudioQuery : Query<SeraAiStudio, SeraAiStudioQuery, DefaultView, SeraAiStudioField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SeraAiStudioQuery"/> instance.
        /// </summary>
        public SeraAiStudioQuery() : base("seraAiStudio", false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SeraAiStudioQuery"/>, updated to include the "Account" sub-query.</returns>
        public SeraAiStudioQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Golden set test cases that benchmark the studio's search quality.
        /// </summary>
        /// <param name="query">The golden set items query.</param>
        /// <returns>The same <see cref="SeraAiStudioQuery"/>, updated to include the "GoldenSetItems" sub-query.</returns>
        public SeraAiStudioQuery SelectGoldenSetItems(GoldenSetItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("goldenSetItems", query, true);
        }

        /// <summary>
        /// Default "Run as" user pre-filled in the user column when adding new golden set rows.
        /// </summary>
        /// <param name="query">The run as query.</param>
        /// <returns>The same <see cref="SeraAiStudioQuery"/>, updated to include the "RunAs" sub-query.</returns>
        public SeraAiStudioQuery SelectRunAs(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("runAs", query, false);
        }
    }
}
