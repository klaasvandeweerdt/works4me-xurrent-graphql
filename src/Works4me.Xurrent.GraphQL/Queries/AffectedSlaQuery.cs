using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AffectedSla"/> query class.
    /// </summary>
    public class AffectedSlaQuery : Query<AffectedSla, AffectedSlaQuery, AffectedSlaView, AffectedSlaField, AffectedSlaFilterField, AffectedSlaOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AffectedSlaQuery"/> instance.
        /// </summary>
        public AffectedSlaQuery() : base("affectedSlas", true)
        {
        }

        /// <summary>
        /// The First line team field is automatically set to the team that, at the time the affected SLA was created, was selected in the First line team field of the related service instance.
        /// </summary>
        /// <param name="query">The first line team query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "FirstLineTeam" sub-query.</returns>
        public AffectedSlaQuery SelectFirstLineTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("firstLineTeam", query, false);
        }

        /// <summary>
        /// The Request field is automatically set to the request for which the affected SLA was generated.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "Request" sub-query.</returns>
        public AffectedSlaQuery SelectRequest(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("request", query, false);
        }

        /// <summary>
        /// If the impact of the affected SLA is "Top - Service Down for Several Users", the Service hours field is automatically set to the service hours calendar of the service offering of the related service level agreement.
        /// </summary>
        /// <param name="query">The service hours query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "ServiceHours" sub-query.</returns>
        public AffectedSlaQuery SelectServiceHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceHours", query, false);
        }

        /// <summary>
        /// The Service instance field is automatically set to the Service Instance that, at the time the affected SLA was created, was selected in the Service instance field of the related service level agreement.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public AffectedSlaQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }

        /// <summary>
        /// The Service level agreement field is automatically set to the service level agreement that is considered affected.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "ServiceLevelAgreement" sub-query.</returns>
        public AffectedSlaQuery SelectServiceLevelAgreement(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceLevelAgreement", query, false);
        }

        /// <summary>
        /// The Standard service request field is automatically set to the standard service request that is linked to the service offering of the service level agreement and which response and resolution targets were used to calculate the <c>responseTargetAt</c> and <c>resolutionTargetAt</c> for the affected SLA.
        /// </summary>
        /// <param name="query">The standard service request query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "StandardServiceRequest" sub-query.</returns>
        public AffectedSlaQuery SelectStandardServiceRequest(StandardServiceRequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("standardServiceRequest", query, false);
        }

        /// <summary>
        /// A list of time periods between which the clock was stopped for this affected SLA.
        /// </summary>
        /// <param name="query">The stopped clock periods query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "StoppedClockPeriods" sub-query.</returns>
        public AffectedSlaQuery SelectStoppedClockPeriods(PeriodQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("stoppedClockPeriods", query, false);
        }

        /// <summary>
        /// The Supplier field is automatically set to the Organization that, at the time the affected SLA was created, was selected in the Service provider field of the related service instance. This field is only filled out, however, if this service provider is an external organization.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public AffectedSlaQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The Support hours field is automatically set to the support hours Calendar that was selected for the impact level specified above in the service offering of the related service level agreement.
        /// </summary>
        /// <param name="query">The support hours query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "SupportHours" sub-query.</returns>
        public AffectedSlaQuery SelectSupportHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHours", query, false);
        }

        /// <summary>
        /// The Support team field is automatically set to the team that, at the time the affected SLA was created, was selected in the Support team field of the related service instance.
        /// </summary>
        /// <param name="query">The support team query.</param>
        /// <returns>The same <see cref="AffectedSlaQuery"/>, updated to include the "SupportTeam" sub-query.</returns>
        public AffectedSlaQuery SelectSupportTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportTeam", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="AffectedSlaQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="AffectedSlaQuery">AffectedSlaQuery</see>, updated to include the "Search" sub-query.</returns>
        public AffectedSlaQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
