using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AppOffering"/> query class.
    /// </summary>
    public class AppOfferingQuery : Query<AppOffering, AppOfferingQuery, AppOfferingView, AppOfferingField, AppOfferingFilterField, AppOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AppOfferingQuery"/> instance.
        /// </summary>
        public AppOfferingQuery() : base("appOfferings", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "Account" sub-query.</returns>
        public AppOfferingQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Instances of this app.
        /// </summary>
        /// <param name="query">The app instances query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "AppInstances" sub-query.</returns>
        public AppOfferingQuery SelectAppInstances(AppInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("appInstances", query, true);
        }

        /// <summary>
        /// Automation rules of this app offering.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public AppOfferingQuery SelectAutomationRules(AppOfferingAutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Compliance field.
        /// </summary>
        /// <param name="query">The compliance attachments query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "ComplianceAttachments" sub-query.</returns>
        public AppOfferingQuery SelectComplianceAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("complianceAttachments", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public AppOfferingQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Features field.
        /// </summary>
        /// <param name="query">The features attachments query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "FeaturesAttachments" sub-query.</returns>
        public AppOfferingQuery SelectFeaturesAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("featuresAttachments", query, true);
        }

        /// <summary>
        /// Scopes of this app offering.
        /// </summary>
        /// <param name="query">The scopes query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "Scopes" sub-query.</returns>
        public AppOfferingQuery SelectScopes(AppOfferingScopeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("scopes", query, false);
        }

        /// <summary>
        /// Service instance that is linked to the app offering.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public AppOfferingQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }

        /// <summary>
        /// UI extension version that is linked to the app offering.
        /// </summary>
        /// <param name="query">The ui extension version query.</param>
        /// <returns>The same <see cref="AppOfferingQuery"/>, updated to include the "UiExtensionVersion" sub-query.</returns>
        public AppOfferingQuery SelectUiExtensionVersion(UiExtensionVersionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtensionVersion", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="AppOfferingQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="AppOfferingQuery">AppOfferingQuery</see>, updated to include the "Search" sub-query.</returns>
        public AppOfferingQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
