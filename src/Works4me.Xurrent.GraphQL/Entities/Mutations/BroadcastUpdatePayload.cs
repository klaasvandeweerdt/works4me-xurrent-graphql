using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/broadcastupdatepayload/">BroadcastUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class BroadcastUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("broadcast", IsDefaultQueryProperty = true)]
        public Broadcast? Broadcast { get; internal set; }
    }
}
