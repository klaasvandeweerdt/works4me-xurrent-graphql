using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/tasktemplateupdatepayload/">WorkflowTaskTemplateUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTaskTemplateUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("taskTemplate", IsDefaultQueryProperty = true)]
        public WorkflowTaskTemplate? TaskTemplate { get; internal set; }
    }
}
