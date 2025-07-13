using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttemplateupdateinput/">ProjectTemplateUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTemplateUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private string? _subject;
        private Collection<ProjectPhaseInput>? _newPhases;
        private Collection<ProjectTemplateTaskTemplateInput>? _newTaskTemplateRelations;
        private string _id;
        private Collection<string>? _phasesToDelete;
        private Collection<string>? _taskTemplateRelationsToDelete;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Whether the project template may not be used to help register new projects.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new project when it is being created based on the template.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Phases of the project template.
        /// </summary>
        [XurrentField("newPhases")]
        public Collection<ProjectPhaseInput>? NewPhases
        {
            get => _newPhases;
            set => _newPhases = Set("newPhases", value);
        }

        /// <summary>
        /// Project task template relations of the project template.
        /// </summary>
        [XurrentField("newTaskTemplateRelations")]
        public Collection<ProjectTemplateTaskTemplateInput>? NewTaskTemplateRelations
        {
            get => _newTaskTemplateRelations;
            set => _newTaskTemplateRelations = Set("newTaskTemplateRelations", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of phases to remove from the project template.
        /// </summary>
        [XurrentField("phasesToDelete")]
        public Collection<string>? PhasesToDelete
        {
            get => _phasesToDelete;
            set => _phasesToDelete = Set("phasesToDelete", value);
        }

        /// <summary>
        /// Identifiers of task template relations to remove from the project template.
        /// </summary>
        [XurrentField("taskTemplateRelationsToDelete")]
        public Collection<string>? TaskTemplateRelationsToDelete
        {
            get => _taskTemplateRelationsToDelete;
            set => _taskTemplateRelationsToDelete = Set("taskTemplateRelationsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateUpdateInput"/> class without providing the required values.
        /// </summary>
        public ProjectTemplateUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateUpdateInput"/> class.
        /// </summary>
        public ProjectTemplateUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
