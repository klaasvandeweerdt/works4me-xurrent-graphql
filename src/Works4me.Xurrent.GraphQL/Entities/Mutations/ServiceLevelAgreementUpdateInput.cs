using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/servicelevelagreementupdateinput/">ServiceLevelAgreementUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class ServiceLevelAgreementUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _name;
        private AgreementStatus? _status;
        private string? _customerId;
        private string? _serviceLevelManagerId;
        private string? _serviceOfferingId;
        private string? _serviceInstanceId;
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
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private SlaCoverage? _coverage;
        private bool? _useKnowledgeFromServiceProvider;
        private string? _agreementID;
        private ActivityIDInput? _activityID;
        private Collection<string>? _customerRepresentativeIds;
        private Collection<string>? _organizationIds;
        private Collection<string>? _personIds;
        private Collection<string>? _siteIds;
        private Collection<string>? _skillPoolIds;
        private Collection<EffortClassRateIDInput>? _newEffortClassRateIDs;
        private Collection<StandardServiceRequestActivityIDInput>? _newStandardServiceRequestActivityIDs;
        private string _id;
        private Collection<string>? _standardServiceRequestActivityIDsToDelete;
        private Collection<string>? _effortClassRateIDsToDelete;

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
        /// The name of the service level agreement.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The current status of the service level agreement (SLA).
        /// </summary>
        [XurrentField("status")]
        public AgreementStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the organization that pays for the service level agreement.
        /// </summary>
        [XurrentField("customerId")]
        public string? CustomerId
        {
            get => _customerId;
            set => _customerId = Set("customerId", value);
        }

        /// <summary>
        /// Identifier of the person of the service provider organization who acts as the service level manager for the customer of the service level agreement.
        /// </summary>
        [XurrentField("serviceLevelManagerId")]
        public string? ServiceLevelManagerId
        {
            get => _serviceLevelManagerId;
            set => _serviceLevelManagerId = Set("serviceLevelManagerId", value);
        }

        /// <summary>
        /// Identifier of the service offering that specifies the conditions that apply to the service level agreement.
        /// </summary>
        [XurrentField("serviceOfferingId")]
        public string? ServiceOfferingId
        {
            get => _serviceOfferingId;
            set => _serviceOfferingId = Set("serviceOfferingId", value);
        }

        /// <summary>
        /// Identifier of the service instance that will be used to provide the service to the customer of the service level agreement. Only service instances that are linked to the same service as the selected service offering can be selected.
        /// </summary>
        [XurrentField("serviceInstanceId")]
        public string? ServiceInstanceId
        {
            get => _serviceInstanceId;
            set => _serviceInstanceId = Set("serviceInstanceId", value);
        }

        /// <summary>
        /// The first day during which the service level agreement (SLA) is active.
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
        /// The last day on which the service provider organization can still be contacted to terminate the service level agreement (SLA) to ensure that it expires on the intended expiry date. The Notice date field is left empty, and the Expiry date field is filled out, when the SLA is to expire on a specific date and no notice needs to be given to terminate it.
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
        /// The date through which the service level agreement (SLA) will be active. The SLA expires at the end of this day if it is not renewed before then. When the SLA has expired, its status will automatically be set to "Expired".
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
        /// Any additional information about the service level agreement that might prove useful.
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
        /// Used to specify how people who are to be covered by the service level agreement are to be selected.
        /// </summary>
        [XurrentField("coverage")]
        public SlaCoverage? Coverage
        {
            get => _coverage;
            set => _coverage = Set("coverage", value);
        }

        /// <summary>
        /// Whether knowledge articles from the service provider should be exposed to the people covered by the service instances related to the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        [XurrentField("useKnowledgeFromServiceProvider")]
        public bool? UseKnowledgeFromServiceProvider
        {
            get => _useKnowledgeFromServiceProvider;
            set => _useKnowledgeFromServiceProvider = Set("useKnowledgeFromServiceProvider", value);
        }

        /// <summary>
        /// The Agreement ID is the unique identifier by which all the activities that are performed through the coverage of the SLA are known in the billing system of the service provider.
        /// </summary>
        [XurrentField("agreementID")]
        public string? AgreementID
        {
            get => _agreementID;
            set => _agreementID = Set("agreementID", value);
        }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. This contains the activityIDs related to request categories.
        /// </summary>
        [XurrentField("activityID")]
        public ActivityIDInput? ActivityID
        {
            get => _activityID;
            set => _activityID = Set("activityID", value);
        }

        /// <summary>
        /// Identifiers of the people who represents the customer organization for the service level agreement.
        /// </summary>
        [XurrentField("customerRepresentativeIds")]
        public Collection<string>? CustomerRepresentativeIds
        {
            get => _customerRepresentativeIds;
            set => _customerRepresentativeIds = Set("customerRepresentativeIds", value);
        }

        /// <summary>
        /// Identifiers of the organizations of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>organizations_and_descendants</c>, <c>organizations</c> or <c>organizations_and_sites</c>.
        /// </summary>
        [XurrentField("organizationIds")]
        public Collection<string>? OrganizationIds
        {
            get => _organizationIds;
            set => _organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// Identifiers of the people of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>people</c>.
        /// </summary>
        [XurrentField("personIds")]
        public Collection<string>? PersonIds
        {
            get => _personIds;
            set => _personIds = Set("personIds", value);
        }

        /// <summary>
        /// Identifiers of the sites of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>sites</c> or <c>organizations_and_sites</c>.
        /// </summary>
        [XurrentField("siteIds")]
        public Collection<string>? SiteIds
        {
            get => _siteIds;
            set => _siteIds = Set("siteIds", value);
        }

        /// <summary>
        /// Identifiers of the skill pools of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>skill_pools</c>.
        /// </summary>
        [XurrentField("skillPoolIds")]
        public Collection<string>? SkillPoolIds
        {
            get => _skillPoolIds;
            set => _skillPoolIds = Set("skillPoolIds", value);
        }

        /// <summary>
        /// The Rate IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("newEffortClassRateIDs")]
        public Collection<EffortClassRateIDInput>? NewEffortClassRateIDs
        {
            get => _newEffortClassRateIDs;
            set => _newEffortClassRateIDs = Set("newEffortClassRateIDs", value);
        }

        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        [XurrentField("newStandardServiceRequestActivityIDs")]
        public Collection<StandardServiceRequestActivityIDInput>? NewStandardServiceRequestActivityIDs
        {
            get => _newStandardServiceRequestActivityIDs;
            set => _newStandardServiceRequestActivityIDs = Set("newStandardServiceRequestActivityIDs", value);
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
        /// Identifiers of effort class rateIDs to remove from the SLA.
        /// </summary>
        [XurrentField("standardServiceRequestActivityIDsToDelete")]
        public Collection<string>? StandardServiceRequestActivityIDsToDelete
        {
            get => _standardServiceRequestActivityIDsToDelete;
            set => _standardServiceRequestActivityIDsToDelete = Set("standardServiceRequestActivityIDsToDelete", value);
        }

        /// <summary>
        /// Identifiers of effort class rateIDs to remove from the SLA.
        /// </summary>
        [XurrentField("effortClassRateIDsToDelete")]
        public Collection<string>? EffortClassRateIDsToDelete
        {
            get => _effortClassRateIDsToDelete;
            set => _effortClassRateIDsToDelete = Set("effortClassRateIDsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementUpdateInput"/> class without providing the required values.
        /// </summary>
        public ServiceLevelAgreementUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementUpdateInput"/> class.
        /// </summary>
        public ServiceLevelAgreementUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
