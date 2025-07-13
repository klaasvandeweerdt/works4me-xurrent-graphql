using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectcategoryupdatepayload/">ProjectCategoryUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectCategoryUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectCategory", IsDefaultQueryProperty = true)]
        public ProjectCategory? ProjectCategory { get; internal set; }
    }
}
