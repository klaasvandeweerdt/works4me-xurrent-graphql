using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/effortclass/">EffortClass</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("EffortClass")]
    public sealed class EffortClass : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The amount with which to multiply the cost of time entries with this effort class.
        /// </summary>
        [XurrentField("costMultiplier")]
        public decimal? CostMultiplier { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the effort class may no longer be related to any more timesheet settings.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the effort class.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the effort class takes when it is displayed in a sorted list.
        /// </summary>
        [XurrentField("position")]
        public long? Position { get; internal set; }

        [XurrentField("serviceOfferings")]
        internal PagedResponse<ServiceOffering>? ServiceOfferingsCollection { get; set; }
        /// <summary>
        /// Service offerings of this effort class.
        /// </summary>
        public ReadOnlyDataCollection<ServiceOffering>? ServiceOfferings { get => ServiceOfferingsCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceOffering>(ServiceOfferingsCollection.Data); }

        [XurrentField("skillPools")]
        internal PagedResponse<SkillPool>? SkillPoolsCollection { get; set; }
        /// <summary>
        /// Skill pools of this effort class.
        /// </summary>
        public ReadOnlyDataCollection<SkillPool>? SkillPools { get => SkillPoolsCollection?.Data is null ? null : new ReadOnlyDataCollection<SkillPool>(SkillPoolsCollection.Data); }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        [XurrentField("timesheetSettings")]
        internal PagedResponse<TimesheetSetting>? TimesheetSettingsCollection { get; set; }
        /// <summary>
        /// Timesheet settings of this effort class.
        /// </summary>
        public ReadOnlyDataCollection<TimesheetSetting>? TimesheetSettings { get => TimesheetSettingsCollection?.Data is null ? null : new ReadOnlyDataCollection<TimesheetSetting>(TimesheetSettingsCollection.Data); }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is EffortClass effortClass)
            {
                ServiceOfferingsCollection?.Data?.AddRange(effortClass.ServiceOfferings);
                SkillPoolsCollection?.Data?.AddRange(effortClass.SkillPools);
                TimesheetSettingsCollection?.Data?.AddRange(effortClass.TimesheetSettings);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ServiceOfferingsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceOfferingsCollection.GetPageInfo("serviceOfferings", depth))
                    yield return pageInfo;

            if (SkillPoolsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SkillPoolsCollection.GetPageInfo("skillPools", depth))
                    yield return pageInfo;

            if (TimesheetSettingsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TimesheetSettingsCollection.GetPageInfo("timesheetSettings", depth))
                    yield return pageInfo;
        }
    }
}
