using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Reservation">Reservation</see> fields.
    /// </summary>
    public enum ReservationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The configuration item field.
        /// </summary>
        [XurrentEnum("configurationItem")]
        ConfigurationItem,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The created by field.
        /// </summary>
        [XurrentEnum("createdBy")]
        CreatedBy,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The duration field.
        /// </summary>
        [XurrentEnum("duration")]
        Duration,

        /// <summary>
        /// The end at field.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The only this occurrence field.
        /// </summary>
        [XurrentEnum("onlyThisOccurrence")]
        OnlyThisOccurrence,

        /// <summary>
        /// The person field.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// The preparation start at field.
        /// </summary>
        [XurrentEnum("preparationStartAt")]
        PreparationStartAt,

        /// <summary>
        /// The recurrence field.
        /// </summary>
        [XurrentEnum("recurrence")]
        Recurrence,

        /// <summary>
        /// The request field.
        /// </summary>
        [XurrentEnum("request")]
        Request,

        /// <summary>
        /// The reservation offering field.
        /// </summary>
        [XurrentEnum("reservationOffering")]
        ReservationOffering,

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
        /// The start at field.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
