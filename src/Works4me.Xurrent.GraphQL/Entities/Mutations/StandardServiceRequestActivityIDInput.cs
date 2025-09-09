using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/standardservicerequestactivityidinput/">StandardServiceRequestActivityIDInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class StandardServiceRequestActivityIDInput : PropertyChangeSet
    {
        private string? _id;
        private string? _standardServiceRequestId;
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
        /// The standard service request ID for which a billing identifier is provided.
        /// </summary>
        [XurrentField("standardServiceRequestId")]
        public string? StandardServiceRequestId
        {
            get => _standardServiceRequestId;
            set => _standardServiceRequestId = Set("standardServiceRequestId", value);
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
