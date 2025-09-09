using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectupdateinput/">ProjectUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ProjectUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private bool? _budgetAllocated;
        private string? _category;
        private ProjectCompletionReason? _completionReason;
        private decimal? _costOfEffort;
        private decimal? _costOfPurchases;
        private string? _customerId;
        private long? _effort;
        private ProjectJustification? _justification;
        private string? _managerId;
        private string? _note;
        private string? _program;
        private string? _riskLevel;
        private string? _serviceId;
        private ProjectStatus? _status;
        private string? _subject;
        private string? _timeZone;
        private decimal? _value;
        private string? _workHoursId;
        private Collection<string>? _workflowIds;
        private Collection<ProjectPhaseInput>? _newPhases;
        private Collection<string>? _problemIds;
        private Collection<string>? _requestIds;
        private string _id;
        private string? _templateId;
        private Collection<string>? _phasesToDelete;

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
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [XurrentField("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => _customFields;
            set => _customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [XurrentField("customFieldsAttachments")]
        public Collection<AttachmentInput>? CustomFieldsAttachments
        {
            get => _customFieldsAttachments;
            set => _customFieldsAttachments = Set("customFieldsAttachments", value);
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
        /// Whether the project has been approved and no longer needs to be considered for funding by portfolio management.
        /// </summary>
        [XurrentField("budgetAllocated")]
        public bool? BudgetAllocated
        {
            get => _budgetAllocated;
            set => _budgetAllocated = Set("budgetAllocated", value);
        }

        /// <summary>
        /// The category of the project.
        /// </summary>
        [XurrentField("category")]
        public string? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// The appropriate completion reason for the project when it has been completed. It is automatically set to "Complete" when all tasks related to the project have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("completionReason")]
        public ProjectCompletionReason? CompletionReason
        {
            get => _completionReason;
            set => _completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// The estimated cost of the effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [XurrentField("costOfEffort")]
        public decimal? CostOfEffort
        {
            get => _costOfEffort;
            set => _costOfEffort = Set("costOfEffort", value);
        }

        /// <summary>
        /// The estimated cost of all purchases (for equipment, consulting effort, licenses, etc.) needed to implement the project. Recurring costs that will be incurred following the implementation of the project are to be included for the entire ROI calculation period.
        /// </summary>
        [XurrentField("costOfPurchases")]
        public decimal? CostOfPurchases
        {
            get => _costOfPurchases;
            set => _costOfPurchases = Set("costOfPurchases", value);
        }

        /// <summary>
        /// Identifier of the organization for which the project is to be implemented.
        /// </summary>
        [XurrentField("customerId")]
        public string? CustomerId
        {
            get => _customerId;
            set => _customerId = Set("customerId", value);
        }

        /// <summary>
        /// The estimated number of hours of effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [XurrentField("effort")]
        public long? Effort
        {
            get => _effort;
            set => _effort = Set("effort", value);
        }

        /// <summary>
        /// The reason why the project should be considered for implementation.
        /// </summary>
        [XurrentField("justification")]
        public ProjectJustification? Justification
        {
            get => _justification;
            set => _justification = Set("justification", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the implementation of the project.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// High-level description of the project. It is also used to add any information that could prove useful for anyone involved in the project, including the people whose approval is needed and the people who are helping to implement it.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Used to indicate which program the project is a part of.
        /// </summary>
        [XurrentField("program")]
        public string? Program
        {
            get => _program;
            set => _program = Set("program", value);
        }

        /// <summary>
        /// The risk level of the project.
        /// </summary>
        [XurrentField("riskLevel")]
        public string? RiskLevel
        {
            get => _riskLevel;
            set => _riskLevel = Set("riskLevel", value);
        }

        /// <summary>
        /// Identifier of the service for which the project will be implemented.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Automatically set based on the status of the project's tasks.
        /// </summary>
        [XurrentField("status")]
        public ProjectStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the project.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// The time zone that applies to the selected work hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// The estimated financial value that the implementation of the project will deliver for the entire ROI calculation period.
        /// </summary>
        [XurrentField("value")]
        public decimal? Value
        {
            get => _value;
            set => _value = Set("value", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the work hours that are to be used to calculate the anticipated assignment and completion target for the tasks of the project.
        /// </summary>
        [XurrentField("workHoursId")]
        public string? WorkHoursId
        {
            get => _workHoursId;
            set => _workHoursId = Set("workHoursId", value);
        }

        /// <summary>
        /// Identifiers of the workflows of the project.
        /// </summary>
        [XurrentField("workflowIds")]
        public Collection<string>? WorkflowIds
        {
            get => _workflowIds;
            set => _workflowIds = Set("workflowIds", value);
        }

        /// <summary>
        /// Phases of the project.
        /// </summary>
        [XurrentField("newPhases")]
        public Collection<ProjectPhaseInput>? NewPhases
        {
            get => _newPhases;
            set => _newPhases = Set("newPhases", value);
        }

        /// <summary>
        /// Identifiers of the problems of the project.
        /// </summary>
        [XurrentField("problemIds")]
        public Collection<string>? ProblemIds
        {
            get => _problemIds;
            set => _problemIds = Set("problemIds", value);
        }

        /// <summary>
        /// Identifiers of the requests of the project.
        /// </summary>
        [XurrentField("requestIds")]
        public Collection<string>? RequestIds
        {
            get => _requestIds;
            set => _requestIds = Set("requestIds", value);
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
        /// Identifier of the project template to apply to the project.
        /// </summary>
        [XurrentField("templateId")]
        public string? TemplateId
        {
            get => _templateId;
            set => _templateId = Set("templateId", value);
        }

        /// <summary>
        /// Phases to remove from the project.
        /// </summary>
        [XurrentField("phasesToDelete")]
        public Collection<string>? PhasesToDelete
        {
            get => _phasesToDelete;
            set => _phasesToDelete = Set("phasesToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateInput"/> class without providing the required values.
        /// </summary>
        public ProjectUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateInput"/> class.
        /// </summary>
        public ProjectUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
