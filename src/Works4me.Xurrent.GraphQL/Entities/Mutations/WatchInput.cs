using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/watchinput/">WatchInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WatchInput : PropertyChangeSet
    {
        private string? _id;
        private string? _personId;

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
        /// The person watching.
        /// </summary>
        [XurrentField("personId")]
        public string? PersonId
        {
            get => _personId;
            set => _personId = Set("personId", value);
        }
    }
}
