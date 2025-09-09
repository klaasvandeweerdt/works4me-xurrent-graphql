using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/effortclassrateidinput/">EffortClassRateIDInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class EffortClassRateIDInput : PropertyChangeSet
    {
        private string? _id;
        private string? _effortClassId;
        private string? _rateID;

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
        /// The effort class ID for which a billing identifier is provided.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [XurrentField("rateID")]
        public string? RateID
        {
            get => _rateID;
            set => _rateID = Set("rateID", value);
        }
    }
}
