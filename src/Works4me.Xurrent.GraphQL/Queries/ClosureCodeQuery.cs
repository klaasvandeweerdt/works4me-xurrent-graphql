using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ClosureCode"/> query class.
    /// </summary>
    public class ClosureCodeQuery : Query<ClosureCode, ClosureCodeQuery, DefaultView, ClosureCodeField, ClosureCodeFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ClosureCodeQuery"/> instance.
        /// </summary>
        public ClosureCodeQuery() : base("closureCodes", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ClosureCodeQuery"/>, updated to include the "Account" sub-query.</returns>
        public ClosureCodeQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The information attachments query.</param>
        /// <returns>The same <see cref="ClosureCodeQuery"/>, updated to include the "InformationAttachments" sub-query.</returns>
        public ClosureCodeQuery SelectInformationAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("informationAttachments", query, true);
        }
    }
}
