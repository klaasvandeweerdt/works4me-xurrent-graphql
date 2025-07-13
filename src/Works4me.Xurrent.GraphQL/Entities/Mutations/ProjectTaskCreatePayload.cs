using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttaskcreatepayload/">ProjectTaskCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTaskCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectTask", IsDefaultQueryProperty = true)]
        public ProjectTask? ProjectTask { get; internal set; }
    }
}
