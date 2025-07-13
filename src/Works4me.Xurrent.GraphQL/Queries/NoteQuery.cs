using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Note"/> query class.
    /// </summary>
    public class NoteQuery : Query<Note, NoteQuery, DefaultView, NoteField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="NoteQuery"/> instance.
        /// </summary>
        public NoteQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="NoteQuery"/>, updated to include the "Account" sub-query.</returns>
        public NoteQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The inbound email from which the note was created.
        /// </summary>
        /// <param name="query">The inbound email query.</param>
        /// <returns>The same <see cref="NoteQuery"/>, updated to include the "InboundEmail" sub-query.</returns>
        public NoteQuery SelectInboundEmail(InboundEmailQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("inboundEmail", query, false);
        }

        /// <summary>
        /// The note reactions belonging to this note.
        /// </summary>
        /// <param name="query">The note reactions query.</param>
        /// <returns>The same <see cref="NoteQuery"/>, updated to include the "NoteReactions" sub-query.</returns>
        public NoteQuery SelectNoteReactions(NoteReactionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("noteReactions", query, true);
        }

        /// <summary>
        /// Person who added this note.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="NoteQuery"/>, updated to include the "Person" sub-query.</returns>
        public NoteQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        /// <param name="query">The text attachments query.</param>
        /// <returns>The same <see cref="NoteQuery"/>, updated to include the "TextAttachments" sub-query.</returns>
        public NoteQuery SelectTextAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("textAttachments", query, true);
        }
    }
}
