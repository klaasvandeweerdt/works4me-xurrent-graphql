using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/releasecreatepayload/">ReleaseCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ReleaseCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("release", IsDefaultQueryProperty = true)]
        public Release? Release { get; internal set; }
    }
}
