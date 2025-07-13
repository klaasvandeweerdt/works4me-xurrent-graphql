using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/releaseupdatepayload/">ReleaseUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ReleaseUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("release", IsDefaultQueryProperty = true)]
        public Release? Release { get; internal set; }
    }
}
