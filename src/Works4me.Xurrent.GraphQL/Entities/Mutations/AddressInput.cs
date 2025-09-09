using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/addressinput/">AddressInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class AddressInput : PropertyChangeSet
    {
        private string? _id;
        private AddressLabel? _label;
        private string? _street;
        private string? _city;
        private string? _state;
        private string? _zip;
        private string? _country;
        private bool? _integration;

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
        /// The Label of the address details.
        /// </summary>
        [XurrentField("label")]
        public AddressLabel? Label
        {
            get => _label;
            set => _label = Set("label", value);
        }

        /// <summary>
        /// The address lines.
        /// </summary>
        [XurrentField("address")]
        public string? Street
        {
            get => _street;
            set => _street = Set("address", value);
        }

        /// <summary>
        /// The city name.
        /// </summary>
        [XurrentField("city")]
        public string? City
        {
            get => _city;
            set => _city = Set("city", value);
        }

        /// <summary>
        /// The state name.
        /// </summary>
        [XurrentField("state")]
        public string? State
        {
            get => _state;
            set => _state = Set("state", value);
        }

        /// <summary>
        /// The zip code.
        /// </summary>
        [XurrentField("zip")]
        public string? Zip
        {
            get => _zip;
            set => _zip = Set("zip", value);
        }

        /// <summary>
        /// The city name.
        /// </summary>
        [XurrentField("country")]
        public string? Country
        {
            get => _country;
            set => _country = Set("country", value);
        }

        /// <summary>
        /// The Integration field is a hidden checkbox that can be set to <c>true</c> using this API or the Import functionality. When checked, the address is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [XurrentField("integration")]
        public bool? Integration
        {
            get => _integration;
            set => _integration = Set("integration", value);
        }
    }
}
