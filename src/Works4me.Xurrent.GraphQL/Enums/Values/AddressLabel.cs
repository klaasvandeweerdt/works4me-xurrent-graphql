using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The address label values.
    /// </summary>
    public enum AddressLabel
    {
        /// <summary>
        /// Billing.
        /// </summary>
        [XurrentEnum("billing")]
        Billing,

        /// <summary>
        /// Home.
        /// </summary>
        [XurrentEnum("home")]
        Home,

        /// <summary>
        /// Mailing.
        /// </summary>
        [XurrentEnum("mailing")]
        Mailing,

        /// <summary>
        /// Shipping.
        /// </summary>
        [XurrentEnum("shipping")]
        Shipping,

        /// <summary>
        /// Street.
        /// </summary>
        [XurrentEnum("street")]
        Street
    }
}
