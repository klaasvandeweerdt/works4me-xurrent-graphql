namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Adds a new note to a record.
    /// </summary>
    internal sealed class NoteCreateMutation : Mutation<NoteCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the note mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal NoteCreateMutation(NoteCreateInput data, NoteQuery query)
            : base("noteCreate", "NoteCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "note")))
        {
        }
    }
}
