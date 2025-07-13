using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/activityidinput/">ActivityIDInput</see> in Xurrent.
    /// </summary>
    public sealed class ActivityIDInput : PropertyChangeSet
    {
        private string? _low;
        private string? _medium;
        private string? _high;
        private string? _top;
        private string? _rfc;
        private string? _rfi;
        private string? _case;

        /// <summary>
        /// Represents the activityID for low incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("low")]
        public string? Low
        {
            get => _low;
            set => _low = Set("low", value);
        }

        /// <summary>
        /// Represents the activityID for medium incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("medium")]
        public string? Medium
        {
            get => _medium;
            set => _medium = Set("medium", value);
        }

        /// <summary>
        /// Represents the activityID for high incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("high")]
        public string? High
        {
            get => _high;
            set => _high = Set("high", value);
        }

        /// <summary>
        /// Represents the activityID for top incidents. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("top")]
        public string? Top
        {
            get => _top;
            set => _top = Set("top", value);
        }

        /// <summary>
        /// Represents the activityID for RFCs. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("rfc")]
        public string? Rfc
        {
            get => _rfc;
            set => _rfc = Set("rfc", value);
        }

        /// <summary>
        /// Represents the activityID for RFIs. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("rfi")]
        public string? Rfi
        {
            get => _rfi;
            set => _rfi = Set("rfi", value);
        }

        /// <summary>
        /// Represents the activityID for cases. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("case")]
        public string? Case
        {
            get => _case;
            set => _case = Set("case", value);
        }
    }
}
