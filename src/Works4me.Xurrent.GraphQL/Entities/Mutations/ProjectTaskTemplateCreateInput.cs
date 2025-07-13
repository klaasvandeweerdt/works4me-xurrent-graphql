using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttasktemplatecreateinput/">ProjectTaskTemplateCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTaskTemplateCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _uiExtensionId;
        private bool? _assignToProjectManager;
        private bool? _assignToRequester;
        private bool? _assignToRequesterBusinessUnitManager;
        private bool? _assignToRequesterManager;
        private bool? _assignToServiceOwner;
        private bool? _copyNotesToProject;
        private bool? _disabled;
        private string? _effortClassId;
        private string? _instructions;
        private string? _note;
        private string? _pdfDesignId;
        private long? _plannedEffort;
        private long? _plannedEffortProjectManager;
        private long? _plannedEffortRequester;
        private long? _plannedEffortRequesterBusinessUnitManager;
        private long? _plannedEffortRequesterManager;
        private long? _plannedEffortServiceOwner;
        private long? _requiredApprovals;
        private string? _skillPoolId;
        private string? _supplierId;
        private string? _teamId;
        private bool? _workHoursAre24x7;
        private string? _agileBoardId;
        private string? _agileBoardColumnId;
        private Collection<ProjectTaskTemplateAssignmentInput>? _newAssignments;
        private ProjectTaskCategory _category;
        private long _plannedDuration;
        private string _subject;

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
        /// Whether the project manager is to be selected in the Assignees field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("assignToProjectManager")]
        public bool? AssignToProjectManager
        {
            get => _assignToProjectManager;
            set => _assignToProjectManager = Set("assignToProjectManager", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [XurrentField("assignToRequester")]
        public bool? AssignToRequester
        {
            get => _assignToRequester;
            set => _assignToRequester = Set("assignToRequester", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [XurrentField("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager
        {
            get => _assignToRequesterBusinessUnitManager;
            set => _assignToRequesterBusinessUnitManager = Set("assignToRequesterBusinessUnitManager", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the manager of the project's requester.
        /// </summary>
        [XurrentField("assignToRequesterManager")]
        public bool? AssignToRequesterManager
        {
            get => _assignToRequesterManager;
            set => _assignToRequesterManager = Set("assignToRequesterManager", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the project that the new project task is a part of.
        /// </summary>
        [XurrentField("assignToServiceOwner")]
        public bool? AssignToServiceOwner
        {
            get => _assignToServiceOwner;
            set => _assignToServiceOwner = Set("assignToServiceOwner", value);
        }

        /// <summary>
        /// Whether the Copy note to project box of project tasks that were created based on the template needs to be checked by default. (The Copy notes to project checkbox is called "Copy notes to project by default" when the project task template is in Edit mode.).
        /// </summary>
        [XurrentField("copyNotesToProject")]
        public bool? CopyNotesToProject
        {
            get => _copyNotesToProject;
            set => _copyNotesToProject = Set("copyNotesToProject", value);
        }

        /// <summary>
        /// Whether the project task template may not be used to help register new project tasks.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a project task created based on the template.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions
        {
            get => _instructions;
            set => _instructions = Set("instructions", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the PDF design that needs to be copied to the PDF design field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("pdfDesignId")]
        public string? PdfDesignId
        {
            get => _pdfDesignId;
            set => _pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the team is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort
        {
            get => _plannedEffort;
            set => _plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the project manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortProjectManager")]
        public long? PlannedEffortProjectManager
        {
            get => _plannedEffortProjectManager;
            set => _plannedEffortProjectManager = Set("plannedEffortProjectManager", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the requester is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequester")]
        public long? PlannedEffortRequester
        {
            get => _plannedEffortRequester;
            set => _plannedEffortRequester = Set("plannedEffortRequester", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the requester's business unit manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager
        {
            get => _plannedEffortRequesterBusinessUnitManager;
            set => _plannedEffortRequesterBusinessUnitManager = Set("plannedEffortRequesterBusinessUnitManager", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the requester's manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager
        {
            get => _plannedEffortRequesterManager;
            set => _plannedEffortRequesterManager = Set("plannedEffortRequesterManager", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the service owner is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner
        {
            get => _plannedEffortServiceOwner;
            set => _plannedEffortServiceOwner = Set("plannedEffortServiceOwner", value);
        }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval project task when it is being created based on the template.
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => _requiredApprovals;
            set => _requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Identifier of the skill pool that should be selected in the Skill pool field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("skillPoolId")]
        public string? SkillPoolId
        {
            get => _skillPoolId;
            set => _skillPoolId = Set("skillPoolId", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that should be selected in the Supplier field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the Team that should be selected in the Team field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// When set to true, the completion target of project tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => _workHoursAre24x7;
            set => _workHoursAre24x7 = Set("workHoursAre24x7", value);
        }

        /// <summary>
        /// Identifier of the Agile board the project task will be placed on.
        /// </summary>
        [XurrentField("agileBoardId")]
        public string? AgileBoardId
        {
            get => _agileBoardId;
            set => _agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Identifier of the Agile board column the project task will be placed in.
        /// </summary>
        [XurrentField("agileBoardColumnId")]
        public string? AgileBoardColumnId
        {
            get => _agileBoardColumnId;
            set => _agileBoardColumnId = Set("agileBoardColumnId", value);
        }

        /// <summary>
        /// Assignments of the project task template.
        /// </summary>
        [XurrentField("newAssignments")]
        public Collection<ProjectTaskTemplateAssignmentInput>? NewAssignments
        {
            get => _newAssignments;
            set => _newAssignments = Set("newAssignments", value);
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public ProjectTaskCategory Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that should be entered in the Planned duration field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long PlannedDuration
        {
            get => _plannedDuration;
            set => _plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("subject")]
        public string Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskTemplateCreateInput"/> class without providing the required values.
        /// </summary>
        public ProjectTaskTemplateCreateInput()
        {
            _category = default;
            _plannedDuration = default;
            _subject = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskTemplateCreateInput"/> class.
        /// </summary>
        public ProjectTaskTemplateCreateInput(ProjectTaskCategory category, long plannedDuration, string subject)
        {
            _category = Set("category", category);
            _plannedDuration = Set("plannedDuration", plannedDuration);
            _subject = Set("subject", subject);
        }
    }
}
