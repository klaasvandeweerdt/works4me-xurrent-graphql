using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservationoffering/">ReservationOffering</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ReservationOffering")]
    public sealed class ReservationOffering : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether it is allowed to create recurrent reservations for this offering.
        /// </summary>
        [XurrentField("allowRepeat")]
        public bool? AllowRepeat { get; internal set; }

        /// <summary>
        /// The Calendar field is used to select the calendar that defines the hours during which the configuration items can be made available for temporary use.
        /// </summary>
        [XurrentField("calendar")]
        public Calendar? Calendar { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// The Configuration items field is used to select the configuration items that people, who are covered by an active service level agreement for the related service instance, should be able to reserve for temporary use after the reservation offering is related to a request template of the category ‘Reservation’.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the reservation offering may not be used to register requests for reservation.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The Filters field allows filters to be selected that people, who are selecting a configuration item of the reservation offering, can use to limit the list of configuration items to only those that meet specific criteria, such as the configuration item’s product or site.
        /// </summary>
        [XurrentField("filters")]
        public IReadOnlyList<string>? Filters { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The Initial status field is used to specify whether a reservation that was requested using the reservation offering is immediately confirmed after it has been submitted, or that an action (such as an approval) is still required before it can be confirmed.
        /// </summary>
        [XurrentField("initialStatus")]
        public ReservationStatus? InitialStatus { get; internal set; }

        /// <summary>
        /// The Max. advance duration field is used to specify how far in the future the start of a reservation is allowed to be scheduled using the reservation offering.
        /// </summary>
        [XurrentField("maxAdvanceDuration")]
        public long? MaxAdvanceDuration { get; internal set; }

        /// <summary>
        /// The Max. duration field is used to specify the maximum length of time for which a configuration item of the reservation offering can be reserved.
        /// </summary>
        [XurrentField("maxDuration")]
        public long? MaxDuration { get; internal set; }

        /// <summary>
        /// The Min. advance duration field is used to specify how much advance notice is needed from the moment a reservation is requested using the reservation offering and the start of the reservation. This is typically the time needed to prepare a configuration item of the reservation offering.
        /// </summary>
        [XurrentField("minAdvanceDuration")]
        public long? MinAdvanceDuration { get; internal set; }

        /// <summary>
        /// The Min. duration field is used to specify the minimum length of time for which a configuration item of the reservation offering can be reserved.
        /// </summary>
        [XurrentField("minDuration")]
        public long? MinDuration { get; internal set; }

        /// <summary>
        /// The Multi-day box is checked when a reservation request that uses the reservation offering is allowed to start on one day and end on another.
        /// </summary>
        [XurrentField("multiDay")]
        public bool? MultiDay { get; internal set; }

        /// <summary>
        /// A short description of the reservation offering.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The Preparation duration field is used to specify the amount of time needed to prepare a configuration item of the reservation offering for the next person who reserved it. People are not be able to request a reservation of a configuration item if it overlaps with the preparation duration of an existing reservation for the same configuration item.
        /// </summary>
        [XurrentField("preparationDuration")]
        public long? PreparationDuration { get; internal set; }

        /// <summary>
        /// Reservations of this reservation offering are private and can not be viewed by other end users.
        /// </summary>
        [XurrentField("privateReservations")]
        public bool? PrivateReservations { get; internal set; }

        [XurrentField("requestTemplates")]
        internal PagedResponse<RequestTemplate>? RequestTemplatesCollection { get; set; }
        /// <summary>
        /// The Request templates table field lists the request templates to which the reservation offering is linked.
        /// </summary>
        public ReadOnlyDataCollection<RequestTemplate>? RequestTemplates { get => RequestTemplatesCollection?.Data is null ? null : new ReadOnlyDataCollection<RequestTemplate>(RequestTemplatesCollection.Data); }

        /// <summary>
        /// The Service instance field is used to select the service instance for which people need to be covered in order to be able to make use of the reservation offering.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The Step duration field is used specify the time increments for the duration of a reservation that is requested using the reservation offering.
        /// </summary>
        [XurrentField("stepDuration")]
        public long? StepDuration { get; internal set; }

        /// <summary>
        /// The Time zone field is used to select the time zone that applies to the selected calendar.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is ReservationOffering reservationOffering)
            {
                ConfigurationItemsCollection?.Data?.AddRange(reservationOffering.ConfigurationItems);
                RequestTemplatesCollection?.Data?.AddRange(reservationOffering.RequestTemplates);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (RequestTemplatesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RequestTemplatesCollection.GetPageInfo("requestTemplates", depth))
                    yield return pageInfo;
        }
    }
}
