using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/person/">Person</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Person")]
    public sealed class Person : IDataItem, IHasLifeCycleState, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("addresses")]
        internal PagedResponse<Address>? AddressesCollection { get; set; }
        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public ReadOnlyDataCollection<Address>? Addresses { get => AddressesCollection?.Data is null ? null : new ReadOnlyDataCollection<Address>(AddressesCollection.Data); }

        /// <summary>
        /// Uniquely identify the user for Single Sign-On.
        /// </summary>
        [XurrentField("authenticationID")]
        public string? AuthenticationID { get; internal set; }

        /// <summary>
        /// Whether the person should be offered translations for texts that are written in languages other than the ones selected in the Language (language) and the Do not translate (do_not_translate_languages) fields. Such texts are translated automatically into the language selected in the Language (language) field.
        /// </summary>
        [XurrentField("autoTranslation")]
        public bool? AutoTranslation { get; internal set; }

        [XurrentField("cart")]
        internal PagedResponse<ShopOrderLine>? CartCollection { get; set; }
        /// <summary>
        /// The shop order lines related to this person with status in_cart.
        /// </summary>
        public ReadOnlyDataCollection<ShopOrderLine>? Cart { get => CartCollection?.Data is null ? null : new ReadOnlyDataCollection<ShopOrderLine>(CartCollection.Data); }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

        [XurrentField("contacts")]
        internal PagedResponse<Contact>? ContactsCollection { get; set; }
        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public ReadOnlyDataCollection<Contact>? Contacts { get => ContactsCollection?.Data is null ? null : new ReadOnlyDataCollection<Contact>(ContactsCollection.Data); }

        /// <summary>
        /// The person's estimated total cost per work hour for the service provider organization. The value in this field should include the costs of the person's salary (or rate in case of a long-term contractor), office space, service subscriptions, training, etc.
        /// </summary>
        [XurrentField("costPerHour")]
        public decimal? CostPerHour { get; internal set; }

        /// <summary>
        /// The currency of the cost per hour value of this skill pool.
        /// </summary>
        [XurrentField("costPerHourCurrency")]
        public Currency? CostPerHourCurrency { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [XurrentField("customFields")]
        internal CustomFieldCollection? CustomFieldCollection { get; set; }
        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public IReadOnlyCustomFieldCollection? CustomFields { get => CustomFieldCollection is null ? null : new ReadOnlyCustomFieldCollection(CustomFieldCollection); }

        [XurrentField("customFieldsAttachments")]
        internal PagedResponse<Attachment>? CustomFieldsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CustomFieldsAttachments { get => CustomFieldsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CustomFieldsAttachmentsCollection.Data); }

        /// <summary>
        /// <c>true</c> when the person may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The languages that should not be translated automatically for the person. Translations will not be offered to the person for texts in any of these languages. This field can contain a comma-separated list of language codes. Supported language codes are: en, nl, de, fr, es, pt, it, da, fi, sv, pl, cs, tr, ru, ar, id, fa, no, zh, ja, ko, he, hi, ms.
        /// </summary>
        [XurrentField("doNotTranslateLanguages")]
        public IReadOnlyList<string>? DoNotTranslateLanguages { get; internal set; }

        /// <summary>
        /// The unique identifier for a person typically based on order of hire or association with an organization.
        /// </summary>
        [XurrentField("employeeID")]
        public string? EmployeeID { get; internal set; }

        /// <summary>
        /// Whether team notifications should be excluded from all notifications.
        /// </summary>
        [XurrentField("excludeTeamNotifications")]
        public bool? ExcludeTeamNotifications { get; internal set; }

        /// <summary>
        /// <c>true</c> when the person registered as a guest in self service.
        /// </summary>
        [XurrentField("guest")]
        public bool? Guest { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Any additional information about the person that might prove useful.
        /// </summary>
        [XurrentField("information")]
        public string? Information { get; internal set; }

        [XurrentField("informationAttachments")]
        internal PagedResponse<Attachment>? InformationAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? InformationAttachments { get => InformationAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(InformationAttachmentsCollection.Data); }

        /// <summary>
        /// The person's job title.
        /// </summary>
        [XurrentField("jobTitle")]
        public string? JobTitle { get; internal set; }

        /// <summary>
        /// The language preference of the person.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/language/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("language")]
        public string? Language { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The name or number of the room, cubicle or area where the person has his/her primary work space.
        /// </summary>
        [XurrentField("location")]
        public string? Location { get; internal set; }

        /// <summary>
        /// The manager or supervisor to whom the person reports.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The person's name.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// An enabled OAuth person is mentionable and visible in suggest fields, just like a real person.
        /// </summary>
        [XurrentField("oauthPersonEnablement")]
        public bool? OauthPersonEnablement { get; internal set; }

        /// <summary>
        /// The organization for which the person works as an employee or long-term contractor.
        /// </summary>
        [XurrentField("organization")]
        public Organization? Organization { get; internal set; }

        [XurrentField("outOfOfficePeriods")]
        internal PagedResponse<OutOfOfficePeriod>? OutOfOfficePeriodsCollection { get; set; }
        /// <summary>
        /// Out of office periods for this person.
        /// </summary>
        public ReadOnlyDataCollection<OutOfOfficePeriod>? OutOfOfficePeriods { get => OutOfOfficePeriodsCollection?.Data is null ? null : new ReadOnlyDataCollection<OutOfOfficePeriod>(OutOfOfficePeriodsCollection.Data); }

        [XurrentField("permissions")]
        internal PagedResponse<Permission>? PermissionsCollection { get; set; }
        /// <summary>
        /// Permissions of this person.
        /// </summary>
        public ReadOnlyDataCollection<Permission>? Permissions { get => PermissionsCollection?.Data is null ? null : new ReadOnlyDataCollection<Permission>(PermissionsCollection.Data); }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// The email address to which email notifications are to be sent. This email address acts as the unique identifier for the person within the Xurrent account. This primary email address also acts as the person's login name if he/she is a user of the Xurrent service.
        /// </summary>
        [XurrentField("primaryEmail")]
        public string? PrimaryEmail { get; internal set; }

        /// <summary>
        /// Indicates when to send email notifications to the person.
        /// </summary>
        [XurrentField("sendEmailNotifications")]
        public PersonSendEmailNotifications? SendEmailNotifications { get; internal set; }

        /// <summary>
        /// Indicates when to show a notification popup to the person.
        /// </summary>
        [XurrentField("showNotificationPopup")]
        public PersonShowNotificationPopup? ShowNotificationPopup { get; internal set; }

        /// <summary>
        /// Where the person is stationed.
        /// </summary>
        [XurrentField("site")]
        public Site? Site { get; internal set; }

        [XurrentField("skillPools")]
        internal PagedResponse<SkillPool>? SkillPoolsCollection { get; set; }
        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        public ReadOnlyDataCollection<SkillPool>? SkillPools { get => SkillPoolsCollection?.Data is null ? null : new ReadOnlyDataCollection<SkillPool>(SkillPoolsCollection.Data); }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// A number or code that a service desk analyst can ask the person for when the person contacts the service desk for support.
        /// </summary>
        [XurrentField("supportID")]
        public string? SupportID { get; internal set; }

        [XurrentField("teams")]
        internal PagedResponse<Team>? TeamsCollection { get; set; }
        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        public ReadOnlyDataCollection<Team>? Teams { get => TeamsCollection?.Data is null ? null : new ReadOnlyDataCollection<Team>(TeamsCollection.Data); }

        /// <summary>
        /// Whether the person prefers to see times displayed within the Xurrent service in the 24-hour format or not (in which case the 12-hour format is applied).
        /// </summary>
        [XurrentField("timeFormat24h")]
        public bool? TimeFormat24h { get; internal set; }

        /// <summary>
        /// The time zone in which the person normally resides.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether the person is a very important person.
        /// </summary>
        [XurrentField("vip")]
        public bool? Vip { get; internal set; }

        /// <summary>
        /// Calendar that represents the work hours of the person.
        /// </summary>
        [XurrentField("workHours")]
        public Calendar? WorkHours { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is Person person)
            {
                AddressesCollection?.Data?.AddRange(person.Addresses);
                CartCollection?.Data?.AddRange(person.Cart);
                ConfigurationItemsCollection?.Data?.AddRange(person.ConfigurationItems);
                ContactsCollection?.Data?.AddRange(person.Contacts);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(person.CustomFieldsAttachments);
                InformationAttachmentsCollection?.Data?.AddRange(person.InformationAttachments);
                OutOfOfficePeriodsCollection?.Data?.AddRange(person.OutOfOfficePeriods);
                PermissionsCollection?.Data?.AddRange(person.Permissions);
                SkillPoolsCollection?.Data?.AddRange(person.SkillPools);
                TeamsCollection?.Data?.AddRange(person.Teams);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AddressesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AddressesCollection.GetPageInfo("addresses", depth))
                    yield return pageInfo;

            if (CartCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CartCollection.GetPageInfo("cart", depth))
                    yield return pageInfo;

            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (ContactsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ContactsCollection.GetPageInfo("contacts", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (InformationAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InformationAttachmentsCollection.GetPageInfo("informationAttachments", depth))
                    yield return pageInfo;

            if (OutOfOfficePeriodsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OutOfOfficePeriodsCollection.GetPageInfo("outOfOfficePeriods", depth))
                    yield return pageInfo;

            if (PermissionsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PermissionsCollection.GetPageInfo("permissions", depth))
                    yield return pageInfo;

            if (SkillPoolsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SkillPoolsCollection.GetPageInfo("skillPools", depth))
                    yield return pageInfo;

            if (TeamsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TeamsCollection.GetPageInfo("teams", depth))
                    yield return pageInfo;
        }
    }
}
