using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowtypeupdatepayload/">WorkflowTypeUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTypeUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("workflowType", IsDefaultQueryProperty = true)]
        public WorkflowType? WorkflowType { get; internal set; }
    }
}
