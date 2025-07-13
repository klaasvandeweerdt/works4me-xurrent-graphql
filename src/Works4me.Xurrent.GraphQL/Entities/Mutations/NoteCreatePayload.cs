using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/notecreatepayload/">NoteCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class NoteCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("note", IsDefaultQueryProperty = true)]
        public Note? Note { get; internal set; }
    }
}
