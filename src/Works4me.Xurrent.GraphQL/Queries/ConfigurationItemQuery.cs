﻿using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ConfigurationItem"/> query class.
    /// </summary>
    public class ConfigurationItemQuery : Query<ConfigurationItem, ConfigurationItemQuery, ConfigurationItemView, ConfigurationItemField, ConfigurationItemFilterField, ConfigurationItemOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ConfigurationItemQuery"/> instance.
        /// </summary>
        public ConfigurationItemQuery() : base("configurationItems", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Account" sub-query.</returns>
        public ConfigurationItemQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        /// <param name="query">The ci relations query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "CiRelations" sub-query.</returns>
        public ConfigurationItemQuery SelectCiRelations(ConfigurationItemRelationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("ciRelations", query, true);
        }

        /// <summary>
        /// All contracts of this configuration item.
        /// </summary>
        /// <param name="query">The contracts query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Contracts" sub-query.</returns>
        public ConfigurationItemQuery SelectContracts(ContractQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("contracts", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ConfigurationItemQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ConfigurationItemQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The internal organization which budget is used to pay for the configuration item. If the CI is leased or rented, the organization that pays the lease or rent is selected in this field. When creating a new CI and a value is not specified for this field, it is set to the financial owner of the CI's product.
        /// </summary>
        /// <param name="query">The financial owner query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "FinancialOwner" sub-query.</returns>
        public ConfigurationItemQuery SelectFinancialOwner(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("financialOwner", query, false);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoices query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Invoices" sub-query.</returns>
        public ConfigurationItemQuery SelectInvoices(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("invoices", query, true);
        }

        /// <summary>
        /// Sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        /// <param name="query">The licensed sites query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "LicensedSites" sub-query.</returns>
        public ConfigurationItemQuery SelectLicensedSites(SiteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("licensedSites", query, true);
        }

        /// <summary>
        /// The (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        /// <param name="query">The operating system query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "OperatingSystem" sub-query.</returns>
        public ConfigurationItemQuery SelectOperatingSystem(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("operatingSystem", query, false);
        }

        /// <summary>
        /// All problems of this configuration item.
        /// </summary>
        /// <param name="query">The problems query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Problems" sub-query.</returns>
        public ConfigurationItemQuery SelectProblems(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("problems", query, true);
        }

        /// <summary>
        /// Related product.
        /// </summary>
        /// <param name="query">The product query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Product" sub-query.</returns>
        public ConfigurationItemQuery SelectProduct(ProductQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("product", query, false);
        }

        /// <summary>
        /// Recurrence for maintenance of the configuration item.
        /// </summary>
        /// <param name="query">The recurrence query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Recurrence" sub-query.</returns>
        public ConfigurationItemQuery SelectRecurrence(RecurrenceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("recurrence", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public ConfigurationItemQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// All requests of this configuration item.
        /// </summary>
        /// <param name="query">The requests query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Requests" sub-query.</returns>
        public ConfigurationItemQuery SelectRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requests", query, true);
        }

        /// <summary>
        /// Which service instance(s) the configuration item is, or will be, a part of. When creating a new CI and a value is not specified for this field, it is set to the service of the CI's product.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Service" sub-query.</returns>
        public ConfigurationItemQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// All service instances of this configuration item.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public ConfigurationItemQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// Where the CI is located, if it concerns a hardware CI.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Site" sub-query.</returns>
        public ConfigurationItemQuery SelectSite(SiteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("site", query, false);
        }

        /// <summary>
        /// The supplier from which the configuration item (CI) has been obtained. When creating a new CI and a value is not specified for this field, it is set to the supplier of the CI's product.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public ConfigurationItemQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The account of the team that supports this configuration item.
        /// </summary>
        /// <param name="query">The support account query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "SupportAccount" sub-query.</returns>
        public ConfigurationItemQuery SelectSupportAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportAccount", query, false);
        }

        /// <summary>
        /// The team responsible for supporting the configuration item and maintaining its information in the configuration management database (CMDB). When creating a new CI and a value is not specified for this field, it is set to the support team of the CI's product. Optional when status of CI equals "Removed", required otherwise.
        /// </summary>
        /// <param name="query">The support team query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "SupportTeam" sub-query.</returns>
        public ConfigurationItemQuery SelectSupportTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportTeam", query, false);
        }

        /// <summary>
        /// All users of this configuration item.
        /// </summary>
        /// <param name="query">The users query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "Users" sub-query.</returns>
        public ConfigurationItemQuery SelectUsers(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("users", query, true);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        /// <param name="query">The workflow manager query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "WorkflowManager" sub-query.</returns>
        public ConfigurationItemQuery SelectWorkflowManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowManager", query, false);
        }

        /// <summary>
        /// The workflow template that is used to periodically maintain the configuration item.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery"/>, updated to include the "WorkflowTemplate" sub-query.</returns>
        public ConfigurationItemQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowTemplate", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="ConfigurationItem">ConfigurationItem</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/configurationitemcustomfilter/">Xurrent developer site</see>.</br>
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
        public ConfigurationItemQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ConfigurationItemQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ConfigurationItemQuery">ConfigurationItemQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ConfigurationItemQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
