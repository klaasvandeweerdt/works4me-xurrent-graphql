using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/calendarcreatepayload/">CalendarCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class CalendarCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("calendar", IsDefaultQueryProperty = true)]
        public Calendar? Calendar { get; internal set; }
    }
}
