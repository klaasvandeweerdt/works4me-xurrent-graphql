using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/team/">Team</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Team")]
    public sealed class Team : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Used to automatically link records to the agile board when they are assigned to the team.
        /// </summary>
        [XurrentField("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// Whether requests are auto-assigned to a team member.
        /// </summary>
        [XurrentField("autoAssign")]
        public bool? AutoAssign { get; internal set; }

        /// <summary>
        /// The person who maintains the information about the configuration items that the team supports.
        /// </summary>
        [XurrentField("configurationManager")]
        public Person? ConfigurationManager { get; internal set; }

        /// <summary>
        /// The current team coordinator for the team. Only members of the team can be selected in this field.
        /// </summary>
        [XurrentField("coordinator")]
        public Person? Coordinator { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [XurrentField("customFields")]
        internal CustomFieldCollection? CustomFieldCollection { get; set; }
        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public IReadOnlyCustomFieldCollection? CustomFields { get => CustomFieldCollection is null ? null : new ReadOnlyCustomFieldCollection(CustomFieldCollection); }

        [XurrentField("customFieldsAttachments")]
        internal PagedResponse<Attachment>? CustomFieldsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CustomFieldsAttachments { get => CustomFieldsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CustomFieldsAttachmentsCollection.Data); }

        /// <summary>
        /// Whether the team may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Used to specify an email address for the team. When an email is sent to this email address, a new request gets generated and assigned to the team.
        /// </summary>
        [XurrentField("inboundEmailLocalPart")]
        public string? InboundEmailLocalPart { get; internal set; }

        /// <summary>
        /// The manager or supervisor of the team. This person is able to maintain the information about the team. The manager of a team does not need to be a member of the team.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        [XurrentField("members")]
        internal PagedResponse<Person>? MembersCollection { get; set; }
        /// <summary>
        /// People linked as a member to the team.
        /// </summary>
        public ReadOnlyDataCollection<Person>? Members { get => MembersCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(MembersCollection.Data); }

        /// <summary>
        /// The name of the team.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// Any additional information about the team that might prove useful.
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
        /// Scrum workspace used by this team to plan their work.
        /// </summary>
        [XurrentField("scrumWorkspace")]
        public ScrumWorkspace? ScrumWorkspace { get; internal set; }

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
        /// The time zone that applies to the selected work hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The calendar that defines the work hours during which the team is available for work on all types of assignments.
        /// </summary>
        [XurrentField("workHours")]
        public Calendar? WorkHours { get; internal set; }

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
            if (data is Team team)
            {
                CustomFieldsAttachmentsCollection?.Data?.AddRange(team.CustomFieldsAttachments);
                MembersCollection?.Data?.AddRange(team.Members);
                RemarksAttachmentsCollection?.Data?.AddRange(team.RemarksAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
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
