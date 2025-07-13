using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservation/">Reservation</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Reservation")]
    public sealed class Reservation : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The asset that is being reserved.
        /// </summary>
        [XurrentField("configurationItem")]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The person who created this reservation.
        /// </summary>
        [XurrentField("createdBy")]
        public Person? CreatedBy { get; internal set; }

        /// <summary>
        /// Full description of the reservation.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// The Duration field is used to specify the length of time for which the configuration item has been reserved.
        /// </summary>
        [XurrentField("duration")]
        public long? Duration { get; internal set; }

        /// <summary>
        /// The End field is used to specify the moment at which the reservation ends.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// A short description of the reservation.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// <c>true</c> when this single occurrence of a recurrent reservation is altered.
        /// </summary>
        [XurrentField("onlyThisOccurrence")]
        public bool? OnlyThisOccurrence { get; internal set; }

        /// <summary>
        /// The person for whom this reservation was created.
        /// </summary>
        [XurrentField("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The start date and time of the preparation of the asset for the reservation. Only present in case the reservation offering specifies a preparation duration.
        /// </summary>
        [XurrentField("preparationStartAt")]
        public DateTime? PreparationStartAt { get; internal set; }

        /// <summary>
        /// Recurrency for the reservation.
        /// </summary>
        [XurrentField("recurrence")]
        public Recurrence? Recurrence { get; internal set; }

        /// <summary>
        /// The link to the request for reservation.
        /// </summary>
        [XurrentField("request")]
        public Request? Request { get; internal set; }

        /// <summary>
        /// The link to the reservation offering that was related to the request template used to request the reservation.
        /// </summary>
        [XurrentField("reservationOffering")]
        public ReservationOffering? ReservationOffering { get; internal set; }

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
        /// The Start field is used to specify the moment at which the reservation begins.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [XurrentField("status")]
        public ReservationStatus? Status { get; internal set; }

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
            if (data is Reservation reservation)
            {
                DescriptionAttachmentsCollection?.Data?.AddRange(reservation.DescriptionAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (DescriptionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in DescriptionAttachmentsCollection.GetPageInfo("descriptionAttachments", depth))
                    yield return pageInfo;
        }
    }
}
