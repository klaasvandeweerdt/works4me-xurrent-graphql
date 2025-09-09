using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/firstlinesupportagreementupdateinput/">FirstLineSupportAgreementUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class FirstLineSupportAgreementUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _name;
        private AgreementStatus? _status;
        private string? _customerId;
        private string? _customerRepresentativeId;
        private string? _providerId;
        private string? _serviceDeskTeamId;
#if NET6_0_OR_GREATER
        private DateOnly? _startDate;
#else
        private DateTime? _startDate;
#endif
#if NET6_0_OR_GREATER
        private DateOnly? _noticeDate;
#else
        private DateTime? _noticeDate;
#endif
#if NET6_0_OR_GREATER
        private DateOnly? _expiryDate;
#else
        private DateTime? _expiryDate;
#endif
        private string? _supportHoursId;
        private string? _timeZone;
        private long? _pickupTarget;
        private long? _supportChatPickupTarget;
        private long? _pickupsWithinTarget;
        private long? _firstCallResolutions;
        private long? _serviceDeskOnlyResolutions;
        private long? _serviceDeskResolutions;
        private long? _rejectedSolutions;
        private string? _targetDetails;
        private string? _charges;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private string _id;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The name of the first line support agreement.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The current status of the first line support agreement (FLSA).
        /// </summary>
        [XurrentField("status")]
        public AgreementStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the organization that pays for the first line support agreement.
        /// </summary>
        [XurrentField("customerId")]
        public string? CustomerId
        {
            get => _customerId;
            set => _customerId = Set("customerId", value);
        }

        /// <summary>
        /// Identifier of the customer representative.
        /// </summary>
        [XurrentField("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => _customerRepresentativeId;
            set => _customerRepresentativeId = Set("customerRepresentativeId", value);
        }

        /// <summary>
        /// Identifier of the organization that provides the first line support agreement.
        /// </summary>
        [XurrentField("providerId")]
        public string? ProviderId
        {
            get => _providerId;
            set => _providerId = Set("providerId", value);
        }

        /// <summary>
        /// Identifier of the specific team within the first line support provider organization that provides first line support for the users covered by the first line support agreement.
        /// </summary>
        [XurrentField("serviceDeskTeamId")]
        public string? ServiceDeskTeamId
        {
            get => _serviceDeskTeamId;
            set => _serviceDeskTeamId = Set("serviceDeskTeamId", value);
        }

        /// <summary>
        /// The first day during which the first line support agreement (FLSA) is active.
        /// </summary>
        [XurrentField("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate
#else
        public DateTime? StartDate
#endif
        {
            get => _startDate;
            set => _startDate = Set("startDate", value);
        }

        /// <summary>
        /// The last day on which the first line support provider organization can still be contacted to terminate the first line support agreement (FLSA) to ensure that it expires on the intended expiry date. The Notice date field is left empty, and the Expiry date field is filled out, when the FLSA is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [XurrentField("noticeDate")]
#if NET6_0_OR_GREATER
        public DateOnly? NoticeDate
#else
        public DateTime? NoticeDate
#endif
        {
            get => _noticeDate;
            set => _noticeDate = Set("noticeDate", value);
        }

        /// <summary>
        /// The date through which the first line support agreement (FLSA) will be active. The FLSA expires at the end of this day if it is not renewed before then. When the FLSA has expired, its status will automatically be set to "Expired".
        /// </summary>
        [XurrentField("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate
#else
        public DateTime? ExpiryDate
#endif
        {
            get => _expiryDate;
            set => _expiryDate = Set("expiryDate", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours during which the service desk team can be contacted for first line support.
        /// </summary>
        [XurrentField("supportHoursId")]
        public string? SupportHoursId
        {
            get => _supportHoursId;
            set => _supportHoursId = Set("supportHoursId", value);
        }

        /// <summary>
        /// The time zone that applies to the start, notice and expiry dates, and to the support hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// The number of minutes within which a new or existing request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than <c>assigned</c>.
        /// </summary>
        [XurrentField("pickupTarget")]
        public long? PickupTarget
        {
            get => _pickupTarget;
            set => _pickupTarget = Set("pickupTarget", value);
        }

        /// <summary>
        /// The number of minutes within which a new or existing chat request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than <c>assigned</c>.
        /// </summary>
        [XurrentField("supportChatPickupTarget")]
        public long? SupportChatPickupTarget
        {
            get => _supportChatPickupTarget;
            set => _supportChatPickupTarget = Set("supportChatPickupTarget", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be picked up by the service desk team within the pickup target.
        /// </summary>
        [XurrentField("pickupsWithinTarget")]
        public long? PickupsWithinTarget
        {
            get => _pickupsWithinTarget;
            set => _pickupsWithinTarget = Set("pickupsWithinTarget", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team during their registration.
        /// </summary>
        [XurrentField("firstCallResolutions")]
        public long? FirstCallResolutions
        {
            get => _firstCallResolutions;
            set => _firstCallResolutions = Set("firstCallResolutions", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team without having been assigned to any other team within the account that is covered by the first line support agreement.
        /// </summary>
        [XurrentField("serviceDeskOnlyResolutions")]
        public long? ServiceDeskOnlyResolutions
        {
            get => _serviceDeskOnlyResolutions;
            set => _serviceDeskOnlyResolutions = Set("serviceDeskOnlyResolutions", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team.
        /// </summary>
        [XurrentField("serviceDeskResolutions")]
        public long? ServiceDeskResolutions
        {
            get => _serviceDeskResolutions;
            set => _serviceDeskResolutions = Set("serviceDeskResolutions", value);
        }

        /// <summary>
        /// The maximum percentage of requests that were reopened (i.e. which status in the account that is covered by the first line support agreement was updated from <c>completed</c> to another status).
        /// </summary>
        [XurrentField("rejectedSolutions")]
        public long? RejectedSolutions
        {
            get => _rejectedSolutions;
            set => _rejectedSolutions = Set("rejectedSolutions", value);
        }

        /// <summary>
        /// A description of all the targets of the first line support agreement.
        /// </summary>
        [XurrentField("targetDetails")]
        public string? TargetDetails
        {
            get => _targetDetails;
            set => _targetDetails = Set("targetDetails", value);
        }

        /// <summary>
        /// The amounts that the customer will be charged for the first line support agreement. These can be recurring as well as one-off charges.
        /// </summary>
        [XurrentField("charges")]
        public string? Charges
        {
            get => _charges;
            set => _charges = Set("charges", value);
        }

        /// <summary>
        /// Any additional information about the first line support agreement that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks
        {
            get => _remarks;
            set => _remarks = Set("remarks", value);
        }

        /// <summary>
        /// The attachments used in the <c>remarks</c> field.
        /// </summary>
        [XurrentField("remarksAttachments")]
        public Collection<AttachmentInput>? RemarksAttachments
        {
            get => _remarksAttachments;
            set => _remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirstLineSupportAgreementUpdateInput"/> class without providing the required values.
        /// </summary>
        public FirstLineSupportAgreementUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirstLineSupportAgreementUpdateInput"/> class.
        /// </summary>
        public FirstLineSupportAgreementUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
