using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/effortclassrateinput/">EffortClassRateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class EffortClassRateInput : PropertyChangeSet
    {
        private string? _id;
        private string? _effortClassId;
        private decimal? _rate;
        private Currency? _rateCurrency;

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
        /// The effort class for which the rate is provided.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The rate per hour for the effort class.
        /// </summary>
        [XurrentField("rate")]
        public decimal? Rate
        {
            get => _rate;
            set => _rate = Set("rate", value);
        }

        /// <summary>
        /// The currency for the rate per hour for the effort class.
        /// </summary>
        [XurrentField("rateCurrency")]
        public Currency? RateCurrency
        {
            get => _rateCurrency;
            set => _rateCurrency = Set("rateCurrency", value);
        }
    }
}
