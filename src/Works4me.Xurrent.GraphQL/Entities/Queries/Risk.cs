using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/risk/">Risk</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Risk")]
    public sealed class Risk : IDataItem, IHasLifeCycleState, IHasNotes, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the risk is saved with the status "Closed".
        /// </summary>
        [XurrentField("closedAt")]
        public DateTime? ClosedAt { get; internal set; }

        /// <summary>
        /// The appropriate closure reason for the risk when it has been closed.
        /// </summary>
        [XurrentField("closureReason")]
        public RiskClosureReason? ClosureReason { get; internal set; }

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
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The manager of the risk. This person is able to maintain the information about the risk.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The date by which the risk should have been mitigated.
        /// </summary>
        [XurrentField("mitigationTargetAt")]
#if NET6_0_OR_GREATER
        public DateOnly? MitigationTargetAt { get; internal set; }
#else
        public DateTime? MitigationTargetAt { get; internal set; }
#endif

        [XurrentField("notes")]
        internal PagedResponse<Note>? NotesCollection { get; set; }
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get => NotesCollection?.Data is null ? null : new ReadOnlyDataCollection<Note>(NotesCollection.Data); }

        [XurrentField("organizations")]
        internal PagedResponse<Organization>? OrganizationsCollection { get; set; }
        /// <summary>
        /// Organizations linked to the risk.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Organizations { get => OrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(OrganizationsCollection.Data); }

        [XurrentField("projects")]
        internal PagedResponse<Project>? ProjectsCollection { get; set; }
        /// <summary>
        /// Projects linked to the risk.
        /// </summary>
        public ReadOnlyDataCollection<Project>? Projects { get => ProjectsCollection?.Data is null ? null : new ReadOnlyDataCollection<Project>(ProjectsCollection.Data); }

        /// <summary>
        /// The number of minutes it took to complete this risk, which is calculated as the difference between the <c>createdAt</c> and <c>closedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("riskId")]
        public string? RiskId { get; internal set; }

        [XurrentField("services")]
        internal PagedResponse<Service>? ServicesCollection { get; set; }
        /// <summary>
        /// Services linked to the risk.
        /// </summary>
        public ReadOnlyDataCollection<Service>? Services { get => ServicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Service>(ServicesCollection.Data); }

        /// <summary>
        /// The severity of the risk.
        /// </summary>
        [XurrentField("severity")]
        public string? Severity { get; internal set; }

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
        /// The current status of the risk.
        /// </summary>
        [XurrentField("status")]
        public RiskStatus? Status { get; internal set; }

        /// <summary>
        /// The subject of the risk.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

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
            if (data is Risk risk)
            {
                CustomFieldsAttachmentsCollection?.Data?.AddRange(risk.CustomFieldsAttachments);
                NotesCollection?.Data?.AddRange(risk.Notes);
                OrganizationsCollection?.Data?.AddRange(risk.Organizations);
                ProjectsCollection?.Data?.AddRange(risk.Projects);
                ServicesCollection?.Data?.AddRange(risk.Services);
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

            if (NotesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NotesCollection.GetPageInfo("notes", depth))
                    yield return pageInfo;

            if (OrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OrganizationsCollection.GetPageInfo("organizations", depth))
                    yield return pageInfo;

            if (ProjectsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ProjectsCollection.GetPageInfo("projects", depth))
                    yield return pageInfo;

            if (ServicesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServicesCollection.GetPageInfo("services", depth))
                    yield return pageInfo;
        }
    }
}
