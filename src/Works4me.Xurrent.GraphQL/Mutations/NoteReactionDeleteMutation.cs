namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Deletes a note reaction from a note.
    /// </summary>
    internal sealed class NoteReactionDeleteMutation : Mutation<NoteReactionDeleteMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteReactionDeleteMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal NoteReactionDeleteMutation(NoteReactionDeleteMutationInput data)
            : base("noteReactionDelete", "NoteReactionDeleteMutationInput!", data, new MutationResponseQuery().SelectAll())
        {
        }
    }
}
