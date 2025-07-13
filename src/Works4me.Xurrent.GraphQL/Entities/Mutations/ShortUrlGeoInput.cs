using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shorturlgeoinput/">ShortUrlGeoInput</see> in Xurrent.
    /// </summary>
    public sealed class ShortUrlGeoInput : PropertyChangeSet
    {
        private string _latitude;
        private string _longitude;

        /// <summary>
        /// Latitude coordinate of the location.
        /// </summary>
        [XurrentField("latitude")]
        public string Latitude
        {
            get => _latitude;
            set => _latitude = Set("latitude", value);
        }

        /// <summary>
        /// Longitude coordinate of the location.
        /// </summary>
        [XurrentField("longitude")]
        public string Longitude
        {
            get => _longitude;
            set => _longitude = Set("longitude", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlGeoInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlGeoInput()
        {
            _latitude = string.Empty;
            _longitude = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlGeoInput"/> class.
        /// </summary>
        public ShortUrlGeoInput(string latitude, string longitude)
        {
            _latitude = Set("latitude", latitude);
            _longitude = Set("longitude", longitude);
        }
    }
}
