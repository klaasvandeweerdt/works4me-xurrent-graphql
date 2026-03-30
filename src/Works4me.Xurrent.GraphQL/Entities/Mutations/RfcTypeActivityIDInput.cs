using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/rfctypeactivityidinput/">RfcTypeActivityIDInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class RfcTypeActivityIDInput : PropertyChangeSet
    {
        private string? _id;
        private string? _rfcTypeId;
        private string? _activityID;

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
        /// The request for change type for which a billing identifier is provided.
        /// </summary>
        [XurrentField("rfcTypeId")]
        public string? RfcTypeId
        {
            get => _rfcTypeId;
            set => _rfcTypeId = Set("rfcTypeId", value);
        }

        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [XurrentField("activityID")]
        public string? ActivityID
        {
            get => _activityID;
            set => _activityID = Set("activityID", value);
        }
    }
}
