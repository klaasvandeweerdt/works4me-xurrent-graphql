using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/scrumworkspacecreatepayload/">ScrumWorkspaceCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ScrumWorkspaceCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("scrumWorkspace", IsDefaultQueryProperty = true)]
        public ScrumWorkspace? ScrumWorkspace { get; internal set; }
    }
}
