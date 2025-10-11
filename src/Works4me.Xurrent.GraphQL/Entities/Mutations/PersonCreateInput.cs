using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/personcreateinput/">PersonCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class PersonCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private string? _authenticationID;
        private bool? _autoTranslation;
        private decimal? _costPerHour;
        private Currency? _costPerHourCurrency;
        private bool? _disabled;
        private Collection<string>? _doNotTranslateLanguages;
        private string? _employeeID;
        private bool? _excludeTeamNotifications;
        private string? _information;
        private Collection<AttachmentInput>? _informationAttachments;
        private string? _jobTitle;
        private string? _language;
        private string? _location;
        private string? _managerId;
        private string? _organizationId;
        private PersonSendEmailNotifications? _sendEmailNotifications;
        private PersonShowNotificationPopup? _showNotificationPopup;
        private string? _siteId;
        private string? _supportID;
        private bool? _timeFormat24h;
        private string? _timeZone;
        private bool? _vip;
        private string? _workHoursId;
        private Collection<string>? _teamIds;
        private Collection<string>? _skillPoolIds;
        private Collection<string>? _configurationItemIds;
        private bool? _oauthPersonEnablement;
        private Collection<AddressInput>? _newAddresses;
        private Collection<ContactInput>? _newContacts;
        private Collection<PermissionInput>? _permissions;
        private Collection<PermissionInput>? _newAccountPermissions;
        private string _name;
        private string _primaryEmail;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [XurrentField("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => _customFields;
            set => _customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [XurrentField("customFieldsAttachments")]
        public Collection<AttachmentInput>? CustomFieldsAttachments
        {
            get => _customFieldsAttachments;
            set => _customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Uniquely identify the user for Single Sign-On.
        /// </summary>
        [XurrentField("authenticationID")]
        public string? AuthenticationID
        {
            get => _authenticationID;
            set => _authenticationID = Set("authenticationID", value);
        }

        /// <summary>
        /// Whether the person should be offered translations for texts that are written in languages other than the ones selected in the Language (language) and the Do not translate (do_not_translate_languages) arguments. Such texts are translated automatically into the language selected in the Language (language) argument.
        /// </summary>
        [XurrentField("autoTranslation")]
        public bool? AutoTranslation
        {
            get => _autoTranslation;
            set => _autoTranslation = Set("autoTranslation", value);
        }

        /// <summary>
        /// The person's estimated total cost per work hour for the service provider organization. The value in this argument should include the costs of the person's salary (or rate in case of a long-term contractor), office space, service subscriptions, training, etc.
        /// </summary>
        [XurrentField("costPerHour")]
        public decimal? CostPerHour
        {
            get => _costPerHour;
            set => _costPerHour = Set("costPerHour", value);
        }

        /// <summary>
        /// The currency of the cost per hour value attributed to this person.
        /// </summary>
        [XurrentField("costPerHourCurrency")]
        public Currency? CostPerHourCurrency
        {
            get => _costPerHourCurrency;
            set => _costPerHourCurrency = Set("costPerHourCurrency", value);
        }

        /// <summary>
        /// <c>true</c> when the person may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The languages that should not be translated automatically for the person. Translations will not be offered to the person for texts in any of these languages. Supported language codes are: <c>en</c>, <c>nl</c>, <c>de</c>, <c>fr</c>, <c>es</c>, <c>pt</c>, <c>it</c>, <c>da</c>, <c>fi</c>, <c>sv</c>, <c>pl</c>, <c>cs</c>, <c>tr</c>, <c>ru</c>, <c>ar</c>, <c>id</c>, <c>fa</c>, <c>no</c>, <c>zh</c>, <c>ja</c>, <c>ko</c>, <c>he</c>, <c>hi</c>, <c>ms</c>.
        /// </summary>
        [XurrentField("doNotTranslateLanguages")]
        public Collection<string>? DoNotTranslateLanguages
        {
            get => _doNotTranslateLanguages;
            set => _doNotTranslateLanguages = Set("doNotTranslateLanguages", value);
        }

        /// <summary>
        /// The unique identifier for a person typically based on order of hire or association with an organization.
        /// </summary>
        [XurrentField("employeeID")]
        public string? EmployeeID
        {
            get => _employeeID;
            set => _employeeID = Set("employeeID", value);
        }

        /// <summary>
        /// Whether team notifications should be excluded from all notifications.
        /// </summary>
        [XurrentField("excludeTeamNotifications")]
        public bool? ExcludeTeamNotifications
        {
            get => _excludeTeamNotifications;
            set => _excludeTeamNotifications = Set("excludeTeamNotifications", value);
        }

        /// <summary>
        /// Any additional information about the person that might prove useful.
        /// </summary>
        [XurrentField("information")]
        public string? Information
        {
            get => _information;
            set => _information = Set("information", value);
        }

        /// <summary>
        /// The attachments used in the <c>information</c> field.
        /// </summary>
        [XurrentField("informationAttachments")]
        public Collection<AttachmentInput>? InformationAttachments
        {
            get => _informationAttachments;
            set => _informationAttachments = Set("informationAttachments", value);
        }

        /// <summary>
        /// The person's job title.
        /// </summary>
        [XurrentField("jobTitle")]
        public string? JobTitle
        {
            get => _jobTitle;
            set => _jobTitle = Set("jobTitle", value);
        }

        /// <summary>
        /// The language preference of the person.
        /// </summary>
        [XurrentField("language")]
        public string? Language
        {
            get => _language;
            set => _language = Set("language", value);
        }

        /// <summary>
        /// The name or number of the room, cubicle or area where the person has his/her primary work space.
        /// </summary>
        [XurrentField("location")]
        public string? Location
        {
            get => _location;
            set => _location = Set("location", value);
        }

        /// <summary>
        /// The manager or supervisor to whom the person reports.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// The organization for which the person works as an employee or long-term contractor.
        /// </summary>
        [XurrentField("organizationId")]
        public string? OrganizationId
        {
            get => _organizationId;
            set => _organizationId = Set("organizationId", value);
        }

        /// <summary>
        /// Indicates when to send email notifications to the person.
        /// </summary>
        [XurrentField("sendEmailNotifications")]
        public PersonSendEmailNotifications? SendEmailNotifications
        {
            get => _sendEmailNotifications;
            set => _sendEmailNotifications = Set("sendEmailNotifications", value);
        }

        /// <summary>
        /// Indicates when to show a notification popup to the person.
        /// </summary>
        [XurrentField("showNotificationPopup")]
        public PersonShowNotificationPopup? ShowNotificationPopup
        {
            get => _showNotificationPopup;
            set => _showNotificationPopup = Set("showNotificationPopup", value);
        }

        /// <summary>
        /// Where the person is stationed.
        /// </summary>
        [XurrentField("siteId")]
        public string? SiteId
        {
            get => _siteId;
            set => _siteId = Set("siteId", value);
        }

        /// <summary>
        /// A number or code that a service desk analyst can ask the person for when the person contacts the service desk for support.
        /// </summary>
        [XurrentField("supportID")]
        public string? SupportID
        {
            get => _supportID;
            set => _supportID = Set("supportID", value);
        }

        /// <summary>
        /// Whether the person prefers to see times displayed within the Xurrent service in the 24-hour format or not (in which case the 12-hour format is applied).
        /// </summary>
        [XurrentField("timeFormat24h")]
        public bool? TimeFormat24h
        {
            get => _timeFormat24h;
            set => _timeFormat24h = Set("timeFormat24h", value);
        }

        /// <summary>
        /// The time zone in which the person normally resides.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Whether the person is a very important person.
        /// </summary>
        [XurrentField("vip")]
        public bool? Vip
        {
            get => _vip;
            set => _vip = Set("vip", value);
        }

        /// <summary>
        /// Calendar that represents the work hours of the person.
        /// </summary>
        [XurrentField("workHoursId")]
        public string? WorkHoursId
        {
            get => _workHoursId;
            set => _workHoursId = Set("workHoursId", value);
        }

        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        [XurrentField("teamIds")]
        public Collection<string>? TeamIds
        {
            get => _teamIds;
            set => _teamIds = Set("teamIds", value);
        }

        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        [XurrentField("skillPoolIds")]
        public Collection<string>? SkillPoolIds
        {
            get => _skillPoolIds;
            set => _skillPoolIds = Set("skillPoolIds", value);
        }

        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        [XurrentField("configurationItemIds")]
        public Collection<string>? ConfigurationItemIds
        {
            get => _configurationItemIds;
            set => _configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// An enabled OAuth person is mentionable and visible in suggest fields, just like a real person.
        /// </summary>
        [XurrentField("oauthPersonEnablement")]
        public bool? OauthPersonEnablement
        {
            get => _oauthPersonEnablement;
            set => _oauthPersonEnablement = Set("oauthPersonEnablement", value);
        }

        /// <summary>
        /// New or updated addresses of this person.
        /// </summary>
        [XurrentField("newAddresses")]
        public Collection<AddressInput>? NewAddresses
        {
            get => _newAddresses;
            set => _newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// New or updated contacts of this person.
        /// </summary>
        [XurrentField("newContacts")]
        public Collection<ContactInput>? NewContacts
        {
            get => _newContacts;
            set => _newContacts = Set("newContacts", value);
        }

        /// <summary>
        /// Permissions of this person. These will overwrite all existing permissions of this person.
        /// </summary>
        [XurrentField("permissions")]
        public Collection<PermissionInput>? Permissions
        {
            get => _permissions;
            set => _permissions = Set("permissions", value);
        }

        /// <summary>
        /// Permissions for specific accounts of this person to add or update. Permissions for other accounts will not be altered.
        /// </summary>
        [XurrentField("newAccountPermissions")]
        public Collection<PermissionInput>? NewAccountPermissions
        {
            get => _newAccountPermissions;
            set => _newAccountPermissions = Set("newAccountPermissions", value);
        }

        /// <summary>
        /// The name of the person.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The email address to which email notifications are to be sent. This email address acts as the unique identifier for the person within the Xurrent account. This primary email address also acts as the person's login name if he/she is a user of the Xurrent service.
        /// </summary>
        [XurrentField("primaryEmail")]
        public string PrimaryEmail
        {
            get => _primaryEmail;
            set => _primaryEmail = Set("primaryEmail", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCreateInput"/> class without providing the required values.
        /// </summary>
        public PersonCreateInput()
        {
            _name = string.Empty;
            _primaryEmail = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCreateInput"/> class.
        /// </summary>
        public PersonCreateInput(string name, string primaryEmail)
        {
            _name = Set("name", name);
            _primaryEmail = Set("primaryEmail", primaryEmail);
        }
    }
}
