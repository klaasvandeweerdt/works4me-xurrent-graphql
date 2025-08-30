using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingcreateinput/">AppOfferingCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class AppOfferingCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private Uri? _pictureUri;
        private string? _source;
        private string? _sourceID;
        private string? _uiExtensionId;
        private string? _cardDescription;
        private string? _compliance;
        private Collection<AttachmentInput>? _complianceAttachments;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _disabled;
        private string? _features;
        private Collection<AttachmentInput>? _featuresAttachments;
        private Collection<string>? _oauthAuthorizationEndpoints;
        private WebhookPolicyJwtAlg? _policyJwtAlg;
        private string? _policyJwtAudience;
        private long? _policyJwtClaimExpiresIn;
        private string? _reference;
        private string? _uiExtensionVersionId;
        private Uri? _configurationUriTemplate;
        private Uri? _webhookUriTemplate;
        private bool? _requiresEnabledOauthPerson;
        private Collection<AppOfferingScopeInput>? _newScopes;
        private string _name;
        private string _serviceInstanceId;

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
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Short description of the app offering to be shown on the card in the App store.
        /// </summary>
        [XurrentField("cardDescription")]
        public string? CardDescription
        {
            get => _cardDescription;
            set => _cardDescription = Set("cardDescription", value);
        }

        /// <summary>
        /// Compliance description of the app offering.
        /// </summary>
        [XurrentField("compliance")]
        public string? Compliance
        {
            get => _compliance;
            set => _compliance = Set("compliance", value);
        }

        /// <summary>
        /// The attachments used in the <c>compliance</c> field.
        /// </summary>
        [XurrentField("complianceAttachments")]
        public Collection<AttachmentInput>? ComplianceAttachments
        {
            get => _complianceAttachments;
            set => _complianceAttachments = Set("complianceAttachments", value);
        }

        /// <summary>
        /// Description of the app offering.
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
        /// Whether the app offering may not be used for new instances.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Feature description of the app offering.
        /// </summary>
        [XurrentField("features")]
        public string? Features
        {
            get => _features;
            set => _features = Set("features", value);
        }

        /// <summary>
        /// The attachments used in the <c>features</c> field.
        /// </summary>
        [XurrentField("featuresAttachments")]
        public Collection<AttachmentInput>? FeaturesAttachments
        {
            get => _featuresAttachments;
            set => _featuresAttachments = Set("featuresAttachments", value);
        }

        /// <summary>
        /// The endpoints for the OAuth application that will be created for this app to use in the <a href="https://developer.xurrent.com/v1/oauth/authorization_code_grant/">Authorization Code Grant flow</a>.
        /// </summary>
        [XurrentField("oauthAuthorizationEndpoints")]
        public Collection<string>? OauthAuthorizationEndpoints
        {
            get => _oauthAuthorizationEndpoints;
            set => _oauthAuthorizationEndpoints = Set("oauthAuthorizationEndpoints", value);
        }

        /// <summary>
        /// The algorithm used for generating the policy for the app offering's webhook.
        /// </summary>
        [XurrentField("policyJwtAlg")]
        public WebhookPolicyJwtAlg? PolicyJwtAlg
        {
            get => _policyJwtAlg;
            set => _policyJwtAlg = Set("policyJwtAlg", value);
        }

        /// <summary>
        /// The audience for the policy for the app offering's webhook.
        /// </summary>
        [XurrentField("policyJwtAudience")]
        public string? PolicyJwtAudience
        {
            get => _policyJwtAudience;
            set => _policyJwtAudience = Set("policyJwtAudience", value);
        }

        /// <summary>
        /// The claim expiry time for the policy for the app offering's webhook.
        /// </summary>
        [XurrentField("policyJwtClaimExpiresIn")]
        public long? PolicyJwtClaimExpiresIn
        {
            get => _policyJwtClaimExpiresIn;
            set => _policyJwtClaimExpiresIn = Set("policyJwtClaimExpiresIn", value);
        }

        /// <summary>
        /// This reference can be used to link the app offering to an instance using the Xurrent APIs or the Xurrent Import functionality.
        /// </summary>
        [XurrentField("reference")]
        public string? Reference
        {
            get => _reference;
            set => _reference = Set("reference", value);
        }

        /// <summary>
        /// Identifier of the UI extension version that is linked to the app offering.
        /// </summary>
        [XurrentField("uiExtensionVersionId")]
        public string? UiExtensionVersionId
        {
            get => _uiExtensionVersionId;
            set => _uiExtensionVersionId = Set("uiExtensionVersionId", value);
        }

        /// <summary>
        /// The URI where the app can be configured. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [XurrentField("configurationUriTemplate")]
        public Uri? ConfigurationUriTemplate
        {
            get => _configurationUriTemplate;
            set => _configurationUriTemplate = Set("configurationUriTemplate", value);
        }

        /// <summary>
        /// The URI for the app offering's webhook. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [XurrentField("webhookUriTemplate")]
        public Uri? WebhookUriTemplate
        {
            get => _webhookUriTemplate;
            set => _webhookUriTemplate = Set("webhookUriTemplate", value);
        }

        /// <summary>
        /// This app requires an enabled OAuth person.
        /// </summary>
        [XurrentField("requiresEnabledOauthPerson")]
        public bool? RequiresEnabledOauthPerson
        {
            get => _requiresEnabledOauthPerson;
            set => _requiresEnabledOauthPerson = Set("requiresEnabledOauthPerson", value);
        }

        /// <summary>
        /// Scopes of this app offering.
        /// </summary>
        [XurrentField("newScopes")]
        public Collection<AppOfferingScopeInput>? NewScopes
        {
            get => _newScopes;
            set => _newScopes = Set("newScopes", value);
        }

        /// <summary>
        /// Name of the app offering.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the the service instance this app offering is linked to.
        /// </summary>
        [XurrentField("serviceInstanceId")]
        public string ServiceInstanceId
        {
            get => _serviceInstanceId;
            set => _serviceInstanceId = Set("serviceInstanceId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingCreateInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingCreateInput()
        {
            _name = string.Empty;
            _serviceInstanceId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingCreateInput"/> class.
        /// </summary>
        public AppOfferingCreateInput(string name, string serviceInstanceId)
        {
            _name = Set("name", name);
            _serviceInstanceId = Set("serviceInstanceId", serviceInstanceId);
        }
    }
}
