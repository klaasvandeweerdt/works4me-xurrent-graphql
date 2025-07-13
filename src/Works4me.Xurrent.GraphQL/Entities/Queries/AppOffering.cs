using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appoffering/">AppOffering</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("AppOffering")]
    public sealed class AppOffering : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("appInstances")]
        internal PagedResponse<AppInstance>? AppInstancesCollection { get; set; }
        /// <summary>
        /// Instances of this app.
        /// </summary>
        public ReadOnlyDataCollection<AppInstance>? AppInstances { get => AppInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<AppInstance>(AppInstancesCollection.Data); }

        [XurrentField("automationRules")]
        internal PagedResponse<AppOfferingAutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules of this app offering.
        /// </summary>
        public ReadOnlyDataCollection<AppOfferingAutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AppOfferingAutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// Short description of the app offering to be shown on the card in the App store.
        /// </summary>
        [XurrentField("cardDescription")]
        public string? CardDescription { get; internal set; }

        /// <summary>
        /// Compliance description of the app offering.
        /// </summary>
        [XurrentField("compliance")]
        public string? Compliance { get; internal set; }

        [XurrentField("complianceAttachments")]
        internal PagedResponse<Attachment>? ComplianceAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Compliance field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? ComplianceAttachments { get => ComplianceAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(ComplianceAttachmentsCollection.Data); }

        /// <summary>
        /// The URI where the app can be configured. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [XurrentField("configurationUriTemplate")]
        public Uri? ConfigurationUriTemplate { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the app offering.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// Whether the app offering may not be used for new instances.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Feature description of the app offering.
        /// </summary>
        [XurrentField("features")]
        public string? Features { get; internal set; }

        [XurrentField("featuresAttachments")]
        internal PagedResponse<Attachment>? FeaturesAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Features field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? FeaturesAttachments { get => FeaturesAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(FeaturesAttachmentsCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Whether this is the latest published version of the app offering or the current draft.
        /// </summary>
        [XurrentField("latest")]
        public bool? Latest { get; internal set; }

        /// <summary>
        /// Name of the app offering.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The endpoints for the OAuth application that will be created for this app to use in the <a href="https://developer.xurrent.com/v1/oauth/authorization_code_grant/">Authorization Code Grant flow</a>.
        /// </summary>
        [XurrentField("oauthAuthorizationEndpoints")]
        public IReadOnlyList<string>? OauthAuthorizationEndpoints { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// The algorithm used for generating the policy for the app's webhook.
        /// </summary>
        [XurrentField("policyJwtAlg")]
        public WebhookPolicyJwtAlg? PolicyJwtAlg { get; internal set; }

        /// <summary>
        /// The audience for the policy for the app's webhook.
        /// </summary>
        [XurrentField("policyJwtAudience")]
        public string? PolicyJwtAudience { get; internal set; }

        /// <summary>
        /// The claim expiry time for the policy for the app's webhook.
        /// </summary>
        [XurrentField("policyJwtClaimExpiresIn")]
        public long? PolicyJwtClaimExpiresIn { get; internal set; }

        /// <summary>
        /// Whether this app offering is published or draft.
        /// </summary>
        [XurrentField("published")]
        public bool? Published { get; internal set; }

        /// <summary>
        /// This reference can be used to link the app offering to an instance using the Xurrent APIs or the Xurrent Import functionality.
        /// </summary>
        [XurrentField("reference")]
        public string? Reference { get; internal set; }

        /// <summary>
        /// This app requires an enabled OAuth person.
        /// </summary>
        [XurrentField("requiresEnabledOauthPerson")]
        public bool? RequiresEnabledOauthPerson { get; internal set; }

        /// <summary>
        /// Scopes of this app offering.
        /// </summary>
        [XurrentField("scopes")]
        public IReadOnlyList<AppOfferingScope>? Scopes { get; internal set; }

        /// <summary>
        /// Service instance that is linked to the app offering.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// UI extension version that is linked to the app offering.
        /// </summary>
        [XurrentField("uiExtensionVersion")]
        public UiExtensionVersion? UiExtensionVersion { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The URI for the app's webhook. The placeholder {account} can be used to include the customer account id in the URI.
        /// </summary>
        [XurrentField("webhookUriTemplate")]
        public Uri? WebhookUriTemplate { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is AppOffering appOffering)
            {
                AppInstancesCollection?.Data?.AddRange(appOffering.AppInstances);
                AutomationRulesCollection?.Data?.AddRange(appOffering.AutomationRules);
                ComplianceAttachmentsCollection?.Data?.AddRange(appOffering.ComplianceAttachments);
                DescriptionAttachmentsCollection?.Data?.AddRange(appOffering.DescriptionAttachments);
                FeaturesAttachmentsCollection?.Data?.AddRange(appOffering.FeaturesAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AppInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AppInstancesCollection.GetPageInfo("appInstances", depth))
                    yield return pageInfo;

            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (ComplianceAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ComplianceAttachmentsCollection.GetPageInfo("complianceAttachments", depth))
                    yield return pageInfo;

            if (DescriptionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in DescriptionAttachmentsCollection.GetPageInfo("descriptionAttachments", depth))
                    yield return pageInfo;

            if (FeaturesAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in FeaturesAttachmentsCollection.GetPageInfo("featuresAttachments", depth))
                    yield return pageInfo;
        }
    }
}
