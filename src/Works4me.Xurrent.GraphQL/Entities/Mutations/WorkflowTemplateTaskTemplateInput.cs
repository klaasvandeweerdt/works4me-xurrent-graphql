using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowtemplatetasktemplateinput/">WorkflowTemplateTaskTemplateInput</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTemplateTaskTemplateInput : PropertyChangeSet
    {
        private string? _id;
        private string? _taskTemplateId;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Identifier of task template related to the workflow template.
        /// </summary>
        [XurrentField("taskTemplateId")]
        public string? TaskTemplateId
        {
            get => _taskTemplateId;
            set => _taskTemplateId = Set("taskTemplateId", value);
        }
    }
}
