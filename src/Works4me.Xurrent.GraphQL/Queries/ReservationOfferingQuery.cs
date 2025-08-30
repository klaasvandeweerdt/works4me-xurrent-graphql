using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ReservationOffering"/> query class.
    /// </summary>
    public class ReservationOfferingQuery : Query<ReservationOffering, ReservationOfferingQuery, ReservationOfferingView, ReservationOfferingField, ReservationOfferingFilterField, ReservationOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ReservationOfferingQuery"/> instance.
        /// </summary>
        public ReservationOfferingQuery() : base("reservationOfferings", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ReservationOfferingQuery"/>, updated to include the "Account" sub-query.</returns>
        public ReservationOfferingQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The Calendar field is used to select the calendar that defines the hours during which the configuration items can be made available for temporary use.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>The same <see cref="ReservationOfferingQuery"/>, updated to include the "Calendar" sub-query.</returns>
        public ReservationOfferingQuery SelectCalendar(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("calendar", query, false);
        }

        /// <summary>
        /// The Configuration items field is used to select the configuration items that people, who are covered by an active service level agreement for the related service instance, should be able to reserve for temporary use after the reservation offering is related to a request template of the category ‘Reservation’.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="ReservationOfferingQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public ReservationOfferingQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// The Request templates table field lists the request templates to which the reservation offering is linked.
        /// </summary>
        /// <param name="query">The request templates query.</param>
        /// <returns>The same <see cref="ReservationOfferingQuery"/>, updated to include the "RequestTemplates" sub-query.</returns>
        public ReservationOfferingQuery SelectRequestTemplates(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestTemplates", query, true);
        }

        /// <summary>
        /// The Service instance field is used to select the service instance for which people need to be covered in order to be able to make use of the reservation offering.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="ReservationOfferingQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public ReservationOfferingQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ReservationOfferingQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ReservationOfferingQuery">ReservationOfferingQuery</see>, updated to include the "Search" sub-query.</returns>
        public ReservationOfferingQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
