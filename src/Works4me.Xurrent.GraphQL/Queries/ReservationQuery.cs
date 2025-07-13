using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Reservation"/> query class.
    /// </summary>
    public class ReservationQuery : Query<Reservation, ReservationQuery, ReservationView, ReservationField, ReservationFilterField, ReservationOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ReservationQuery"/> instance.
        /// </summary>
        public ReservationQuery() : base("reservations", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "Account" sub-query.</returns>
        public ReservationQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The asset that is being reserved.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "ConfigurationItem" sub-query.</returns>
        public ReservationQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItem", query, false);
        }

        /// <summary>
        /// The person who created this reservation.
        /// </summary>
        /// <param name="query">The created by query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "CreatedBy" sub-query.</returns>
        public ReservationQuery SelectCreatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("createdBy", query, false);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public ReservationQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// The person for whom this reservation was created.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "Person" sub-query.</returns>
        public ReservationQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }

        /// <summary>
        /// Recurrency for the reservation.
        /// </summary>
        /// <param name="query">The recurrence query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "Recurrence" sub-query.</returns>
        public ReservationQuery SelectRecurrence(RecurrenceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("recurrence", query, false);
        }

        /// <summary>
        /// The link to the request for reservation.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "Request" sub-query.</returns>
        public ReservationQuery SelectRequest(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("request", query, false);
        }

        /// <summary>
        /// The link to the reservation offering that was related to the request template used to request the reservation.
        /// </summary>
        /// <param name="query">The reservation offering query.</param>
        /// <returns>The same <see cref="ReservationQuery"/>, updated to include the "ReservationOffering" sub-query.</returns>
        public ReservationQuery SelectReservationOffering(ReservationOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("reservationOffering", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ReservationQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ReservationQuery">ReservationQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ReservationQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
