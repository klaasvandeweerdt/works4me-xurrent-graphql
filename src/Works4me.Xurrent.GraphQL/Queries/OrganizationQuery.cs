using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Organization"/> query class.
    /// </summary>
    public class OrganizationQuery : Query<Organization, OrganizationQuery, OrganizationView, OrganizationField, OrganizationFilterField, OrganizationOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="OrganizationQuery"/> instance.
        /// </summary>
        public OrganizationQuery() : base("organizations", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Account" sub-query.</returns>
        public OrganizationQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        /// <param name="query">The addresses query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Addresses" sub-query.</returns>
        public OrganizationQuery SelectAddresses(AddressQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("addresses", query, true);
        }

        /// <summary>
        /// Refers to itself if the organization is a business unit, or refers to the business unit that the organization belongs to.
        /// </summary>
        /// <param name="query">The business unit organization query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "BusinessUnitOrganization" sub-query.</returns>
        public OrganizationQuery SelectBusinessUnitOrganization(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("businessUnitOrganization", query, false);
        }

        /// <summary>
        /// Child organizations of this organization, i.e. organizations that have this organization as their parent.
        /// </summary>
        /// <param name="query">The child organizations query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "ChildOrganizations" sub-query.</returns>
        public OrganizationQuery SelectChildOrganizations(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("childOrganizations", query, true);
        }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        /// <param name="query">The contacts query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Contacts" sub-query.</returns>
        public OrganizationQuery SelectContacts(ContactQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("contacts", query, true);
        }

        /// <summary>
        /// Contracts of this organization.
        /// </summary>
        /// <param name="query">The contracts query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Contracts" sub-query.</returns>
        public OrganizationQuery SelectContracts(ContractQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("contracts", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public OrganizationQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public OrganizationQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The manager of the organization.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Manager" sub-query.</returns>
        public OrganizationQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// Refers to the order template that is used for purchases of people defined in this organization or its descendants.
        /// </summary>
        /// <param name="query">The order template query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "OrderTemplate" sub-query.</returns>
        public OrganizationQuery SelectOrderTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("orderTemplate", query, false);
        }

        /// <summary>
        /// The organization's parent organization.
        /// </summary>
        /// <param name="query">The parent query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Parent" sub-query.</returns>
        public OrganizationQuery SelectParent(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("parent", query, false);
        }

        /// <summary>
        /// People of this organization.
        /// </summary>
        /// <param name="query">The people query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "People" sub-query.</returns>
        public OrganizationQuery SelectPeople(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("people", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public OrganizationQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// Risks of this organization.
        /// </summary>
        /// <param name="query">The risks query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Risks" sub-query.</returns>
        public OrganizationQuery SelectRisks(RiskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("risks", query, true);
        }

        /// <summary>
        /// Service level agreements which coverage field is set to <c>organizations</c> and which cover the organization.
        /// </summary>
        /// <param name="query">The service level agreements query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "ServiceLevelAgreements" sub-query.</returns>
        public OrganizationQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceLevelAgreements", query, true);
        }

        /// <summary>
        /// The person who acts as the substitute of the organization's manager.
        /// </summary>
        /// <param name="query">The substitute query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "Substitute" sub-query.</returns>
        public OrganizationQuery SelectSubstitute(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("substitute", query, false);
        }

        /// <summary>
        /// Time allocations of this organization.
        /// </summary>
        /// <param name="query">The time allocations query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "TimeAllocations" sub-query.</returns>
        public OrganizationQuery SelectTimeAllocations(TimeAllocationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeAllocations", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="OrganizationQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public OrganizationQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Organization">Organization</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/organizationcustomfilter/">Xurrent developer site</see>.</br>
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
        public OrganizationQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="OrganizationQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="OrganizationQuery">OrganizationQuery</see>, updated to include the "Search" sub-query.</returns>
        public OrganizationQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
