using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/skillpool/">SkillPool</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("SkillPool")]
    public sealed class SkillPool : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The skill pool's estimated total cost per work hour for the service provider organization.
        /// </summary>
        [XurrentField("costPerHour")]
        public decimal? CostPerHour { get; internal set; }

        /// <summary>
        /// The currency of the cost per hour value of this skill pool.
        /// </summary>
        [XurrentField("costPerHourCurrency")]
        public Currency? CostPerHourCurrency { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the skill pool may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        [XurrentField("effortClasses")]
        internal PagedResponse<EffortClass>? EffortClassesCollection { get; set; }
        /// <summary>
        /// Effort classes linked to the skill pool.
        /// </summary>
        public ReadOnlyDataCollection<EffortClass>? EffortClasses { get => EffortClassesCollection?.Data is null ? null : new ReadOnlyDataCollection<EffortClass>(EffortClassesCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The manager or supervisor of the skill pool. This person is able to maintain the information about the skill pool. The manager of a skill pool does not need to be a member of the skill pool.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        [XurrentField("members")]
        internal PagedResponse<Person>? MembersCollection { get; set; }
        /// <summary>
        /// People linked as a member to the skill pool.
        /// </summary>
        public ReadOnlyDataCollection<Person>? Members { get => MembersCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(MembersCollection.Data); }

        /// <summary>
        /// The name of the skill pool.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// Any additional information about the skill pool that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

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
            if (data is SkillPool skillPool)
            {
                EffortClassesCollection?.Data?.AddRange(skillPool.EffortClasses);
                MembersCollection?.Data?.AddRange(skillPool.Members);
                RemarksAttachmentsCollection?.Data?.AddRange(skillPool.RemarksAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (EffortClassesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in EffortClassesCollection.GetPageInfo("effortClasses", depth))
                    yield return pageInfo;

            if (MembersCollection is not null)
                foreach (ExecutionPageInfo pageInfo in MembersCollection.GetPageInfo("members", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;
        }
    }
}
