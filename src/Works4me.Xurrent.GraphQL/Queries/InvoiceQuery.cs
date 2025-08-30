using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Invoice"/> query class.
    /// </summary>
    public class InvoiceQuery : Query<Invoice, InvoiceQuery, InvoiceView, InvoiceField, InvoiceFilterField, InvoiceOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="InvoiceQuery"/> instance.
        /// </summary>
        public InvoiceQuery() : base("invoices", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Account" sub-query.</returns>
        public InvoiceQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public InvoiceQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// The contract linked to this invoice.
        /// </summary>
        /// <param name="query">The contract query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Contract" sub-query.</returns>
        public InvoiceQuery SelectContract(ContractQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("contract", query, false);
        }

        /// <summary>
        /// The first line support agreement linked to this invoice.
        /// </summary>
        /// <param name="query">The flsa query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Flsa" sub-query.</returns>
        public InvoiceQuery SelectFlsa(FirstLineSupportAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("flsa", query, false);
        }

        /// <summary>
        /// The project linked to this invoice.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Project" sub-query.</returns>
        public InvoiceQuery SelectProject(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("project", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public InvoiceQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// The service that covers this invoice.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Service" sub-query.</returns>
        public InvoiceQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// The service level agreement linked to this invoice.
        /// </summary>
        /// <param name="query">The sla query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Sla" sub-query.</returns>
        public InvoiceQuery SelectSla(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sla", query, false);
        }

        /// <summary>
        /// The organization from which the invoice was received.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public InvoiceQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The workflow linked to this invoice.
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>The same <see cref="InvoiceQuery"/>, updated to include the "Workflow" sub-query.</returns>
        public InvoiceQuery SelectWorkflow(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflow", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="InvoiceQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="InvoiceQuery">InvoiceQuery</see>, updated to include the "Search" sub-query.</returns>
        public InvoiceQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
