using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowcreateinput/">WorkflowCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private WorkflowCategory? _category;
        private string? _workflowType;
        private WorkflowCompletionReason? _completionReason;
        private WorkflowJustification? _justification;
        private string? _managerId;
        private string? _note;
        private string? _projectId;
        private string? _releaseId;
        private string? _serviceId;
        private DateTime? _startAt;
        private WorkflowStatus? _status;
        private string? _subject;
        private string? _templateId;
        private Collection<string>? _requestIds;
        private Collection<string>? _problemIds;

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
        /// The category of the workflow.
        /// </summary>
        [XurrentField("category")]
        public WorkflowCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Used to indicate whether the workflow needs to be implemented following the procedure steps for application changes or for infrastructure changes.
        /// </summary>
        [XurrentField("workflowType")]
        public string? WorkflowType
        {
            get => _workflowType;
            set => _workflowType = Set("workflowType", value);
        }

        /// <summary>
        /// Used to select the appropriate completion reason for the workflow when it has been completed. It is automatically set to "Complete" when all tasks related to the workflow have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("completionReason")]
        public WorkflowCompletionReason? CompletionReason
        {
            get => _completionReason;
            set => _completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// The reason why the change was requested.
        /// </summary>
        [XurrentField("justification")]
        public WorkflowJustification? Justification
        {
            get => _justification;
            set => _justification = Set("justification", value);
        }

        /// <summary>
        /// Who is responsible for coordinating the implementation of the workflow. If a manager is not specified for a new workflow, the API user is selected in the Manager field by default.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// High-level description of the result that should be accomplished by the implementation of the workflow. It is also used to add any information that could prove useful for anyone affected by the workflow, including the people whose approval is needed and the specialists who are helping to implement it.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Linked project.
        /// </summary>
        [XurrentField("projectId")]
        public string? ProjectId
        {
            get => _projectId;
            set => _projectId = Set("projectId", value);
        }

        /// <summary>
        /// The release that the workflow is a part of.
        /// </summary>
        [XurrentField("releaseId")]
        public string? ReleaseId
        {
            get => _releaseId;
            set => _releaseId = Set("releaseId", value);
        }

        /// <summary>
        /// The service that will directly be affected by the workflow implementation, or in case of an emergency change, the service that was directly affected by the workflow implementation.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// The date and time at which the Status field of the first tasks of the workflow will automatically be set to "Assigned".
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// Automatically set based on the status of the workflow's tasks.
        /// </summary>
        [XurrentField("status")]
        public WorkflowStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the workflow.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// The workflow template that was used to register the workflow.
        /// </summary>
        [XurrentField("templateId")]
        public string? TemplateId
        {
            get => _templateId;
            set => _templateId = Set("templateId", value);
        }

        /// <summary>
        /// Identifiers of all requests linked to this workflow.
        /// </summary>
        [XurrentField("requestIds")]
        public Collection<string>? RequestIds
        {
            get => _requestIds;
            set => _requestIds = Set("requestIds", value);
        }

        /// <summary>
        /// Identifiers of all problems linked of this workflow.
        /// </summary>
        [XurrentField("problemIds")]
        public Collection<string>? ProblemIds
        {
            get => _problemIds;
            set => _problemIds = Set("problemIds", value);
        }
    }
}
