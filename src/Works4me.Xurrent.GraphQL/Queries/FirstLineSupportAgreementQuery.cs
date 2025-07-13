using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="FirstLineSupportAgreement"/> query class.
    /// </summary>
    public class FirstLineSupportAgreementQuery : Query<FirstLineSupportAgreement, FirstLineSupportAgreementQuery, FirstLineSupportAgreementView, FirstLineSupportAgreementField, FirstLineSupportAgreementFilterField, FirstLineSupportAgreementOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="FirstLineSupportAgreementQuery"/> instance.
        /// </summary>
        public FirstLineSupportAgreementQuery() : base("firstLineSupportAgreements", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "Account" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        /// <param name="query">The charges attachments query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "ChargesAttachments" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectChargesAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("chargesAttachments", query, true);
        }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        /// <param name="query">The customer query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "Customer" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectCustomer(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customer", query, false);
        }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        /// <param name="query">The customer account query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "CustomerAccount" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectCustomerAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerAccount", query, false);
        }

        /// <summary>
        /// The person who represents the customer organization for the first line support agreement.
        /// </summary>
        /// <param name="query">The customer representative query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "CustomerRepresentative" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectCustomerRepresentative(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerRepresentative", query, false);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoices query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "Invoices" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectInvoices(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("invoices", query, true);
        }

        /// <summary>
        /// The people who can assume the role of major incident manager for the organization that is covered by the first line support agreement.
        /// </summary>
        /// <param name="query">The major incident managers query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "MajorIncidentManagers" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectMajorIncidentManagers(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("majorIncidentManagers", query, true);
        }

        /// <summary>
        /// Organization that provides the first line support agreement.
        /// </summary>
        /// <param name="query">The provider query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "Provider" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectProvider(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("provider", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// The specific team within the first line support provider organization that provides first line support for the users covered by the first line support agreement.
        /// </summary>
        /// <param name="query">The service desk team query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "ServiceDeskTeam" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectServiceDeskTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceDeskTeam", query, false);
        }

        /// <summary>
        /// Calendar that defines the support hours during which the service desk team can be contacted for first line support.
        /// </summary>
        /// <param name="query">The support hours query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "SupportHours" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectSupportHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHours", query, false);
        }

        /// <summary>
        /// Inline images linked to the Target details field.
        /// </summary>
        /// <param name="query">The target details attachments query.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery"/>, updated to include the "TargetDetailsAttachments" sub-query.</returns>
        public FirstLineSupportAgreementQuery SelectTargetDetailsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("targetDetailsAttachments", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="FirstLineSupportAgreementQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="FirstLineSupportAgreementQuery">FirstLineSupportAgreementQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public FirstLineSupportAgreementQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
