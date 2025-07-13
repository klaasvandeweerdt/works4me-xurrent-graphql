using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeallocationcreatepayload/">TimeAllocationCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class TimeAllocationCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("timeAllocation", IsDefaultQueryProperty = true)]
        public TimeAllocation? TimeAllocation { get; internal set; }
    }
}
