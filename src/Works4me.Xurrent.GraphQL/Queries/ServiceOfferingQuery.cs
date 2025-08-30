using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ServiceOffering"/> query class.
    /// </summary>
    public class ServiceOfferingQuery : Query<ServiceOffering, ServiceOfferingQuery, ServiceOfferingView, ServiceOfferingField, ServiceOfferingFilterField, ServiceOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ServiceOfferingQuery"/> instance.
        /// </summary>
        public ServiceOfferingQuery() : base("serviceOfferings", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "Account" sub-query.</returns>
        public ServiceOfferingQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        /// <param name="query">The charges attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ChargesAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectChargesAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("chargesAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Continuity field.
        /// </summary>
        /// <param name="query">The continuity attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ContinuityAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectContinuityAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("continuityAttachments", query, true);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request with an active affected SLA based on the service offering.
        /// </summary>
        /// <param name="query">The default effort class query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "DefaultEffortClass" sub-query.</returns>
        public ServiceOfferingQuery SelectDefaultEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("defaultEffortClass", query, false);
        }

        /// <summary>
        /// Effort class rates of the service offering.
        /// </summary>
        /// <param name="query">The effort class rates query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "EffortClassRates" sub-query.</returns>
        public ServiceOfferingQuery SelectEffortClassRates(EffortClassRateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClassRates", query, true);
        }

        /// <summary>
        /// Effort classes of the service offering.
        /// </summary>
        /// <param name="query">The effort classes query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "EffortClasses" sub-query.</returns>
        public ServiceOfferingQuery SelectEffortClasses(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClasses", query, true);
        }

        /// <summary>
        /// Inline images linked to the Limitations field.
        /// </summary>
        /// <param name="query">The limitations attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "LimitationsAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectLimitationsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("limitationsAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Penalties field.
        /// </summary>
        /// <param name="query">The penalties attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "PenaltiesAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectPenaltiesAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("penaltiesAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Performance field.
        /// </summary>
        /// <param name="query">The performance attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "PerformanceAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectPerformanceAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("performanceAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Prerequisites field.
        /// </summary>
        /// <param name="query">The prerequisites attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "PrerequisitesAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectPrerequisitesAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("prerequisitesAttachments", query, true);
        }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The resolution target notification scheme high query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResolutionTargetNotificationSchemeHigh" sub-query.</returns>
        public ServiceOfferingQuery SelectResolutionTargetNotificationSchemeHigh(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("resolutionTargetNotificationSchemeHigh", query, false);
        }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The resolution target notification scheme low query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResolutionTargetNotificationSchemeLow" sub-query.</returns>
        public ServiceOfferingQuery SelectResolutionTargetNotificationSchemeLow(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("resolutionTargetNotificationSchemeLow", query, false);
        }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The resolution target notification scheme medium query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResolutionTargetNotificationSchemeMedium" sub-query.</returns>
        public ServiceOfferingQuery SelectResolutionTargetNotificationSchemeMedium(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("resolutionTargetNotificationSchemeMedium", query, false);
        }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The resolution target notification scheme top query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResolutionTargetNotificationSchemeTop" sub-query.</returns>
        public ServiceOfferingQuery SelectResolutionTargetNotificationSchemeTop(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("resolutionTargetNotificationSchemeTop", query, false);
        }

        /// <summary>
        /// The response target notification scheme for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The response target notification scheme high query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResponseTargetNotificationSchemeHigh" sub-query.</returns>
        public ServiceOfferingQuery SelectResponseTargetNotificationSchemeHigh(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("responseTargetNotificationSchemeHigh", query, false);
        }

        /// <summary>
        /// The response target notification scheme for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The response target notification scheme low query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResponseTargetNotificationSchemeLow" sub-query.</returns>
        public ServiceOfferingQuery SelectResponseTargetNotificationSchemeLow(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("responseTargetNotificationSchemeLow", query, false);
        }

        /// <summary>
        /// The response target notification scheme for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The response target notification scheme medium query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResponseTargetNotificationSchemeMedium" sub-query.</returns>
        public ServiceOfferingQuery SelectResponseTargetNotificationSchemeMedium(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("responseTargetNotificationSchemeMedium", query, false);
        }

        /// <summary>
        /// The response target notification scheme for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The response target notification scheme top query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ResponseTargetNotificationSchemeTop" sub-query.</returns>
        public ServiceOfferingQuery SelectResponseTargetNotificationSchemeTop(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("responseTargetNotificationSchemeTop", query, false);
        }

        /// <summary>
        /// The service for which the service offering is being prepared.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "Service" sub-query.</returns>
        public ServiceOfferingQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Calendar that defines the hours during which the service is supposed to be available.
        /// </summary>
        /// <param name="query">The service hours query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ServiceHours" sub-query.</returns>
        public ServiceOfferingQuery SelectServiceHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceHours", query, false);
        }

        /// <summary>
        /// Service level agreements of the service offering.
        /// </summary>
        /// <param name="query">The service level agreements query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ServiceLevelAgreements" sub-query.</returns>
        public ServiceOfferingQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceLevelAgreements", query, true);
        }

        /// <summary>
        /// Shop articles related to the service offering.
        /// </summary>
        /// <param name="query">The shop articles query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "ShopArticles" sub-query.</returns>
        public ServiceOfferingQuery SelectShopArticles(ShopArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("shopArticles", query, true);
        }

        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        /// <param name="query">The standard service requests query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "StandardServiceRequests" sub-query.</returns>
        public ServiceOfferingQuery SelectStandardServiceRequests(StandardServiceRequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("standardServiceRequests", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Summary field.
        /// </summary>
        /// <param name="query">The summary attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SummaryAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectSummaryAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("summaryAttachments", query, true);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours case query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursCase" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursCase(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursCase", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours high query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursHigh" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursHigh(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursHigh", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours low query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursLow" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursLow(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursLow", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours medium query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursMedium" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursMedium(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursMedium", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours rfc query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursRfc" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursRfc(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursRfc", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours rfi query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursRfi" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursRfi(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursRfi", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours top query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "SupportHoursTop" sub-query.</returns>
        public ServiceOfferingQuery SelectSupportHoursTop(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHoursTop", query, false);
        }

        /// <summary>
        /// Inline images linked to the Termination field.
        /// </summary>
        /// <param name="query">The termination attachments query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "TerminationAttachments" sub-query.</returns>
        public ServiceOfferingQuery SelectTerminationAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("terminationAttachments", query, true);
        }

        /// <summary>
        /// The waiting for customer follow-up for a request when it remains in status waiting for customer and has an active SLA that is based on this service offering. Only enabled waiting for customer follow-ups that are linked to the same account as the service offering can be selected.
        /// </summary>
        /// <param name="query">The waiting for customer follow up query.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery"/>, updated to include the "WaitingForCustomerFollowUp" sub-query.</returns>
        public ServiceOfferingQuery SelectWaitingForCustomerFollowUp(WaitingForCustomerFollowUpQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("waitingForCustomerFollowUp", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ServiceOfferingQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ServiceOfferingQuery">ServiceOfferingQuery</see>, updated to include the "Search" sub-query.</returns>
        public ServiceOfferingQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
