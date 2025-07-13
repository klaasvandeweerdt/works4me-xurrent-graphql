using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/firstlinesupportagreement/">FirstLineSupportAgreement</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("FirstLineSupportAgreement")]
    public sealed class FirstLineSupportAgreement : IDataItem, IHasInvoices, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The amounts that the customer will be charged for the first line support agreement. These can be recurring as well as one-off charges.
        /// </summary>
        [XurrentField("charges")]
        public string? Charges { get; internal set; }

        [XurrentField("chargesAttachments")]
        internal PagedResponse<Attachment>? ChargesAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? ChargesAttachments { get => ChargesAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(ChargesAttachmentsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        [XurrentField("customer")]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        [XurrentField("customerAccount")]
        public Account? CustomerAccount { get; internal set; }

        /// <summary>
        /// The person who represents the customer organization for the first line support agreement.
        /// </summary>
        [XurrentField("customerRepresentative")]
        public Person? CustomerRepresentative { get; internal set; }

        /// <summary>
        /// The date through which the agreement will be active. The agreement expires at the end of this day if it is not renewed before then. When the agreement has expired, its status will automatically be set to <c>expired</c>.
        /// </summary>
        [XurrentField("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate { get; internal set; }
#else
        public DateTime? ExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team during their registration.
        /// </summary>
        [XurrentField("firstCallResolutions")]
        public long? FirstCallResolutions { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        [XurrentField("invoices")]
        internal PagedResponse<Invoice>? InvoicesCollection { get; set; }
        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Invoice>? Invoices { get => InvoicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Invoice>(InvoicesCollection.Data); }

        [XurrentField("majorIncidentManagers")]
        internal PagedResponse<Person>? MajorIncidentManagersCollection { get; set; }
        /// <summary>
        /// The people who can assume the role of major incident manager for the organization that is covered by the first line support agreement.
        /// </summary>
        public ReadOnlyDataCollection<Person>? MajorIncidentManagers { get => MajorIncidentManagersCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(MajorIncidentManagersCollection.Data); }

        /// <summary>
        /// The name of the first line support agreement.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The last day on which the service provider organization can still be contacted to terminate the agreement to ensure that it expires on the intended expiry date. The notice date field is left empty, and the expiry date field is filled out, when the agreement is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [XurrentField("noticeDate")]
#if NET6_0_OR_GREATER
        public DateOnly? NoticeDate { get; internal set; }
#else
        public DateTime? NoticeDate { get; internal set; }
#endif

        /// <summary>
        /// The number of minutes within which a new or existing request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than <c>assigned</c>.
        /// </summary>
        [XurrentField("pickupTarget")]
        public long? PickupTarget { get; internal set; }

        /// <summary>
        /// The minimum percentage of requests that are to be picked up by the service desk team within the pickup target.
        /// </summary>
        [XurrentField("pickupsWithinTarget")]
        public long? PickupsWithinTarget { get; internal set; }

        /// <summary>
        /// Organization that provides the first line support agreement.
        /// </summary>
        [XurrentField("provider")]
        public Organization? Provider { get; internal set; }

        /// <summary>
        /// The maximum percentage of requests that were reopened (i.e. which status in the account that is covered by the first line support agreement was updated from <c>completed</c> to another status).
        /// </summary>
        [XurrentField("rejectedSolutions")]
        public long? RejectedSolutions { get; internal set; }

        /// <summary>
        /// Any additional information about the first line support agreement that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team without having been assigned to any other team within the account that is covered by the first line support agreement.
        /// </summary>
        [XurrentField("serviceDeskOnlyResolutions")]
        public long? ServiceDeskOnlyResolutions { get; internal set; }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team.
        /// </summary>
        [XurrentField("serviceDeskResolutions")]
        public long? ServiceDeskResolutions { get; internal set; }

        /// <summary>
        /// The specific team within the first line support provider organization that provides first line support for the users covered by the first line support agreement.
        /// </summary>
        [XurrentField("serviceDeskTeam")]
        public Team? ServiceDeskTeam { get; internal set; }

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
        /// The first day during which the agreement is active.
        /// </summary>
        [XurrentField("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate { get; internal set; }
#else
        public DateTime? StartDate { get; internal set; }
#endif

        /// <summary>
        /// The current status of the agreement.
        /// </summary>
        [XurrentField("status")]
        public AgreementStatus? Status { get; internal set; }

        /// <summary>
        /// The number of minutes within which a new or existing chat request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than <c>assigned</c>.
        /// </summary>
        [XurrentField("supportChatPickupTarget")]
        public long? SupportChatPickupTarget { get; internal set; }

        /// <summary>
        /// Calendar that defines the support hours during which the service desk team can be contacted for first line support.
        /// </summary>
        [XurrentField("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// A description of all the targets of the first line support agreement.
        /// </summary>
        [XurrentField("targetDetails")]
        public string? TargetDetails { get; internal set; }

        [XurrentField("targetDetailsAttachments")]
        internal PagedResponse<Attachment>? TargetDetailsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Target details field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? TargetDetailsAttachments { get => TargetDetailsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(TargetDetailsAttachmentsCollection.Data); }

        /// <summary>
        /// The time zone that applies to the start, notice and expiry dates, and to the support hours.<br />
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
            if (data is FirstLineSupportAgreement firstLineSupportAgreement)
            {
                ChargesAttachmentsCollection?.Data?.AddRange(firstLineSupportAgreement.ChargesAttachments);
                InvoicesCollection?.Data?.AddRange(firstLineSupportAgreement.Invoices);
                MajorIncidentManagersCollection?.Data?.AddRange(firstLineSupportAgreement.MajorIncidentManagers);
                RemarksAttachmentsCollection?.Data?.AddRange(firstLineSupportAgreement.RemarksAttachments);
                TargetDetailsAttachmentsCollection?.Data?.AddRange(firstLineSupportAgreement.TargetDetailsAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ChargesAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ChargesAttachmentsCollection.GetPageInfo("chargesAttachments", depth))
                    yield return pageInfo;

            if (InvoicesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InvoicesCollection.GetPageInfo("invoices", depth))
                    yield return pageInfo;

            if (MajorIncidentManagersCollection is not null)
                foreach (ExecutionPageInfo pageInfo in MajorIncidentManagersCollection.GetPageInfo("majorIncidentManagers", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;

            if (TargetDetailsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TargetDetailsAttachmentsCollection.GetPageInfo("targetDetailsAttachments", depth))
                    yield return pageInfo;
        }
    }
}
