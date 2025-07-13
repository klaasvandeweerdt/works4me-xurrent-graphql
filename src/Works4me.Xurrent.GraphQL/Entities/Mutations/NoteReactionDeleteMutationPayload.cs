using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/notereactiondeletemutationpayload/">NoteReactionDeleteMutationPayload</see> in Xurrent.
    /// </summary>
    public sealed class NoteReactionDeleteMutationPayload : MutationResultBase
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [XurrentField("success", IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
