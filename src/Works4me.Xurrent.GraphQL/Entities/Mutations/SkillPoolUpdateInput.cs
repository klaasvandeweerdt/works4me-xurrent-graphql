using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/skillpoolupdateinput/">SkillPoolUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class SkillPoolUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private bool? _disabled;
        private string? _managerId;
        private string? _name;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private decimal? _costPerHour;
        private Currency? _costPerHourCurrency;
        private Collection<string>? _memberIds;
        private Collection<string>? _effortClassIds;
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
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Whether the skill pool may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The manager or supervisor of the skill pool. This person is able to maintain the information about the skill pool. The manager of a skill pool does not need to be a member of the skill pool.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// The name of the skill pool.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Any additional information about the skill pool that might prove useful.
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
        /// The skill pool's estimated total cost per work hour for the service provider organization.
        /// </summary>
        [XurrentField("costPerHour")]
        public decimal? CostPerHour
        {
            get => _costPerHour;
            set => _costPerHour = Set("costPerHour", value);
        }

        /// <summary>
        /// The currency of the cost per hour value attributed to this skill pool.
        /// </summary>
        [XurrentField("costPerHourCurrency")]
        public Currency? CostPerHourCurrency
        {
            get => _costPerHourCurrency;
            set => _costPerHourCurrency = Set("costPerHourCurrency", value);
        }

        /// <summary>
        /// People that are linked as member to the skill pool.
        /// </summary>
        [XurrentField("memberIds")]
        public Collection<string>? MemberIds
        {
            get => _memberIds;
            set => _memberIds = Set("memberIds", value);
        }

        /// <summary>
        /// Effort classes that are linked to the skill pool.
        /// </summary>
        [XurrentField("effortClassIds")]
        public Collection<string>? EffortClassIds
        {
            get => _effortClassIds;
            set => _effortClassIds = Set("effortClassIds", value);
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
        /// Initializes a new instance of the <see cref="SkillPoolUpdateInput"/> class without providing the required values.
        /// </summary>
        public SkillPoolUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillPoolUpdateInput"/> class.
        /// </summary>
        public SkillPoolUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
