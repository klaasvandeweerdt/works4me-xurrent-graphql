using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/holidayupdatepayload/">HolidayUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class HolidayUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("holiday", IsDefaultQueryProperty = true)]
        public Holiday? Holiday { get; internal set; }
    }
}
