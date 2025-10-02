using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/uiextensionupdateinput/">UiExtensionUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class UiExtensionUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _disabled;
        private string? _name;
        private string? _title;
        private bool? _darkModeSafe;
        private bool? _activate;
        private string? _css;
        private JsonElement? _formDefinition;
        private string? _html;
        private string? _javascript;
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
        /// Description of the UI extension.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [XurrentField("descriptionAttachments")]
        public Collection<AttachmentInput>? DescriptionAttachments
        {
            get => _descriptionAttachments;
            set => _descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the UI extension is inactive.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the UI extension.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The text that is to be displayed as the section header above the UI extension when the UI extension is presented within a form.
        /// </summary>
        [XurrentField("title")]
        public string? Title
        {
            get => _title;
            set => _title = Set("title", value);
        }

        /// <summary>
        /// Legacy UI extensions that define a custom color — whether through color, background, or background-color — will default to light mode, even when the user has dark mode enabled. Enable this only if you are certain that your UI extension is also compatible with dark mode.
        /// </summary>
        [XurrentField("darkModeSafe")]
        public bool? DarkModeSafe
        {
            get => _darkModeSafe;
            set => _darkModeSafe = Set("darkModeSafe", value);
        }

        /// <summary>
        /// Set to <c>true</c> to promote the Prepared Version to the Active Version. If the was an Active Version, it will be Archived.
        /// </summary>
        [XurrentField("activate")]
        public bool? Activate
        {
            get => _activate;
            set => _activate = Set("activate", value);
        }

        /// <summary>
        /// Sets the CSS stylesheet of the Prepared Version if updated.
        /// </summary>
        [XurrentField("css")]
        public string? Css
        {
            get => _css;
            set => _css = Set("css", value);
        }

        /// <summary>
        /// Sets the Form Definition of the Prepared Version if updated.
        /// </summary>
        [XurrentField("formDefinition")]
        public JsonElement? FormDefinition
        {
            get => _formDefinition;
            set => _formDefinition = Set("formDefinition", value);
        }

        /// <summary>
        /// Sets the HTML code of the Prepared Version if updated.
        /// </summary>
        [XurrentField("html")]
        public string? Html
        {
            get => _html;
            set => _html = Set("html", value);
        }

        /// <summary>
        /// Sets the Javascript code of the Prepared Version if updated.
        /// </summary>
        [XurrentField("javascript")]
        public string? Javascript
        {
            get => _javascript;
            set => _javascript = Set("javascript", value);
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
        /// Initializes a new instance of the <see cref="UiExtensionUpdateInput"/> class without providing the required values.
        /// </summary>
        public UiExtensionUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiExtensionUpdateInput"/> class.
        /// </summary>
        public UiExtensionUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
