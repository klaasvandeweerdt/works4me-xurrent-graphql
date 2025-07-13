using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="NoteReaction"/> query class.
    /// </summary>
    public class NoteReactionQuery : Query<NoteReaction, NoteReactionQuery, DefaultView, NoteReactionField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="NoteReactionQuery"/> instance.
        /// </summary>
        public NoteReactionQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Note this note reaction belongs to.
        /// </summary>
        /// <param name="query">The note query.</param>
        /// <returns>The same <see cref="NoteReactionQuery"/>, updated to include the "Note" sub-query.</returns>
        public NoteReactionQuery SelectNote(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("note", query, false);
        }

        /// <summary>
        /// Person who added this note reaction.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="NoteReactionQuery"/>, updated to include the "Person" sub-query.</returns>
        public NoteReactionQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }
    }
}
