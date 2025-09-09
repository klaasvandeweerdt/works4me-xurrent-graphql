using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/broadcastupdateinput/">BroadcastUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class BroadcastUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private string? _message;
        private BroadcastMessageType? _messageType;
        private DateTime? _startAt;
        private DateTime? _endAt;
        private string? _timeZone;
        private BroadcastVisibility? _visibility;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private string? _subject;
        private string? _body;
        private string? _emailTemplateId;
        private string? _requestId;
        private Collection<string>? _customerIds;
        private Collection<string>? _serviceInstanceIds;
        private Collection<string>? _teamIds;
        private Collection<string>? _siteIds;
        private Collection<string>? _slaIds;
        private Collection<string>? _organizationIds;
        private Collection<string>? _skillPoolIds;
        private string _id;
        private Collection<string>? _translationsToDelete;

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
        /// Whether the message should not be broadcasted.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Message that is to be broadcasted in the language of the account.
        /// </summary>
        [XurrentField("message")]
        public string? Message
        {
            get => _message;
            set => _message = Set("message", value);
        }

        /// <summary>
        /// The appropriate icon for the message. The selected icon is displayed alongside the message when the broadcast is presented.
        /// </summary>
        [XurrentField("messageType")]
        public BroadcastMessageType? MessageType
        {
            get => _messageType;
            set => _messageType = Set("messageType", value);
        }

        /// <summary>
        /// The start date and time of the broadcast. (If the broadcast should start at midnight at the start of a day, specify 00:00.).
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// The end date and time of the broadcast. This field is left empty when the message is to be broadcasted until the Disabled box is checked. (If the broadcast should end at midnight at the end of a day, specify 12:00am or 24:00.).
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt
        {
            get => _endAt;
            set => _endAt = Set("endAt", value);
        }

        /// <summary>
        /// The time zone that applies to the dates and times specified in the Start and End fields.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Defines the target audience of the broadcast.
        /// </summary>
        [XurrentField("visibility")]
        public BroadcastVisibility? Visibility
        {
            get => _visibility;
            set => _visibility = Set("visibility", value);
        }

        /// <summary>
        /// Any additional information about the broadcast that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks
        {
            get => _remarks;
            set => _remarks = Set("remarks", value);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        [XurrentField("remarksAttachments")]
        public Collection<AttachmentInput>? RemarksAttachments
        {
            get => _remarksAttachments;
            set => _remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// The subject for the email broadcast.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// The body for the email broadcast.
        /// </summary>
        [XurrentField("body")]
        public string? Body
        {
            get => _body;
            set => _body = Set("body", value);
        }

        /// <summary>
        /// The id of the email template used for the email broadcast. This email template needs to be of the type Send Email from Broadcast.
        /// </summary>
        [XurrentField("emailTemplateId")]
        public string? EmailTemplateId
        {
            get => _emailTemplateId;
            set => _emailTemplateId = Set("emailTemplateId", value);
        }

        /// <summary>
        /// The request group to which end users can subscribe when they are also affected by the issue for which the broadcast was created.
        /// </summary>
        [XurrentField("requestId")]
        public string? RequestId
        {
            get => _requestId;
            set => _requestId = Set("requestId", value);
        }

        /// <summary>
        /// The customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        [XurrentField("customerIds")]
        public Collection<string>? CustomerIds
        {
            get => _customerIds;
            set => _customerIds = Set("customerIds", value);
        }

        /// <summary>
        /// The service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        [XurrentField("serviceInstanceIds")]
        public Collection<string>? ServiceInstanceIds
        {
            get => _serviceInstanceIds;
            set => _serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// The teams which members need to see the broadcast. This is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        [XurrentField("teamIds")]
        public Collection<string>? TeamIds
        {
            get => _teamIds;
            set => _teamIds = Set("teamIds", value);
        }

        /// <summary>
        /// The ids of the sites to which people belong and that need to see the broadcast.
        /// </summary>
        [XurrentField("siteIds")]
        public Collection<string>? SiteIds
        {
            get => _siteIds;
            set => _siteIds = Set("siteIds", value);
        }

        /// <summary>
        /// The ids of the service level agreements for which the customer representatives will receive the email broadcast. This is only available for broadcasts when the message type "email" is selected.
        /// </summary>
        [XurrentField("slaIds")]
        public Collection<string>? SlaIds
        {
            get => _slaIds;
            set => _slaIds = Set("slaIds", value);
        }

        /// <summary>
        /// The ids of the organizations, to which people belong, that need to see the broadcast.
        /// </summary>
        [XurrentField("organizationIds")]
        public Collection<string>? OrganizationIds
        {
            get => _organizationIds;
            set => _organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// The ids of the skill pools to which people belong and that need to see the broadcast.
        /// </summary>
        [XurrentField("skillPoolIds")]
        public Collection<string>? SkillPoolIds
        {
            get => _skillPoolIds;
            set => _skillPoolIds = Set("skillPoolIds", value);
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
        /// Identifiers of translations to remove from this broadcast.
        /// </summary>
        [XurrentField("translationsToDelete")]
        public Collection<string>? TranslationsToDelete
        {
            get => _translationsToDelete;
            set => _translationsToDelete = Set("translationsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastUpdateInput"/> class without providing the required values.
        /// </summary>
        public BroadcastUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastUpdateInput"/> class.
        /// </summary>
        public BroadcastUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
