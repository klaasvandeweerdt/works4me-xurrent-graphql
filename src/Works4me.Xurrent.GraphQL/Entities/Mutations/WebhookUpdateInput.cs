using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/webhookupdateinput/">WebhookUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WebhookUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private bool? _disabled;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private WebhookEvent? _event;
        private string? _mailExceptionsTo;
        private string? _name;
        private Uri? _uri;
        private string? _webhookPolicyId;
        private Collection<string>? _appOfferingReferences;
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
        /// Whether the webhook will be triggered when the event occurs.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Description of the webhook's purpose.
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
        /// Event that will trigger this webhook.
        /// </summary>
        [XurrentField("event")]
        public WebhookEvent? Event
        {
            get => _event;
            set => _event = Set("event", value);
        }

        /// <summary>
        /// Comma separated list of email addresses who will be informed when the webhook execution fails.
        /// </summary>
        [XurrentField("mailExceptionsTo")]
        public string? MailExceptionsTo
        {
            get => _mailExceptionsTo;
            set => _mailExceptionsTo = Set("mailExceptionsTo", value);
        }

        /// <summary>
        /// Name of this webhook. Defaults to the event name.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Publicly accessible URI that Xurrent can use to POST http messages to.
        /// </summary>
        [XurrentField("uri")]
        public Uri? Uri
        {
            get => _uri;
            set => _uri = Set("uri", value);
        }

        /// <summary>
        /// The webhook policy to use for cryptographic signing of the messages.
        /// </summary>
        [XurrentField("webhookPolicyId")]
        public string? WebhookPolicyId
        {
            get => _webhookPolicyId;
            set => _webhookPolicyId = Set("webhookPolicyId", value);
        }

        /// <summary>
        /// The App Offering references used to decide if the webhook should be triggered.
        /// </summary>
        [XurrentField("appOfferingReferences")]
        public Collection<string>? AppOfferingReferences
        {
            get => _appOfferingReferences;
            set => _appOfferingReferences = Set("appOfferingReferences", value);
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
        /// Initializes a new instance of the <see cref="WebhookUpdateInput"/> class without providing the required values.
        /// </summary>
        public WebhookUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateInput"/> class.
        /// </summary>
        public WebhookUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
