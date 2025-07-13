using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttaskupdatepayload/">ProjectTaskUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTaskUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectTask", IsDefaultQueryProperty = true)]
        public ProjectTask? ProjectTask { get; internal set; }
    }
}
