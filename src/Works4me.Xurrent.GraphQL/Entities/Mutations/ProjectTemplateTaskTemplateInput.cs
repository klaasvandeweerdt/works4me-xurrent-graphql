using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttemplatetasktemplateinput/">ProjectTemplateTaskTemplateInput</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTemplateTaskTemplateInput : PropertyChangeSet
    {
        private string? _id;
        private string? _taskTemplateId;
        private string? _phaseName;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the project task template that is related to the project template.
        /// </summary>
        [XurrentField("taskTemplateId")]
        public string? TaskTemplateId
        {
            get => _taskTemplateId;
            set => _taskTemplateId = Set("taskTemplateId", value);
        }

        /// <summary>
        /// Name of the phase of the project template that the project task template is a part of.
        /// </summary>
        [XurrentField("phaseName")]
        public string? PhaseName
        {
            get => _phaseName;
            set => _phaseName = Set("phaseName", value);
        }
    }
}
