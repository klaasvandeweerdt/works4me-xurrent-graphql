using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Contract"/> query class.
    /// </summary>
    public class ContractQuery : Query<Contract, ContractQuery, ContractView, ContractField, ContractFilterField, ContractOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ContractQuery"/> instance.
        /// </summary>
        public ContractQuery() : base("contracts", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "Account" sub-query.</returns>
        public ContractQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// All configuration items of the contract.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public ContractQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ContractQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ContractQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        /// <param name="query">The customer query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "Customer" sub-query.</returns>
        public ContractQuery SelectCustomer(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customer", query, false);
        }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        /// <param name="query">The customer account query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "CustomerAccount" sub-query.</returns>
        public ContractQuery SelectCustomerAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerAccount", query, false);
        }

        /// <summary>
        /// The person who represents the customer organization for the contract.
        /// </summary>
        /// <param name="query">The customer representative query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "CustomerRepresentative" sub-query.</returns>
        public ContractQuery SelectCustomerRepresentative(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerRepresentative", query, false);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoices query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "Invoices" sub-query.</returns>
        public ContractQuery SelectInvoices(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("invoices", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public ContractQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// The organization that has provided the contract to the customer.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public ContractQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The person who represents the supplier of the contract.
        /// </summary>
        /// <param name="query">The supplier contact query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "SupplierContact" sub-query.</returns>
        public ContractQuery SelectSupplierContact(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplierContact", query, false);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ContractQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ContractQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Contract">Contract</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/contractcustomfilter/">Xurrent developer site</see>.</br>
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
        public ContractQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ContractQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ContractQuery">ContractQuery</see>, updated to include the "Search" sub-query.</returns>
        public ContractQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
