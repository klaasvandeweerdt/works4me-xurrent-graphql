using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeentryupdatepayload/">TimeEntryUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class TimeEntryUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("timeEntry", IsDefaultQueryProperty = true)]
        public TimeEntry? TimeEntry { get; internal set; }
    }
}
