using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request category values.
    /// </summary>
    public enum RequestCategory
    {
        /// <summary>
        /// Case.
        /// </summary>
        [XurrentEnum("case")]
        Case,

        /// <summary>
        /// Complaint request for support improvement.
        /// </summary>
        [XurrentEnum("complaint")]
        Complaint,

        /// <summary>
        /// Compliment request for bestowal of praise.
        /// </summary>
        [XurrentEnum("compliment")]
        Compliment,

        /// <summary>
        /// Fulfillment request for order fulfillment.
        /// </summary>
        [XurrentEnum("fulfillment")]
        Fulfillment,

        /// <summary>
        /// Incident request for incident resolution.
        /// </summary>
        [XurrentEnum("incident")]
        Incident,

        /// <summary>
        /// Order request for purchase.
        /// </summary>
        [XurrentEnum("order")]
        Order,

        /// <summary>
        /// Other request is out of scope.
        /// </summary>
        [XurrentEnum("other")]
        Other,

        /// <summary>
        /// Reservation request for reservation.
        /// </summary>
        [XurrentEnum("reservation")]
        Reservation,

        /// <summary>
        /// Rfc request for change.
        /// </summary>
        [XurrentEnum("rfc")]
        Rfc,

        /// <summary>
        /// Rfi request for information.
        /// </summary>
        [XurrentEnum("rfi")]
        Rfi
    }
}
