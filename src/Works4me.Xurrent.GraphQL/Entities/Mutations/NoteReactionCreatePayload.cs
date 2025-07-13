using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/notereactioncreatepayload/">NoteReactionCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class NoteReactionCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("noteReaction", IsDefaultQueryProperty = true)]
        public NoteReaction? NoteReaction { get; internal set; }
    }
}
