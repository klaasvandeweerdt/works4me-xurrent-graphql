using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/cistagedchangeupdatepayload/">CiStagedChangeUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class CiStagedChangeUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("ciStagedChange", IsDefaultQueryProperty = true)]
        public CiStagedChange? CiStagedChange { get; internal set; }
    }
}
