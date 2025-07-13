using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/teamcreatepayload/">TeamCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class TeamCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("team", IsDefaultQueryProperty = true)]
        public Team? Team { get; internal set; }
    }
}
