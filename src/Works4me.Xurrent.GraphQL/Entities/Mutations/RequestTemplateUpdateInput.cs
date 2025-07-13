using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requesttemplateupdateinput/">RequestTemplateUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class RequestTemplateUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _uiExtensionId;
        private bool? _assetSelection;
        private bool? _assignToSelf;
        private RequestCategory? _category;
        private string? _workflowManagerId;
        private string? _workflowTemplateId;
        private string? _configurationItemId;
        private RequestCompletionReason? _completionReason;
        private bool? _copySubjectToRequests;
        private long? _desiredCompletion;
        private bool? _disabled;
        private string? _effortClassId;
        private bool? _endUsers;
        private RequestImpact? _impact;
        private string? _instructions;
        private string? _keywords;
        private string? _memberId;
        private string? _note;
        private string? _registrationHints;
        private string? _serviceId;
        private bool? _specialists;
        private RequestStatus? _status;
        private string? _subject;
        private string? _supplierId;
        private string? _supportHoursId;
        private string? _teamId;
        private string? _timeZone;
        private bool? _urgent;
        private Collection<string>? _reservationOfferingIds;
        private string _id;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// After selecting the request template in Self Service, the user needs to be able to select a configuration item in the Asset field.
        /// </summary>
        [XurrentField("assetSelection")]
        public bool? AssetSelection
        {
            get => _assetSelection;
            set => _assetSelection = Set("assetSelection", value);
        }

        /// <summary>
        /// Whether the person who is registering a new request based on the template is selected in its Member field.
        /// </summary>
        [XurrentField("assignToSelf")]
        public bool? AssignToSelf
        {
            get => _assignToSelf;
            set => _assignToSelf = Set("assignToSelf", value);
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public RequestCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Identifier of the Workflow Manager linked to the request template. _Required_ when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        [XurrentField("workflowManagerId")]
        public string? WorkflowManagerId
        {
            get => _workflowManagerId;
            set => _workflowManagerId = Set("workflowManagerId", value);
        }

        /// <summary>
        /// Identifier of the Workflow Template related to the request template. _Required_ when the _Status_ is set to _Workflow Pending_.
        /// </summary>
        [XurrentField("workflowTemplateId")]
        public string? WorkflowTemplateId
        {
            get => _workflowTemplateId;
            set => _workflowTemplateId = Set("workflowTemplateId", value);
        }

        /// <summary>
        /// Identifier of the CI that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("configurationItemId")]
        public string? ConfigurationItemId
        {
            get => _configurationItemId;
            set => _configurationItemId = Set("configurationItemId", value);
        }

        /// <summary>
        /// The completion reason that needs to be selected in the Completion reason field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("completionReason")]
        public RequestCompletionReason? CompletionReason
        {
            get => _completionReason;
            set => _completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// Whether the subject of the request template needs to become the subject of a request when the template is applied, provided that the Subject field of this request is empty.
        /// </summary>
        [XurrentField("copySubjectToRequests")]
        public bool? CopySubjectToRequests
        {
            get => _copySubjectToRequests;
            set => _copySubjectToRequests = Set("copySubjectToRequests", value);
        }

        /// <summary>
        /// Used to enter the number of minutes within which requests that are based on the request template are to be resolved.
        /// </summary>
        [XurrentField("desiredCompletion")]
        public long? DesiredCompletion
        {
            get => _desiredCompletion;
            set => _desiredCompletion = Set("desiredCompletion", value);
        }

        /// <summary>
        /// Whether the request template may not be used to help register new requests.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Whether the request template is shown to end users in Self Service.
        /// </summary>
        [XurrentField("endUsers")]
        public bool? EndUsers
        {
            get => _endUsers;
            set => _endUsers = Set("endUsers", value);
        }

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("impact")]
        public RequestImpact? Impact
        {
            get => _impact;
            set => _impact = Set("impact", value);
        }

        /// <summary>
        /// Instructions for the support staff who will work on requests that are based on the template.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions
        {
            get => _instructions;
            set => _instructions = Set("instructions", value);
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the request template using search.
        /// </summary>
        [XurrentField("keywords")]
        public string? Keywords
        {
            get => _keywords;
            set => _keywords = Set("keywords", value);
        }

        /// <summary>
        /// Identifier of the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("memberId")]
        public string? MemberId
        {
            get => _memberId;
            set => _memberId = Set("memberId", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// The information that needs to be displayed after the template has been applied to a new or existing request. This field typically contains step-by-step instructions about how to complete the registration of a request that is based on the template.
        /// </summary>
        [XurrentField("registrationHints")]
        public string? RegistrationHints
        {
            get => _registrationHints;
            set => _registrationHints = Set("registrationHints", value);
        }

        /// <summary>
        /// Identifier of the service for which the request template is made available.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Whether the request template is shown to Specialists.
        /// </summary>
        [XurrentField("specialists")]
        public bool? Specialists
        {
            get => _specialists;
            set => _specialists = Set("specialists", value);
        }

        /// <summary>
        /// Used to select the status value that needs to be selected in the Status field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("status")]
        public RequestStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        [XurrentField("supportHoursId")]
        public string? SupportHoursId
        {
            get => _supportHoursId;
            set => _supportHoursId = Set("supportHoursId", value);
        }

        /// <summary>
        /// Identifier of the team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// The time zone that applies to the selected support hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Whether a new request that is created based on the template is to be marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent
        {
            get => _urgent;
            set => _urgent = Set("urgent", value);
        }

        /// <summary>
        /// Identifiers of reservation offerings related to the request template.
        /// </summary>
        [XurrentField("reservationOfferingIds")]
        public Collection<string>? ReservationOfferingIds
        {
            get => _reservationOfferingIds;
            set => _reservationOfferingIds = Set("reservationOfferingIds", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTemplateUpdateInput"/> class without providing the required values.
        /// </summary>
        public RequestTemplateUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTemplateUpdateInput"/> class.
        /// </summary>
        public RequestTemplateUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
