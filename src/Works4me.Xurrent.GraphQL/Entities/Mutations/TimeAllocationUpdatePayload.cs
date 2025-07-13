using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeallocationupdatepayload/">TimeAllocationUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class TimeAllocationUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("timeAllocation", IsDefaultQueryProperty = true)]
        public TimeAllocation? TimeAllocation { get; internal set; }
    }
}
