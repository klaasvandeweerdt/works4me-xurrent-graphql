using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/teamcreateinput/">TeamCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class TeamCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private string? _agileBoardId;
        private bool? _autoAssign;
        private string? _configurationManagerId;
        private string? _coordinatorId;
        private bool? _disabled;
        private string? _inboundEmailLocalPart;
        private string? _managerId;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private string? _timeZone;
        private string? _workHoursId;
        private Collection<string>? _memberIds;
        private string _name;

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
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [XurrentField("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => _customFields;
            set => _customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [XurrentField("customFieldsAttachments")]
        public Collection<AttachmentInput>? CustomFieldsAttachments
        {
            get => _customFieldsAttachments;
            set => _customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Used to automatically link records to the agile board when they are assigned to the team.
        /// </summary>
        [XurrentField("agileBoardId")]
        public string? AgileBoardId
        {
            get => _agileBoardId;
            set => _agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Whether requests are auto-assigned to a team member.
        /// </summary>
        [XurrentField("autoAssign")]
        public bool? AutoAssign
        {
            get => _autoAssign;
            set => _autoAssign = Set("autoAssign", value);
        }

        /// <summary>
        /// The person who maintains the information about the configuration items that the team supports.
        /// </summary>
        [XurrentField("configurationManagerId")]
        public string? ConfigurationManagerId
        {
            get => _configurationManagerId;
            set => _configurationManagerId = Set("configurationManagerId", value);
        }

        /// <summary>
        /// The current team coordinator for the team. Only members of the team can be selected in this field.
        /// </summary>
        [XurrentField("coordinatorId")]
        public string? CoordinatorId
        {
            get => _coordinatorId;
            set => _coordinatorId = Set("coordinatorId", value);
        }

        /// <summary>
        /// Whether the team may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Used to specify an email address for the team. When an email is sent to this email address, a new request gets generated and assigned to the team.
        /// </summary>
        [XurrentField("inboundEmailLocalPart")]
        public string? InboundEmailLocalPart
        {
            get => _inboundEmailLocalPart;
            set => _inboundEmailLocalPart = Set("inboundEmailLocalPart", value);
        }

        /// <summary>
        /// The manager or supervisor of the team. This person is able to maintain the information about the team. The manager of a team does not need to be a member of the team.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// Any additional information about the team that might prove useful.
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
        /// The time zone that applies to the selected work hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// The calendar that defines the work hours during which the team is available for work on all types of assignments.
        /// </summary>
        [XurrentField("workHoursId")]
        public string? WorkHoursId
        {
            get => _workHoursId;
            set => _workHoursId = Set("workHoursId", value);
        }

        /// <summary>
        /// People that are linked as member to the team.
        /// </summary>
        [XurrentField("memberIds")]
        public Collection<string>? MemberIds
        {
            get => _memberIds;
            set => _memberIds = Set("memberIds", value);
        }

        /// <summary>
        /// The name of the team.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamCreateInput"/> class without providing the required values.
        /// </summary>
        public TeamCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamCreateInput"/> class.
        /// </summary>
        public TeamCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
