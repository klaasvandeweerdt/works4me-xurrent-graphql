using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requesttemplate/">RequestTemplate</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("RequestTemplate")]
    public sealed class RequestTemplate : IDataItem, IHasAutomationRules, IHasTranslations, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// After selecting the request template in Self Service, the user needs to be able to select a configuration item in the Asset field.
        /// </summary>
        [XurrentField("assetSelection")]
        public bool? AssetSelection { get; internal set; }

        /// <summary>
        /// Whether the request will be assigned to the provided Team after the workflow is completed. When <c>false</c> the request will be completed after the workflow completes.
        /// </summary>
        [XurrentField("assignAfterWorkflowCompletion")]
        public bool? AssignAfterWorkflowCompletion { get; internal set; }

        /// <summary>
        /// Whether the person who is registering a new request based on the template is selected in its Member field.
        /// </summary>
        [XurrentField("assignToSelf")]
        public bool? AssignToSelf { get; internal set; }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public RequestCategory? Category { get; internal set; }

        /// <summary>
        /// The completion reason that needs to be selected in the Completion reason field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("completionReason")]
        public RequestCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// The CI that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("configurationItem")]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// Whether the subject of the request template needs to become the subject of a request when the template is applied, provided that the Subject field of this request is empty.
        /// </summary>
        [XurrentField("copySubjectToRequests")]
        public bool? CopySubjectToRequests { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Used to enter the number of minutes within which requests that are based on the request template are to be resolved.
        /// </summary>
        [XurrentField("desiredCompletion")]
        public long? DesiredCompletion { get; internal set; }

        /// <summary>
        /// Whether the request template may not be used to help register new requests.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        [XurrentField("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Whether the request template is shown to end users in Self Service.
        /// </summary>
        [XurrentField("endUsers")]
        public bool? EndUsers { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("impact")]
        public RequestImpact? Impact { get; internal set; }

        /// <summary>
        /// Instructions for the support staff who will work on requests that are based on the template.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions { get; internal set; }

        [XurrentField("instructionsAttachments")]
        internal PagedResponse<Attachment>? InstructionsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? InstructionsAttachments { get => InstructionsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(InstructionsAttachmentsCollection.Data); }

        /// <summary>
        /// A comma-separated list of words that can be used to find the request template using search.
        /// </summary>
        [XurrentField("keywords")]
        public string? Keywords { get; internal set; }

        /// <summary>
        /// Used to select the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("note")]
        public string? Note { get; internal set; }

        [XurrentField("noteAttachments")]
        internal PagedResponse<Attachment>? NoteAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? NoteAttachments { get => NoteAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(NoteAttachmentsCollection.Data); }

        [XurrentField("organizations")]
        internal PagedResponse<Organization>? OrganizationsCollection { get; set; }
        /// <summary>
        /// Organizations related to the order request template.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Organizations { get => OrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(OrganizationsCollection.Data); }

        /// <summary>
        /// The number of minutes that is expected to be spent working on a request that is created based on the template.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The information that needs to be displayed after the template has been applied to a new or existing request. This field typically contains step-by-step instructions about how to complete the registration of a request that is based on the template.
        /// </summary>
        [XurrentField("registrationHints")]
        public string? RegistrationHints { get; internal set; }

        [XurrentField("registrationHintsAttachments")]
        internal PagedResponse<Attachment>? RegistrationHintsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Registration hints field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RegistrationHintsAttachments { get => RegistrationHintsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RegistrationHintsAttachmentsCollection.Data); }

        [XurrentField("requests")]
        internal PagedResponse<Request>? RequestsCollection { get; set; }
        /// <summary>
        /// Requests created using the request template.
        /// </summary>
        public ReadOnlyDataCollection<Request>? Requests { get => RequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<Request>(RequestsCollection.Data); }

        [XurrentField("reservationOfferings")]
        internal PagedResponse<ReservationOffering>? ReservationOfferingsCollection { get; set; }
        /// <summary>
        /// Reservation offerings related to the request template.
        /// </summary>
        public ReadOnlyDataCollection<ReservationOffering>? ReservationOfferings { get => ReservationOfferingsCollection?.Data is null ? null : new ReadOnlyDataCollection<ReservationOffering>(ReservationOfferingsCollection.Data); }

        /// <summary>
        /// The service for which the request template is made available.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

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
        /// Whether the request template is shown to Specialists.
        /// </summary>
        [XurrentField("specialists")]
        public bool? Specialists { get; internal set; }

        [XurrentField("standardServiceRequests")]
        internal PagedResponse<StandardServiceRequest>? StandardServiceRequestsCollection { get; set; }
        /// <summary>
        /// Standard service requests related to the request template.
        /// </summary>
        public ReadOnlyDataCollection<StandardServiceRequest>? StandardServiceRequests { get => StandardServiceRequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<StandardServiceRequest>(StandardServiceRequestsCollection.Data); }

        /// <summary>
        /// Used to select the status value that needs to be selected in the Status field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("status")]
        public RequestStatus? Status { get; internal set; }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// Used to select the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        [XurrentField("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// The team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The time zone that applies to the selected support hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        [XurrentField("translations")]
        internal PagedResponse<Translation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Translation>(TranslationsCollection.Data); }

        /// <summary>
        /// UI extension that is to be added to a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether a new request that is created based on the template is to be marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// Used to relate a Workflow Manager to the request template. _Required_ when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        [XurrentField("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// Used to relate a Workflow Template to the request template. _Required_ when the _Status_ is set to _Workflow Pending_.
        /// </summary>
        [XurrentField("workflowTemplate")]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

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
            if (data is RequestTemplate requestTemplate)
            {
                AutomationRulesCollection?.Data?.AddRange(requestTemplate.AutomationRules);
                InstructionsAttachmentsCollection?.Data?.AddRange(requestTemplate.InstructionsAttachments);
                NoteAttachmentsCollection?.Data?.AddRange(requestTemplate.NoteAttachments);
                OrganizationsCollection?.Data?.AddRange(requestTemplate.Organizations);
                RegistrationHintsAttachmentsCollection?.Data?.AddRange(requestTemplate.RegistrationHintsAttachments);
                RequestsCollection?.Data?.AddRange(requestTemplate.Requests);
                ReservationOfferingsCollection?.Data?.AddRange(requestTemplate.ReservationOfferings);
                StandardServiceRequestsCollection?.Data?.AddRange(requestTemplate.StandardServiceRequests);
                TranslationsCollection?.Data?.AddRange(requestTemplate.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (InstructionsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InstructionsAttachmentsCollection.GetPageInfo("instructionsAttachments", depth))
                    yield return pageInfo;

            if (NoteAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NoteAttachmentsCollection.GetPageInfo("noteAttachments", depth))
                    yield return pageInfo;

            if (OrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OrganizationsCollection.GetPageInfo("organizations", depth))
                    yield return pageInfo;

            if (RegistrationHintsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RegistrationHintsAttachmentsCollection.GetPageInfo("registrationHintsAttachments", depth))
                    yield return pageInfo;

            if (RequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RequestsCollection.GetPageInfo("requests", depth))
                    yield return pageInfo;

            if (ReservationOfferingsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ReservationOfferingsCollection.GetPageInfo("reservationOfferings", depth))
                    yield return pageInfo;

            if (StandardServiceRequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in StandardServiceRequestsCollection.GetPageInfo("standardServiceRequests", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
