using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Person"/> query class.
    /// </summary>
    public class PersonQuery : Query<Person, PersonQuery, PersonView, PersonField, PersonFilterField, PersonOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="PersonQuery"/> instance.
        /// </summary>
        public PersonQuery() : base("people", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Account" sub-query.</returns>
        public PersonQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        /// <param name="query">The addresses query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Addresses" sub-query.</returns>
        public PersonQuery SelectAddresses(AddressQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("addresses", query, true);
        }

        /// <summary>
        /// The shop order lines related to this person with status in_cart.
        /// </summary>
        /// <param name="query">The cart query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Cart" sub-query.</returns>
        public PersonQuery SelectCart(ShopOrderLineQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("cart", query, true);
        }

        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public PersonQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        /// <param name="query">The contacts query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Contacts" sub-query.</returns>
        public PersonQuery SelectContacts(ContactQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("contacts", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public PersonQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public PersonQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The information attachments query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "InformationAttachments" sub-query.</returns>
        public PersonQuery SelectInformationAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("informationAttachments", query, true);
        }

        /// <summary>
        /// The manager or supervisor to whom the person reports.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Manager" sub-query.</returns>
        public PersonQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// The organization for which the person works as an employee or long-term contractor.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Organization" sub-query.</returns>
        public PersonQuery SelectOrganization(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organization", query, false);
        }

        /// <summary>
        /// Out of office periods for this person.
        /// </summary>
        /// <param name="query">The out of office periods query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "OutOfOfficePeriods" sub-query.</returns>
        public PersonQuery SelectOutOfOfficePeriods(OutOfOfficePeriodQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("outOfOfficePeriods", query, true);
        }

        /// <summary>
        /// Permissions of this person.
        /// </summary>
        /// <param name="query">The permissions query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Permissions" sub-query.</returns>
        public PersonQuery SelectPermissions(PermissionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("permissions", query, true);
        }

        /// <summary>
        /// Where the person is stationed.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Site" sub-query.</returns>
        public PersonQuery SelectSite(SiteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("site", query, false);
        }

        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        /// <param name="query">The skill pools query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "SkillPools" sub-query.</returns>
        public PersonQuery SelectSkillPools(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPools", query, true);
        }

        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        /// <param name="query">The teams query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "Teams" sub-query.</returns>
        public PersonQuery SelectTeams(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("teams", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public PersonQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Calendar that represents the work hours of the person.
        /// </summary>
        /// <param name="query">The work hours query.</param>
        /// <returns>The same <see cref="PersonQuery"/>, updated to include the "WorkHours" sub-query.</returns>
        public PersonQuery SelectWorkHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workHours", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Person">Person</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/personcustomfilter/">Xurrent developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">
        /// Use value <c>null</c> to indicate "None".
        /// 
        /// For "text" fields:
        /// • One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).
        /// 
        /// For "number" and "time" fields:
        /// • One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.
        /// • Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.
        /// • <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.
        /// • <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.
        /// 
        /// For "date" and "date-time" fields:
        /// • One must supply a single value (and <c>null</c> is not supported).
        /// • Matches are always relative with an optional upper bound.
        /// • Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).
        /// • Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).
        /// • <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.
        /// 
        /// For "select" fields:
        /// • One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).
        /// • Matches are case-sensitive.
        /// </param>
        public PersonQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="PersonQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="PersonQuery">PersonQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public PersonQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
