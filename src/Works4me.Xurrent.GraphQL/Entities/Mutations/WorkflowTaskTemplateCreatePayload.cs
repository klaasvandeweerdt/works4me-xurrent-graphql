using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/tasktemplatecreatepayload/">WorkflowTaskTemplateCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTaskTemplateCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("taskTemplate", IsDefaultQueryProperty = true)]
        public WorkflowTaskTemplate? TaskTemplate { get; internal set; }
    }
}
