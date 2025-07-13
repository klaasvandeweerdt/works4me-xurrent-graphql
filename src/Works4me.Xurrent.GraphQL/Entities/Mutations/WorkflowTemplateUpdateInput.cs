using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowtemplateupdateinput/">WorkflowTemplateUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTemplateUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _uiExtensionId;
        private WorkflowCategory? _category;
        private string? _workflowManagerId;
        private string? _workflowTypeId;
        private bool? _disabled;
        private string? _instructions;
        private WorkflowJustification? _justification;
        private string? _note;
        private RecurrenceInput? _recurrence;
        private string? _serviceId;
        private string? _subject;
        private Collection<WorkflowTemplateTaskTemplateInput>? _newTaskTemplateRelations;
        private string _id;
        private Collection<string>? _taskTemplateRelationsToDelete;

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
        /// The category that needs to be selected in the Category field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public WorkflowCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [XurrentField("workflowManagerId")]
        public string? WorkflowManagerId
        {
            get => _workflowManagerId;
            set => _workflowManagerId = Set("workflowManagerId", value);
        }

        /// <summary>
        /// The type that needs to be selected in the Type field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("workflowTypeId")]
        public string? WorkflowTypeId
        {
            get => _workflowTypeId;
            set => _workflowTypeId = Set("workflowTypeId", value);
        }

        /// <summary>
        /// Whether the workflow template may not be used to help register new workflows.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The information that needs to be shown when a new workflow is being created based on the template. This field typically contains instructions about how to register the workflow.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions
        {
            get => _instructions;
            set => _instructions = Set("instructions", value);
        }

        /// <summary>
        /// The justification that needs to be selected in the Justification field of a new workflow when it is being created based on the template. This field is required when there are request templates linked to the workflow template.
        /// </summary>
        [XurrentField("justification")]
        public WorkflowJustification? Justification
        {
            get => _justification;
            set => _justification = Set("justification", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Recurrence for the workflow template.
        /// </summary>
        [XurrentField("recurrence")]
        public RecurrenceInput? Recurrence
        {
            get => _recurrence;
            set => _recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// The service that should be selected in the Service field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Short description that needs to be copied to the Subject field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Task template relations of the workflow template.
        /// </summary>
        [XurrentField("newTaskTemplateRelations")]
        public Collection<WorkflowTemplateTaskTemplateInput>? NewTaskTemplateRelations
        {
            get => _newTaskTemplateRelations;
            set => _newTaskTemplateRelations = Set("newTaskTemplateRelations", value);
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
        /// Identifiers of task template relations to remove from the workflow template.
        /// </summary>
        [XurrentField("taskTemplateRelationsToDelete")]
        public Collection<string>? TaskTemplateRelationsToDelete
        {
            get => _taskTemplateRelationsToDelete;
            set => _taskTemplateRelationsToDelete = Set("taskTemplateRelationsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTemplateUpdateInput"/> class without providing the required values.
        /// </summary>
        public WorkflowTemplateUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTemplateUpdateInput"/> class.
        /// </summary>
        public WorkflowTemplateUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
