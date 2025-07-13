using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SlaCoverageGroup"/> query class.
    /// </summary>
    public class SlaCoverageGroupQuery : Query<SlaCoverageGroup, SlaCoverageGroupQuery, DefaultView, SlaCoverageGroupField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SlaCoverageGroupQuery"/> instance.
        /// </summary>
        public SlaCoverageGroupQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SlaCoverageGroupQuery"/>, updated to include the "Account" sub-query.</returns>
        public SlaCoverageGroupQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="SlaCoverageGroupQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public SlaCoverageGroupQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// People of the SLA coverage group.
        /// </summary>
        /// <param name="query">The people query.</param>
        /// <returns>The same <see cref="SlaCoverageGroupQuery"/>, updated to include the "People" sub-query.</returns>
        public SlaCoverageGroupQuery SelectPeople(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("people", query, true);
        }

        /// <summary>
        /// Service level agreements linked to the SLA coverage group.
        /// </summary>
        /// <param name="query">The slas query.</param>
        /// <returns>The same <see cref="SlaCoverageGroupQuery"/>, updated to include the "Slas" sub-query.</returns>
        public SlaCoverageGroupQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("slas", query, true);
        }
    }
}
