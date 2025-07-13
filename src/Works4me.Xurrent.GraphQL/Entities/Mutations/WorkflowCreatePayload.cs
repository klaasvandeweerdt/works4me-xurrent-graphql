using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowcreatepayload/">WorkflowCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("workflow", IsDefaultQueryProperty = true)]
        public Workflow? Workflow { get; internal set; }
    }
}
