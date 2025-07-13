using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Person">Person</see> fields.
    /// </summary>
    public enum PersonField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The authentication id field.
        /// </summary>
        [XurrentEnum("authenticationID")]
        AuthenticationID,

        /// <summary>
        /// The auto translation field.
        /// </summary>
        [XurrentEnum("autoTranslation")]
        AutoTranslation,

        /// <summary>
        /// The cost per hour field.
        /// </summary>
        [XurrentEnum("costPerHour")]
        CostPerHour,

        /// <summary>
        /// The cost per hour currency field.
        /// </summary>
        [XurrentEnum("costPerHourCurrency")]
        CostPerHourCurrency,

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
        /// The do not translate languages field.
        /// </summary>
        [XurrentEnum("doNotTranslateLanguages")]
        DoNotTranslateLanguages,

        /// <summary>
        /// The employee id field.
        /// </summary>
        [XurrentEnum("employeeID")]
        EmployeeID,

        /// <summary>
        /// The exclude team notifications field.
        /// </summary>
        [XurrentEnum("excludeTeamNotifications")]
        ExcludeTeamNotifications,

        /// <summary>
        /// The guest field.
        /// </summary>
        [XurrentEnum("guest")]
        Guest,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The information field.
        /// </summary>
        [XurrentEnum("information")]
        Information,

        /// <summary>
        /// The job title field.
        /// </summary>
        [XurrentEnum("jobTitle")]
        JobTitle,

        /// <summary>
        /// The language field.
        /// </summary>
        [XurrentEnum("language")]
        Language,

        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// The location field.
        /// </summary>
        [XurrentEnum("location")]
        Location,

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
        /// The oauth person enablement field.
        /// </summary>
        [XurrentEnum("oauthPersonEnablement")]
        OauthPersonEnablement,

        /// <summary>
        /// The organization field.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

        /// <summary>
        /// The primary email field.
        /// </summary>
        [XurrentEnum("primaryEmail")]
        PrimaryEmail,

        /// <summary>
        /// The send email notifications field.
        /// </summary>
        [XurrentEnum("sendEmailNotifications")]
        SendEmailNotifications,

        /// <summary>
        /// The show notification popup field.
        /// </summary>
        [XurrentEnum("showNotificationPopup")]
        ShowNotificationPopup,

        /// <summary>
        /// The site field.
        /// </summary>
        [XurrentEnum("site")]
        Site,

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
        /// The support id field.
        /// </summary>
        [XurrentEnum("supportID")]
        SupportID,

        /// <summary>
        /// The time format 24 h field.
        /// </summary>
        [XurrentEnum("timeFormat24h")]
        TimeFormat24h,

        /// <summary>
        /// The time zone field.
        /// </summary>
        [XurrentEnum("timeZone")]
        TimeZone,

        /// <summary>
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The vip field.
        /// </summary>
        [XurrentEnum("vip")]
        Vip,

        /// <summary>
        /// The work hours field.
        /// </summary>
        [XurrentEnum("workHours")]
        WorkHours
    }
}
