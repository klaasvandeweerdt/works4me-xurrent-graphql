using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Service">Service</see> fields.
    /// </summary>
    public enum ServiceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The availability manager field.
        /// </summary>
        [XurrentEnum("availabilityManager")]
        AvailabilityManager,

        /// <summary>
        /// The capacity manager field.
        /// </summary>
        [XurrentEnum("capacityManager")]
        CapacityManager,

        /// <summary>
        /// The change manager field.
        /// </summary>
        [XurrentEnum("changeManager")]
        ChangeManager,

        /// <summary>
        /// The continuity manager field.
        /// </summary>
        [XurrentEnum("continuityManager")]
        ContinuityManager,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

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
        /// The first line team field.
        /// </summary>
        [XurrentEnum("firstLineTeam")]
        FirstLineTeam,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The keywords field.
        /// </summary>
        [XurrentEnum("keywords")]
        Keywords,

        /// <summary>
        /// The knowledge manager field.
        /// </summary>
        [XurrentEnum("knowledgeManager")]
        KnowledgeManager,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

        /// <summary>
        /// The problem manager field.
        /// </summary>
        [XurrentEnum("problemManager")]
        ProblemManager,

        /// <summary>
        /// The release manager field.
        /// </summary>
        [XurrentEnum("releaseManager")]
        ReleaseManager,

        /// <summary>
        /// The service owner field.
        /// </summary>
        [XurrentEnum("serviceOwner")]
        ServiceOwner,

        /// <summary>
        /// The service provider field.
        /// </summary>
        [XurrentEnum("serviceProvider")]
        ServiceProvider,

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
        /// The support team field.
        /// </summary>
        [XurrentEnum("supportTeam")]
        SupportTeam,

        /// <summary>
        /// The survey field.
        /// </summary>
        [XurrentEnum("survey")]
        Survey,

        /// <summary>
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
