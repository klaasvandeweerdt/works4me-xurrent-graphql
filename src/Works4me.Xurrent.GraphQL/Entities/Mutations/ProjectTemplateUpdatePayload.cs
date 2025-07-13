using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttemplateupdatepayload/">ProjectTemplateUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTemplateUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectTemplate", IsDefaultQueryProperty = true)]
        public ProjectTemplate? ProjectTemplate { get; internal set; }
    }
}
