using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ReservationOffering">ReservationOffering</see> fields.
    /// </summary>
    public enum ReservationOfferingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The allow repeat field.
        /// </summary>
        [XurrentEnum("allowRepeat")]
        AllowRepeat,

        /// <summary>
        /// The calendar field.
        /// </summary>
        [XurrentEnum("calendar")]
        Calendar,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The filters field.
        /// </summary>
        [XurrentEnum("filters")]
        Filters,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The initial status field.
        /// </summary>
        [XurrentEnum("initialStatus")]
        InitialStatus,

        /// <summary>
        /// The max advance duration field.
        /// </summary>
        [XurrentEnum("maxAdvanceDuration")]
        MaxAdvanceDuration,

        /// <summary>
        /// The max duration field.
        /// </summary>
        [XurrentEnum("maxDuration")]
        MaxDuration,

        /// <summary>
        /// The min advance duration field.
        /// </summary>
        [XurrentEnum("minAdvanceDuration")]
        MinAdvanceDuration,

        /// <summary>
        /// The min duration field.
        /// </summary>
        [XurrentEnum("minDuration")]
        MinDuration,

        /// <summary>
        /// The multi day field.
        /// </summary>
        [XurrentEnum("multiDay")]
        MultiDay,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The preparation duration field.
        /// </summary>
        [XurrentEnum("preparationDuration")]
        PreparationDuration,

        /// <summary>
        /// The private reservations field.
        /// </summary>
        [XurrentEnum("privateReservations")]
        PrivateReservations,

        /// <summary>
        /// The service instance field.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The step duration field.
        /// </summary>
        [XurrentEnum("stepDuration")]
        StepDuration,

        /// <summary>
        /// The time zone field.
        /// </summary>
        [XurrentEnum("timeZone")]
        TimeZone,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
