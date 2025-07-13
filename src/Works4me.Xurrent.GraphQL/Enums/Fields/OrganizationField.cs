using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Organization">Organization</see> fields.
    /// </summary>
    public enum OrganizationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The business unit field.
        /// </summary>
        [XurrentEnum("businessUnit")]
        BusinessUnit,

        /// <summary>
        /// The business unit organization field.
        /// </summary>
        [XurrentEnum("businessUnitOrganization")]
        BusinessUnitOrganization,

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
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The end user privacy field.
        /// </summary>
        [XurrentEnum("endUserPrivacy")]
        EndUserPrivacy,

        /// <summary>
        /// The financial id field.
        /// </summary>
        [XurrentEnum("financialID")]
        FinancialID,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The manager field.
        /// </summary>
        [XurrentEnum("manager")]
        Manager,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The order template field.
        /// </summary>
        [XurrentEnum("orderTemplate")]
        OrderTemplate,

        /// <summary>
        /// The parent field.
        /// </summary>
        [XurrentEnum("parent")]
        Parent,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

        /// <summary>
        /// The region field.
        /// </summary>
        [XurrentEnum("region")]
        Region,

        /// <summary>
        /// The remarks field.
        /// </summary>
        [XurrentEnum("remarks")]
        Remarks,

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
        /// The substitute field.
        /// </summary>
        [XurrentEnum("substitute")]
        Substitute,

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
