using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowtemplateupdatepayload/">WorkflowTemplateUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTemplateUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("workflowTemplate", IsDefaultQueryProperty = true)]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }
    }
}
