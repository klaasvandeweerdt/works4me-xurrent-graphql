using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/taskupdatepayload/">WorkflowTaskUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTaskUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("task", IsDefaultQueryProperty = true)]
        public WorkflowTask? Task { get; internal set; }
    }
}
