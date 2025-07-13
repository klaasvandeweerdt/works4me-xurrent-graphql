using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/agileboardcreatepayload/">AgileBoardCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class AgileBoardCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("agileBoard", IsDefaultQueryProperty = true)]
        public AgileBoard? AgileBoard { get; internal set; }
    }
}
