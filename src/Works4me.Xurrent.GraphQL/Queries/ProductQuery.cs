using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Product"/> query class.
    /// </summary>
    public class ProductQuery : Query<Product, ProductQuery, ProductView, ProductField, ProductFilterField, ProductOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProductQuery"/> instance.
        /// </summary>
        public ProductQuery() : base("products", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProductQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Configuration items of the product.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public ProductQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ProductQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ProductQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The internal organization which budget is normally used to obtain the product.
        /// </summary>
        /// <param name="query">The financial owner query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "FinancialOwner" sub-query.</returns>
        public ProductQuery SelectFinancialOwner(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("financialOwner", query, false);
        }

        /// <summary>
        /// The appropriate product category for the product.
        /// </summary>
        /// <param name="query">The product category query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "ProductCategory" sub-query.</returns>
        public ProductQuery SelectProductCategory(ProductCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("productCategory", query, false);
        }

        /// <summary>
        /// Recurrence for maintenance of configuration items created from the product.
        /// </summary>
        /// <param name="query">The recurrence query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "Recurrence" sub-query.</returns>
        public ProductQuery SelectRecurrence(RecurrenceTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("recurrence", query, false);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public ProductQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// The Service which Service Instances would typically include the product.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "Service" sub-query.</returns>
        public ProductQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// The organization from which the product is typically obtained. If the product is developed internally, select the internal organization that develops it. Note that a lease company should be selected in this field if the product is normally leased.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public ProductQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The team responsible for maintaining the product's information in the configuration management database (CMDB).
        /// </summary>
        /// <param name="query">The support team query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "SupportTeam" sub-query.</returns>
        public ProductQuery SelectSupportTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportTeam", query, false);
        }

        /// <summary>
        /// UI extension that is to be added to the configuration items that are based on the product.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ProductQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        /// <param name="query">The workflow manager query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "WorkflowManager" sub-query.</returns>
        public ProductQuery SelectWorkflowManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowManager", query, false);
        }

        /// <summary>
        /// The workflow template that is used to periodically maintain configuration items created from the product.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>The same <see cref="ProductQuery"/>, updated to include the "WorkflowTemplate" sub-query.</returns>
        public ProductQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowTemplate", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Product">Product</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/productcustomfilter/">Xurrent developer site</see>.</br>
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
        public ProductQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProductQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProductQuery">ProductQuery</see>, updated to include the "Search" sub-query.</returns>
        public ProductQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
