using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RequestTemplate"/> query class.
    /// </summary>
    public class RequestTemplateQuery : Query<RequestTemplate, RequestTemplateQuery, RequestTemplateView, RequestTemplateField, RequestTemplateFilterField, RequestTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RequestTemplateQuery"/> instance.
        /// </summary>
        public RequestTemplateQuery() : base("requestTemplates", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Account" sub-query.</returns>
        public RequestTemplateQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public RequestTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// The CI that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "ConfigurationItem" sub-query.</returns>
        public RequestTemplateQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItem", query, false);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public RequestTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public RequestTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// Used to select the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The member query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Member" sub-query.</returns>
        public RequestTemplateQuery SelectMember(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("member", query, false);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The note attachments query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "NoteAttachments" sub-query.</returns>
        public RequestTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("noteAttachments", query, true);
        }

        /// <summary>
        /// Organizations related to the order request template.
        /// </summary>
        /// <param name="query">The organizations query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Organizations" sub-query.</returns>
        public RequestTemplateQuery SelectOrganizations(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organizations", query, true);
        }

        /// <summary>
        /// Inline images linked to the Registration hints field.
        /// </summary>
        /// <param name="query">The registration hints attachments query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "RegistrationHintsAttachments" sub-query.</returns>
        public RequestTemplateQuery SelectRegistrationHintsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("registrationHintsAttachments", query, true);
        }

        /// <summary>
        /// Requests created using the request template.
        /// </summary>
        /// <param name="query">The requests query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Requests" sub-query.</returns>
        public RequestTemplateQuery SelectRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requests", query, true);
        }

        /// <summary>
        /// Reservation offerings related to the request template.
        /// </summary>
        /// <param name="query">The reservation offerings query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "ReservationOfferings" sub-query.</returns>
        public RequestTemplateQuery SelectReservationOfferings(ReservationOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("reservationOfferings", query, true);
        }

        /// <summary>
        /// The service for which the request template is made available.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Service" sub-query.</returns>
        public RequestTemplateQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Standard service requests related to the request template.
        /// </summary>
        /// <param name="query">The standard service requests query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "StandardServiceRequests" sub-query.</returns>
        public RequestTemplateQuery SelectStandardServiceRequests(StandardServiceRequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("standardServiceRequests", query, true);
        }

        /// <summary>
        /// Used to select the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public RequestTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        /// <param name="query">The support hours query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "SupportHours" sub-query.</returns>
        public RequestTemplateQuery SelectSupportHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supportHours", query, false);
        }

        /// <summary>
        /// The team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Team" sub-query.</returns>
        public RequestTemplateQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "Translations" sub-query.</returns>
        public RequestTemplateQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// UI extension that is to be added to a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public RequestTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Used to relate a Workflow Manager to the request template. _Required_ when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        /// <param name="query">The workflow manager query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "WorkflowManager" sub-query.</returns>
        public RequestTemplateQuery SelectWorkflowManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowManager", query, false);
        }

        /// <summary>
        /// Used to relate a Workflow Template to the request template. _Required_ when the _Status_ is set to _Workflow Pending_.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>The same <see cref="RequestTemplateQuery"/>, updated to include the "WorkflowTemplate" sub-query.</returns>
        public RequestTemplateQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowTemplate", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="RequestTemplateQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="RequestTemplateQuery">RequestTemplateQuery</see>, updated to include the "Search" sub-query.</returns>
        public RequestTemplateQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
