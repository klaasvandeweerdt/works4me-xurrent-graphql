using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Webhook">Webhook</see> fields.
    /// </summary>
    public enum WebhookField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The app offering references field.
        /// </summary>
        [XurrentEnum("appOfferingReferences")]
        AppOfferingReferences,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The event field.
        /// </summary>
        [XurrentEnum("event")]
        Event,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The mail exceptions to field.
        /// </summary>
        [XurrentEnum("mailExceptionsTo")]
        MailExceptionsTo,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

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
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The uri field.
        /// </summary>
        [XurrentEnum("uri")]
        Uri,

        /// <summary>
        /// The webhook policy field.
        /// </summary>
        [XurrentEnum("webhookPolicy")]
        WebhookPolicy
    }
}
