using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/standardservicerequest/">StandardServiceRequest</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("StandardServiceRequest")]
    public sealed class StandardServiceRequest : IDataItem, INode
    {
        /// <summary>
        /// Defines how the standard service request must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeType")]
        public ServiceOfferingChargeType? ChargeType { get; internal set; }

        /// <summary>
        /// The date and time at which the standard service request was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Defines the fixed price rate for the standard service request.
        /// </summary>
        [XurrentField("rate")]
        public decimal? Rate { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of the standard service request.
        /// </summary>
        [XurrentField("rateCurrency")]
        public Currency? RateCurrency { get; internal set; }

        /// <summary>
        /// The request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        [XurrentField("requestTemplate")]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// Number of minutes within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTarget")]
        public long? ResolutionTarget { get; internal set; }

        /// <summary>
        /// Resolution target is Best Effort when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetBestEffort")]
        public bool? ResolutionTargetBestEffort { get; internal set; }

        /// <summary>
        /// Number of business days within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetInDays")]
        public long? ResolutionTargetInDays { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [XurrentField("resolutionTargetNotificationScheme")]
        public SlaNotificationScheme? ResolutionTargetNotificationScheme { get; internal set; }

        /// <summary>
        /// Number of minutes within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTarget")]
        public long? ResponseTarget { get; internal set; }

        /// <summary>
        /// Response target is Best Effort when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetBestEffort")]
        public bool? ResponseTargetBestEffort { get; internal set; }

        /// <summary>
        /// Number of business days within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetInDays")]
        public long? ResponseTargetInDays { get; internal set; }

        /// <summary>
        /// The response target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [XurrentField("responseTargetNotificationScheme")]
        public SlaNotificationScheme? ResponseTargetNotificationScheme { get; internal set; }

        /// <summary>
        /// Service offering the standard service request belongs to.
        /// </summary>
        [XurrentField("serviceOffering")]
        public ServiceOffering? ServiceOffering { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the standard service request. If the standard service request has no updates it contains the <c>createdAt</c> value.
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
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
