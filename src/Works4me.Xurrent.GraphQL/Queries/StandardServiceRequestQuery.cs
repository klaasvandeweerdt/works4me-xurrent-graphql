using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequest"/> query class.
    /// </summary>
    public class StandardServiceRequestQuery : Query<StandardServiceRequest, StandardServiceRequestQuery, DefaultView, StandardServiceRequestField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="StandardServiceRequestQuery"/> instance.
        /// </summary>
        public StandardServiceRequestQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        /// <param name="query">The request template query.</param>
        /// <returns>The same <see cref="StandardServiceRequestQuery"/>, updated to include the "RequestTemplate" sub-query.</returns>
        public StandardServiceRequestQuery SelectRequestTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestTemplate", query, false);
        }

        /// <summary>
        /// The resolution target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        /// <param name="query">The resolution target notification scheme query.</param>
        /// <returns>The same <see cref="StandardServiceRequestQuery"/>, updated to include the "ResolutionTargetNotificationScheme" sub-query.</returns>
        public StandardServiceRequestQuery SelectResolutionTargetNotificationScheme(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("resolutionTargetNotificationScheme", query, false);
        }

        /// <summary>
        /// The response target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        /// <param name="query">The response target notification scheme query.</param>
        /// <returns>The same <see cref="StandardServiceRequestQuery"/>, updated to include the "ResponseTargetNotificationScheme" sub-query.</returns>
        public StandardServiceRequestQuery SelectResponseTargetNotificationScheme(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("responseTargetNotificationScheme", query, false);
        }

        /// <summary>
        /// Service offering the standard service request belongs to.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>The same <see cref="StandardServiceRequestQuery"/>, updated to include the "ServiceOffering" sub-query.</returns>
        public StandardServiceRequestQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOffering", query, false);
        }

        /// <summary>
        /// The calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        /// <param name="query">The support hours query.</param>
        /// <returns>The same <see cref="StandardServiceRequestQuery"/>, updated to include the "SupportHours" sub-query.</returns>
        public StandardServiceRequestQuery SelectSupportHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHours", query, false);
        }
    }
}
