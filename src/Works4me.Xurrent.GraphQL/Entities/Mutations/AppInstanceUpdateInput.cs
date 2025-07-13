using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appinstanceupdateinput/">AppInstanceUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class AppInstanceUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _customerRepresentativeId;
        private bool? _disabled;
        private bool? _enabledByCustomer;
        private bool? _suspended;
        private string? _suspensionComment;
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
        /// Identifier of the contact person of customer regarding this app instance.
        /// </summary>
        [XurrentField("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => _customerRepresentativeId;
            set => _customerRepresentativeId = Set("customerRepresentativeId", value);
        }

        /// <summary>
        /// Whether the app instance is currently enabled for this customer.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Whether the customer has enabled this app instance.
        /// </summary>
        [XurrentField("enabledByCustomer")]
        public bool? EnabledByCustomer
        {
            get => _enabledByCustomer;
            set => _enabledByCustomer = Set("enabledByCustomer", value);
        }

        /// <summary>
        /// Whether the app instance is currently suspended for this customer.
        /// </summary>
        [XurrentField("suspended")]
        public bool? Suspended
        {
            get => _suspended;
            set => _suspended = Set("suspended", value);
        }

        /// <summary>
        /// Extra information why the app instance is currently suspended for this customer.
        /// </summary>
        [XurrentField("suspensionComment")]
        public string? SuspensionComment
        {
            get => _suspensionComment;
            set => _suspensionComment = Set("suspensionComment", value);
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
        /// Initializes a new instance of the <see cref="AppInstanceUpdateInput"/> class without providing the required values.
        /// </summary>
        public AppInstanceUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstanceUpdateInput"/> class.
        /// </summary>
        public AppInstanceUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
