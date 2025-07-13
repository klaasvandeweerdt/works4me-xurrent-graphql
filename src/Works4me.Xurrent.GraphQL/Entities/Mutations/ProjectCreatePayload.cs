using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectcreatepayload/">ProjectCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("project", IsDefaultQueryProperty = true)]
        public Project? Project { get; internal set; }
    }
}
