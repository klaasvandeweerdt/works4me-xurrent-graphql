using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timesheetsettingupdatepayload/">TimesheetSettingUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class TimesheetSettingUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("timesheetSetting", IsDefaultQueryProperty = true)]
        public TimesheetSetting? TimesheetSetting { get; internal set; }
    }
}
