using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ServiceLevelAgreement"/> query class.
    /// </summary>
    public class ServiceLevelAgreementQuery : Query<ServiceLevelAgreement, ServiceLevelAgreementQuery, ServiceLevelAgreementView, ServiceLevelAgreementField, ServiceLevelAgreementFilterField, ServiceLevelAgreementOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ServiceLevelAgreementQuery"/> instance.
        /// </summary>
        public ServiceLevelAgreementQuery() : base("serviceLevelAgreements", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "Account" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. This contains the activityIDs related to request categories.
        /// </summary>
        /// <param name="query">The activity id query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "ActivityID" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectActivityID(ActivityIDQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("activityID", query, false);
        }

        /// <summary>
        /// Coverage groups of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>coverage_groups</c>.
        /// </summary>
        /// <param name="query">The coverage groups query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "CoverageGroups" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectCoverageGroups(SlaCoverageGroupQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("coverageGroups", query, true);
        }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        /// <param name="query">The customer query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "Customer" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectCustomer(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customer", query, false);
        }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        /// <param name="query">The customer account query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "CustomerAccount" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectCustomerAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerAccount", query, false);
        }

        /// <summary>
        /// The people who represent the customer organization for the service level agreement.
        /// </summary>
        /// <param name="query">The customer representatives query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "CustomerRepresentatives" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectCustomerRepresentatives(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customerRepresentatives", query, true);
        }

        /// <summary>
        /// The Rate IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider.
        /// </summary>
        /// <param name="query">The effort class rate i ds query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "EffortClassRateIDs" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectEffortClassRateIDs(EffortClassRateIDQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClassRateIDs", query, true);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoices query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "Invoices" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectInvoices(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("invoices", query, true);
        }

        /// <summary>
        /// Organizations of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>organizations_and_descendants</c>, <c>organizations</c> or <c>organizations_and_sites</c>.
        /// </summary>
        /// <param name="query">The organizations query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "Organizations" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectOrganizations(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organizations", query, true);
        }

        /// <summary>
        /// People of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>people</c>.
        /// </summary>
        /// <param name="query">The people query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "People" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectPeople(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("people", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// The service instance that will be used to provide the service to the customer of the service level agreement. Only service instances that are linked to the same service as the selected service offering can be selected.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }

        /// <summary>
        /// The service instances that consume the service instance for which the service level agreement is registered. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectServiceInstances(ParentServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// The person of the service provider organization who acts as the service level manager for the customer of the service level agreement.
        /// </summary>
        /// <param name="query">The service level manager query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "ServiceLevelManager" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectServiceLevelManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceLevelManager", query, false);
        }

        /// <summary>
        /// Service offering that specifies the conditions that apply to the service level agreement.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "ServiceOffering" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOffering", query, false);
        }

        /// <summary>
        /// Sites of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>sites</c> or <c>organizations_and_sites</c>.
        /// </summary>
        /// <param name="query">The sites query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "Sites" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectSites(SiteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sites", query, true);
        }

        /// <summary>
        /// Skill pools of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>skill_pools</c>.
        /// </summary>
        /// <param name="query">The skill pools query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "SkillPools" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectSkillPools(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPools", query, true);
        }

        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        /// <param name="query">The standard service request activity i ds query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "StandardServiceRequestActivityIDs" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectStandardServiceRequestActivityIDs(StandardServiceRequestActivityIDQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("standardServiceRequestActivityIDs", query, true);
        }

        /// <summary>
        /// The support domain account that offers the support to users covered by this the service level agreement.
        /// </summary>
        /// <param name="query">The support domain query.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery"/>, updated to include the "SupportDomain" sub-query.</returns>
        public ServiceLevelAgreementQuery SelectSupportDomain(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportDomain", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ServiceLevelAgreementQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ServiceLevelAgreementQuery">ServiceLevelAgreementQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ServiceLevelAgreementQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
