using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/effortclassupdatepayload/">EffortClassUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class EffortClassUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("effortClass", IsDefaultQueryProperty = true)]
        public EffortClass? EffortClass { get; internal set; }
    }
}
