namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Adds a new note reaction to a note.
    /// </summary>
    internal sealed class NoteReactionCreateMutation : Mutation<NoteReactionCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteReactionCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the note reaction mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal NoteReactionCreateMutation(NoteReactionCreateInput data, NoteReactionQuery query)
            : base("noteReactionCreate", "NoteReactionCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "noteReaction")))
        {
        }
    }
}
