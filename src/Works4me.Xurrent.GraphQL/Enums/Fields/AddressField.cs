using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Address">Address</see> fields.
    /// </summary>
    public enum AddressField
    {
        /// <summary>
        /// The street field.
        /// </summary>
        [XurrentEnum("address")]
        Street,

        /// <summary>
        /// The city field.
        /// </summary>
        [XurrentEnum("city")]
        City,

        /// <summary>
        /// The country field.
        /// </summary>
        [XurrentEnum("country")]
        Country,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The integration field.
        /// </summary>
        [XurrentEnum("integration")]
        Integration,

        /// <summary>
        /// The label field.
        /// </summary>
        [XurrentEnum("label")]
        Label,

        /// <summary>
        /// The state field.
        /// </summary>
        [XurrentEnum("state")]
        State,

        /// <summary>
        /// The zip field.
        /// </summary>
        [XurrentEnum("zip")]
        Zip
    }
}
