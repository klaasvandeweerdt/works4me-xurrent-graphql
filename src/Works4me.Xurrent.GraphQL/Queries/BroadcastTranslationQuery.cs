using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="BroadcastTranslation"/> query class.
    /// </summary>
    public class BroadcastTranslationQuery : Query<BroadcastTranslation, BroadcastTranslationQuery, DefaultView, BroadcastTranslationField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="BroadcastTranslationQuery"/> instance.
        /// </summary>
        public BroadcastTranslationQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the <c>message</c> field.
        /// </summary>
        /// <param name="query">The message attachments query.</param>
        /// <returns>The same <see cref="BroadcastTranslationQuery"/>, updated to include the "MessageAttachments" sub-query.</returns>
        public BroadcastTranslationQuery SelectMessageAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("messageAttachments", query, true);
        }
    }
}
