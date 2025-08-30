using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Service"/> query class.
    /// </summary>
    public class ServiceQuery : Query<Service, ServiceQuery, ServiceView, ServiceField, ServiceFilterField, ServiceOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ServiceQuery"/> instance.
        /// </summary>
        public ServiceQuery() : base("services", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "Account" sub-query.</returns>
        public ServiceQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The person who is responsible for ensuring that the availability targets specified in the active SLAs for the service are met.
        /// </summary>
        /// <param name="query">The availability manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "AvailabilityManager" sub-query.</returns>
        public ServiceQuery SelectAvailabilityManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("availabilityManager", query, false);
        }

        /// <summary>
        /// The person who is responsible for ensuring that the service is not affected by incidents that are caused by capacity shortages.
        /// </summary>
        /// <param name="query">The capacity manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "CapacityManager" sub-query.</returns>
        public ServiceQuery SelectCapacityManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("capacityManager", query, false);
        }

        /// <summary>
        /// The person who is responsible for coordinating the changes of the service.
        /// </summary>
        /// <param name="query">The change manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ChangeManager" sub-query.</returns>
        public ServiceQuery SelectChangeManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("changeManager", query, false);
        }

        /// <summary>
        /// The person who is responsible for creating and maintaining the continuity plans for the service's instances that have an active SLA with a continuity target.
        /// </summary>
        /// <param name="query">The continuity manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ContinuityManager" sub-query.</returns>
        public ServiceQuery SelectContinuityManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("continuityManager", query, false);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ServiceQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ServiceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public ServiceQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// The team that will, by default, be selected in the First line team field of a new service instance when it is being registered for the service.
        /// </summary>
        /// <param name="query">The first line team query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "FirstLineTeam" sub-query.</returns>
        public ServiceQuery SelectFirstLineTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("firstLineTeam", query, false);
        }

        /// <summary>
        /// The person who is responsible for the quality of the knowledge articles for the service.
        /// </summary>
        /// <param name="query">The knowledge manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "KnowledgeManager" sub-query.</returns>
        public ServiceQuery SelectKnowledgeManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("knowledgeManager", query, false);
        }

        /// <summary>
        /// The person who is responsible for coordinating the problems that directly affect the service.
        /// </summary>
        /// <param name="query">The problem manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ProblemManager" sub-query.</returns>
        public ServiceQuery SelectProblemManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("problemManager", query, false);
        }

        /// <summary>
        /// The person who is responsible for coordinating the releases of the service.
        /// </summary>
        /// <param name="query">The release manager query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ReleaseManager" sub-query.</returns>
        public ServiceQuery SelectReleaseManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("releaseManager", query, false);
        }

        /// <summary>
        /// Service instances related to this service.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public ServiceQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// Service level agreements related to this service through the service offering.
        /// </summary>
        /// <param name="query">The service level agreements query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ServiceLevelAgreements" sub-query.</returns>
        public ServiceQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceLevelAgreements", query, true);
        }

        /// <summary>
        /// Service offerings related to this service.
        /// </summary>
        /// <param name="query">The service offerings query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ServiceOfferings" sub-query.</returns>
        public ServiceQuery SelectServiceOfferings(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOfferings", query, true);
        }

        /// <summary>
        /// The person who is responsible for ensuring that the service level targets specified in the SLAs for the service are met.
        /// </summary>
        /// <param name="query">The service owner query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ServiceOwner" sub-query.</returns>
        public ServiceQuery SelectServiceOwner(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOwner", query, false);
        }

        /// <summary>
        /// The organization that provides the service.
        /// </summary>
        /// <param name="query">The service provider query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "ServiceProvider" sub-query.</returns>
        public ServiceQuery SelectServiceProvider(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceProvider", query, false);
        }

        /// <summary>
        /// The team  that will, by default, be selected in the Support team field of a service instance when one is registered for the service. Similarly, this team will be selected in the Team field of a problem when the service is related to it.
        /// </summary>
        /// <param name="query">The support team query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "SupportTeam" sub-query.</returns>
        public ServiceQuery SelectSupportTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportTeam", query, false);
        }

        /// <summary>
        /// Survey used to measure customer rating of this service.
        /// </summary>
        /// <param name="query">The survey query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "Survey" sub-query.</returns>
        public ServiceQuery SelectSurvey(SurveyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("survey", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "Translations" sub-query.</returns>
        public ServiceQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ServiceQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ServiceQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Service">Service</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/servicecustomfilter/">Xurrent developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">
        /// Use value <c>null</c> to indicate "None".
        /// 
        /// For "text" fields:
        /// • One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).
        /// 
        /// For "number" and "time" fields:
        /// • One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.
        /// • Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.
        /// • <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.
        /// • <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.
        /// 
        /// For "date" and "date-time" fields:
        /// • One must supply a single value (and <c>null</c> is not supported).
        /// • Matches are always relative with an optional upper bound.
        /// • Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).
        /// • Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).
        /// • <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.
        /// 
        /// For "select" fields:
        /// • One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).
        /// • Matches are case-sensitive.
        /// </param>
        public ServiceQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ServiceQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ServiceQuery">ServiceQuery</see>, updated to include the "Search" sub-query.</returns>
        public ServiceQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
