using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/tasktemplate/">WorkflowTaskTemplate</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("TaskTemplate")]
    public sealed class WorkflowTaskTemplate : IDataItem, IHasAutomationRules, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("approvals")]
        internal PagedResponse<TaskTemplateApproval>? ApprovalsCollection { get; set; }
        /// <summary>
        /// Approvals of the task template.
        /// </summary>
        public ReadOnlyDataCollection<TaskTemplateApproval>? Approvals { get => ApprovalsCollection?.Data is null ? null : new ReadOnlyDataCollection<TaskTemplateApproval>(ApprovalsCollection.Data); }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the workflow is being generated.
        /// </summary>
        [XurrentField("assignToRequester")]
        public bool? AssignToRequester { get; internal set; }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the workflow is being generated.
        /// </summary>
        [XurrentField("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// Whether the manager of the requester of the first related request is to be selected in the Approver field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("assignToRequesterManager")]
        public bool? AssignToRequesterManager { get; internal set; }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the workflow that the new task is a part of.
        /// </summary>
        [XurrentField("assignToServiceOwner")]
        public bool? AssignToServiceOwner { get; internal set; }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the workflow to which the task belongs.
        /// </summary>
        [XurrentField("assignToWorkflowManager")]
        public bool? AssignToWorkflowManager { get; internal set; }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public TaskCategory? Category { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items of the task template.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

        /// <summary>
        /// Whether the Copy note to workflow box of tasks that were created based on the template needs to be checked by default. (The Copy notes to workflow checkbox is called "Copy notes to workflow by default" when the task template is in Edit mode.).
        /// </summary>
        [XurrentField("copyNotesToWorkflow")]
        public bool? CopyNotesToWorkflow { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the task template may not be used to help register new tasks.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a task created based on the template.
        /// </summary>
        [XurrentField("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("impact")]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new task when it is being created based on the template.
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
        /// The person who should be selected in the Member field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("note")]
        public string? Note { get; internal set; }

        [XurrentField("noteAttachments")]
        internal PagedResponse<Attachment>? NoteAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? NoteAttachments { get => NoteAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(NoteAttachmentsCollection.Data); }

        /// <summary>
        /// Influences the behavior of the note field on completion or approval.
        /// </summary>
        [XurrentField("noteBehavior")]
        public TaskNoteBehavior? NoteBehavior { get; internal set; }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// The number of minutes that should be entered in the Planned duration field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// The number of minutes the member is expected to spend working on a task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The number of minutes the person, who is selected in the Requested for field of the first related request, is expected to spend working on a task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequester")]
        public long? PlannedEffortRequester { get; internal set; }

        /// <summary>
        /// The number of minutes the business unit manager of the requester of the first related request is expected to spend working on a task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// The number of minutes the manager of the requester of the first related request is expected to spend working on a task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager { get; internal set; }

        /// <summary>
        /// The number of minutes the owner of the service of the related to the workflow is expected to spend working on a task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner { get; internal set; }

        /// <summary>
        /// The number of minutes the workflow manager is expected to spend working on a task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortWorkflowManager")]
        public long? PlannedEffortWorkflowManager { get; internal set; }

        /// <summary>
        /// Whether the provider indicates not to be accountable for the affected SLAs linked to the requests that are linked to the workflow of a task that was created based on the template.
        /// </summary>
        [XurrentField("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// The service instance that should be selected in the Request service instance field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("requestServiceInstance")]
        public ServiceInstance? RequestServiceInstance { get; internal set; }

        /// <summary>
        /// The request template that should be selected in the Request template field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("requestTemplate")]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval task when it is being created based on the template.
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// Service instances of the task template.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ServiceInstancesCollection.Data); }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("skillPool")]
        public SkillPool? SkillPool { get; internal set; }

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
        /// A short description that needs to be copied to the Subject field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        [XurrentField("tasks")]
        internal PagedResponse<WorkflowTask>? TasksCollection { get; set; }
        /// <summary>
        /// Tasks created using the task template.
        /// </summary>
        public ReadOnlyDataCollection<WorkflowTask>? Tasks { get => TasksCollection?.Data is null ? null : new ReadOnlyDataCollection<WorkflowTask>(TasksCollection.Data); }

        /// <summary>
        /// The team that should be selected in the Team field of a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// UI extension that is to be added to a new task when it is being created based on the template.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether a new task that is created based on the template is to be marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// Whether the completion target of tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        [XurrentField("workflowTemplates")]
        internal PagedResponse<WorkflowTemplate>? WorkflowTemplatesCollection { get; set; }
        /// <summary>
        /// Workflow templates that include the task template.
        /// </summary>
        public ReadOnlyDataCollection<WorkflowTemplate>? WorkflowTemplates { get => WorkflowTemplatesCollection?.Data is null ? null : new ReadOnlyDataCollection<WorkflowTemplate>(WorkflowTemplatesCollection.Data); }

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
            if (data is WorkflowTaskTemplate workflowTaskTemplate)
            {
                ApprovalsCollection?.Data?.AddRange(workflowTaskTemplate.Approvals);
                AutomationRulesCollection?.Data?.AddRange(workflowTaskTemplate.AutomationRules);
                ConfigurationItemsCollection?.Data?.AddRange(workflowTaskTemplate.ConfigurationItems);
                InstructionsAttachmentsCollection?.Data?.AddRange(workflowTaskTemplate.InstructionsAttachments);
                NoteAttachmentsCollection?.Data?.AddRange(workflowTaskTemplate.NoteAttachments);
                ServiceInstancesCollection?.Data?.AddRange(workflowTaskTemplate.ServiceInstances);
                TasksCollection?.Data?.AddRange(workflowTaskTemplate.Tasks);
                WorkflowTemplatesCollection?.Data?.AddRange(workflowTaskTemplate.WorkflowTemplates);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ApprovalsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ApprovalsCollection.GetPageInfo("approvals", depth))
                    yield return pageInfo;

            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (InstructionsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InstructionsAttachmentsCollection.GetPageInfo("instructionsAttachments", depth))
                    yield return pageInfo;

            if (NoteAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NoteAttachmentsCollection.GetPageInfo("noteAttachments", depth))
                    yield return pageInfo;

            if (ServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceInstancesCollection.GetPageInfo("serviceInstances", depth))
                    yield return pageInfo;

            if (TasksCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TasksCollection.GetPageInfo("tasks", depth))
                    yield return pageInfo;

            if (WorkflowTemplatesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in WorkflowTemplatesCollection.GetPageInfo("workflowTemplates", depth))
                    yield return pageInfo;
        }
    }
}
