using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowtemplate/">WorkflowTemplate</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("WorkflowTemplate")]
    public sealed class WorkflowTemplate : IDataItem, IHasAutomationRules, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether Requests and Problems are assigned to the workflow manager when the relations are linked to the workflow.
        /// </summary>
        [XurrentField("assignRelationsToWorkflowManager")]
        public bool? AssignRelationsToWorkflowManager { get; internal set; }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("category")]
        public WorkflowCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the workflow template may not be used to help register new workflows.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The maximum impact level that is selected in the task templates that are a part of the workflow template.
        /// </summary>
        [XurrentField("impact")]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// The information that needs to be shown when a new workflow is being created based on the template. This field typically contains instructions about how to register the workflow.
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
        /// The justification that needs to be selected in the Justification field of a new workflow when it is being created based on the template. This field is required when there are request templates linked to the workflow template.
        /// </summary>
        [XurrentField("justification")]
        public WorkflowJustification? Justification { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("note")]
        public string? Note { get; internal set; }

        [XurrentField("noteAttachments")]
        internal PagedResponse<Attachment>? NoteAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? NoteAttachments { get => NoteAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(NoteAttachmentsCollection.Data); }

        [XurrentField("phases")]
        internal PagedResponse<WorkflowTemplatePhase>? PhasesCollection { get; set; }
        /// <summary>
        /// Phases of the workflow template.
        /// </summary>
        public ReadOnlyDataCollection<WorkflowTemplatePhase>? Phases { get => PhasesCollection?.Data is null ? null : new ReadOnlyDataCollection<WorkflowTemplatePhase>(PhasesCollection.Data); }

        /// <summary>
        /// Whether permissions to complete linked requests are restricted for workflows based on this template.
        /// </summary>
        [XurrentField("preventRequestCompletion")]
        public bool? PreventRequestCompletion { get; internal set; }

        /// <summary>
        /// Recurrency for the workflow template.
        /// </summary>
        [XurrentField("recurrence")]
        public Recurrence? Recurrence { get; internal set; }

        /// <summary>
        /// The service that should be selected in the Service field of a new workflow when it is being created based on the template.
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
        /// Short description that needs to be copied to the Subject field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [XurrentField("taskTemplateRelations")]
        internal PagedResponse<WorkflowTaskTemplateRelation>? TaskTemplateRelationsCollection { get; set; }
        /// <summary>
        /// Task template relations of the workflow template.
        /// </summary>
        public ReadOnlyDataCollection<WorkflowTaskTemplateRelation>? TaskTemplateRelations { get => TaskTemplateRelationsCollection?.Data is null ? null : new ReadOnlyDataCollection<WorkflowTaskTemplateRelation>(TaskTemplateRelationsCollection.Data); }

        /// <summary>
        /// UI extension that is to be added to a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [XurrentField("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// The type that needs to be selected in the Type field of a new workflow when it is being created based on the template.
        /// </summary>
        [XurrentField("workflowType")]
        public WorkflowType? WorkflowType { get; internal set; }

        [XurrentField("workflows")]
        internal PagedResponse<Workflow>? WorkflowsCollection { get; set; }
        /// <summary>
        /// Workflows of the workflow template.
        /// </summary>
        public ReadOnlyDataCollection<Workflow>? Workflows { get => WorkflowsCollection?.Data is null ? null : new ReadOnlyDataCollection<Workflow>(WorkflowsCollection.Data); }

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
            if (data is WorkflowTemplate workflowTemplate)
            {
                AutomationRulesCollection?.Data?.AddRange(workflowTemplate.AutomationRules);
                InstructionsAttachmentsCollection?.Data?.AddRange(workflowTemplate.InstructionsAttachments);
                NoteAttachmentsCollection?.Data?.AddRange(workflowTemplate.NoteAttachments);
                PhasesCollection?.Data?.AddRange(workflowTemplate.Phases);
                TaskTemplateRelationsCollection?.Data?.AddRange(workflowTemplate.TaskTemplateRelations);
                WorkflowsCollection?.Data?.AddRange(workflowTemplate.Workflows);
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

            if (PhasesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PhasesCollection.GetPageInfo("phases", depth))
                    yield return pageInfo;

            if (TaskTemplateRelationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TaskTemplateRelationsCollection.GetPageInfo("taskTemplateRelations", depth))
                    yield return pageInfo;

            if (WorkflowsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in WorkflowsCollection.GetPageInfo("workflows", depth))
                    yield return pageInfo;
        }
    }
}
