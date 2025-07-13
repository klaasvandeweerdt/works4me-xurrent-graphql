using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttasktemplateupdatepayload/">ProjectTaskTemplateUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTaskTemplateUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("projectTaskTemplate", IsDefaultQueryProperty = true)]
        public ProjectTaskTemplate? ProjectTaskTemplate { get; internal set; }
    }
}
