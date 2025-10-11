using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/sitecreateinput/">SiteCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class SiteCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private bool? _disabled;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private string? _timeZone;
        private Collection<AddressInput>? _newAddresses;
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
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
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
        /// Default: <c>false</c> - Whether the site may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Any additional information about the site that might prove useful.
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
        /// The time zone in which the site is located.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// New or updated addresses of the site.
        /// </summary>
        [XurrentField("newAddresses")]
        public Collection<AddressInput>? NewAddresses
        {
            get => _newAddresses;
            set => _newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// The name of the site or facility.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteCreateInput"/> class without providing the required values.
        /// </summary>
        public SiteCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteCreateInput"/> class.
        /// </summary>
        public SiteCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
