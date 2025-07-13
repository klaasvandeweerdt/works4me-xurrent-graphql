using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/outofofficeperiodcreatepayload/">OutOfOfficePeriodCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class OutOfOfficePeriodCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("outOfOfficePeriod", IsDefaultQueryProperty = true)]
        public OutOfOfficePeriod? OutOfOfficePeriod { get; internal set; }
    }
}
