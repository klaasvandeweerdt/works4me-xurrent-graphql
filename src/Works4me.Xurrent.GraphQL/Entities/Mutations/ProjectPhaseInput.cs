using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectphaseinput/">ProjectPhaseInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ProjectPhaseInput : PropertyChangeSet
    {
        private string? _id;
        private string? _name;
        private long? _position;

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
        /// The name of the project phase.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The position that the project phase takes when it is presented in the project's Gantt chart.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }
    }
}
