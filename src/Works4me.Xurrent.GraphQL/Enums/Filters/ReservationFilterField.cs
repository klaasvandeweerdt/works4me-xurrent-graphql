using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Reservation records are returned.
    /// </summary>
    public enum ReservationFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on Asset.
        /// </summary>
        [XurrentEnum("ci")]
        Ci,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// End in supplied range.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Person.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// Preparation start in supplied range.
        /// </summary>
        [XurrentEnum("preparationStartAt")]
        PreparationStartAt,

        /// <summary>
        /// Include only if Recurrent matches supplied value.
        /// </summary>
        [XurrentEnum("recurrent")]
        Recurrent,

        /// <summary>
        /// Filter on Reservation offering.
        /// </summary>
        [XurrentEnum("reservationOffering")]
        ReservationOffering,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service instance.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
