using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttasktemplate/">ProjectTaskTemplate</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProjectTaskTemplate")]
    public sealed class ProjectTaskTemplate : IDataItem, IHasAutomationRules, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Agile board the project task will be placed on.
        /// </summary>
        [XurrentField("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// Agile board column the project task will be placed in.
        /// </summary>
        [XurrentField("agileBoardColumn")]
        public AgileBoardColumn? AgileBoardColumn { get; internal set; }

        /// <summary>
        /// Whether the project manager is to be selected in the Assignees field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("assignToProjectManager")]
        public bool? AssignToProjectManager { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [XurrentField("assignToRequester")]
        public bool? AssignToRequester { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [XurrentField("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the manager of the project's requester.
        /// </summary>
        [XurrentField("assignToRequesterManager")]
        public bool? AssignToRequesterManager { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the project that the new project task is a part of.
        /// </summary>
        [XurrentField("assignToServiceOwner")]
        public bool? AssignToServiceOwner { get; internal set; }

        [XurrentField("assignments")]
        internal PagedResponse<ProjectTaskTemplateAssignment>? AssignmentsCollection { get; set; }
        /// <summary>
        /// Assignments of the project task template.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTaskTemplateAssignment>? Assignments { get => AssignmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTaskTemplateAssignment>(AssignmentsCollection.Data); }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public ProjectTaskCategory? Category { get; internal set; }

        /// <summary>
        /// Whether the Copy note to project box of project tasks that were created based on the template needs to be checked by default. (The Copy notes to project checkbox is called "Copy notes to project by default" when the project task template is in Edit mode.).
        /// </summary>
        [XurrentField("copyNotesToProject")]
        public bool? CopyNotesToProject { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the project task template may not be used to help register new project tasks.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a project task created based on the template.
        /// </summary>
        [XurrentField("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new project task when it is being created based on the template.
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
        /// The information that needs to be copied to the Note field of a new project task when it is being created based on the template.
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
        public ProjectTaskNoteBehavior? NoteBehavior { get; internal set; }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that should be entered in the Planned duration field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the team is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the project manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortProjectManager")]
        public long? PlannedEffortProjectManager { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the requester is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequester")]
        public long? PlannedEffortRequester { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the requester's business unit manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the requester's manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the service owner is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [XurrentField("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner { get; internal set; }

        [XurrentField("projectTemplates")]
        internal PagedResponse<ProjectTemplate>? ProjectTemplatesCollection { get; set; }
        /// <summary>
        /// Project templates that include the project task template.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTemplate>? ProjectTemplates { get => ProjectTemplatesCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTemplate>(ProjectTemplatesCollection.Data); }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval project task when it is being created based on the template.
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new project task when it is being created based on the template.
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
        /// A short description that needs to be copied to the Subject field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        [XurrentField("tasks")]
        internal PagedResponse<ProjectTask>? TasksCollection { get; set; }
        /// <summary>
        /// Project tasks created using the project task template.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTask>? Tasks { get => TasksCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTask>(TasksCollection.Data); }

        /// <summary>
        /// The Team that should be selected in the Team field of a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// UI extension that is to be added to a new project task when it is being created based on the template.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// When set to true, the completion target of project tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

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
            if (data is ProjectTaskTemplate projectTaskTemplate)
            {
                AssignmentsCollection?.Data?.AddRange(projectTaskTemplate.Assignments);
                AutomationRulesCollection?.Data?.AddRange(projectTaskTemplate.AutomationRules);
                InstructionsAttachmentsCollection?.Data?.AddRange(projectTaskTemplate.InstructionsAttachments);
                NoteAttachmentsCollection?.Data?.AddRange(projectTaskTemplate.NoteAttachments);
                ProjectTemplatesCollection?.Data?.AddRange(projectTaskTemplate.ProjectTemplates);
                TasksCollection?.Data?.AddRange(projectTaskTemplate.Tasks);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AssignmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AssignmentsCollection.GetPageInfo("assignments", depth))
                    yield return pageInfo;

            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (InstructionsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InstructionsAttachmentsCollection.GetPageInfo("instructionsAttachments", depth))
                    yield return pageInfo;

            if (NoteAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NoteAttachmentsCollection.GetPageInfo("noteAttachments", depth))
                    yield return pageInfo;

            if (ProjectTemplatesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ProjectTemplatesCollection.GetPageInfo("projectTemplates", depth))
                    yield return pageInfo;

            if (TasksCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TasksCollection.GetPageInfo("tasks", depth))
                    yield return pageInfo;
        }
    }
}
