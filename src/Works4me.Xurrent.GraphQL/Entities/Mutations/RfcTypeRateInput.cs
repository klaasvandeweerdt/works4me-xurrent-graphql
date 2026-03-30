using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/rfctyperateinput/">RfcTypeRateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class RfcTypeRateInput : PropertyChangeSet
    {
        private string? _id;
        private string? _rfcTypeId;
        private ServiceOfferingChargeType? _chargeType;
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
        /// The request for change type for which the rate is provided.
        /// </summary>
        [XurrentField("rfcTypeId")]
        public string? RfcTypeId
        {
            get => _rfcTypeId;
            set => _rfcTypeId = Set("rfcTypeId", value);
        }

        /// <summary>
        /// The charge type of the RFC type rate.
        /// </summary>
        [XurrentField("chargeType")]
        public ServiceOfferingChargeType? ChargeType
        {
            get => _chargeType;
            set => _chargeType = Set("chargeType", value);
        }

        /// <summary>
        /// The rate for the request for change type.
        /// </summary>
        [XurrentField("rate")]
        public decimal? Rate
        {
            get => _rate;
            set => _rate = Set("rate", value);
        }

        /// <summary>
        /// The currency of the rate for the request for change type.
        /// </summary>
        [XurrentField("rateCurrency")]
        public Currency? RateCurrency
        {
            get => _rateCurrency;
            set => _rateCurrency = Set("rateCurrency", value);
        }
    }
}
