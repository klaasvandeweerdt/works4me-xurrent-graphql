using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Broadcast"/> query class.
    /// </summary>
    public class BroadcastQuery : Query<Broadcast, BroadcastQuery, DefaultView, BroadcastField, BroadcastFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="BroadcastQuery"/> instance.
        /// </summary>
        public BroadcastQuery() : base("broadcasts", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Account" sub-query.</returns>
        public BroadcastQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Used to select one or more customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This field is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        /// <param name="query">The customers query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Customers" sub-query.</returns>
        public BroadcastQuery SelectCustomers(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customers", query, true);
        }

        /// <summary>
        /// The email template used for the email broadcast. This email template needs to be of the type Send Email from Broadcast.
        /// </summary>
        /// <param name="query">The email template query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "EmailTemplate" sub-query.</returns>
        public BroadcastQuery SelectEmailTemplate(EmailTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("emailTemplate", query, false);
        }

        /// <summary>
        /// Used to select the organizations, to which people belong, that need to see the broadcast.
        /// </summary>
        /// <param name="query">The organizations query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Organizations" sub-query.</returns>
        public BroadcastQuery SelectOrganizations(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organizations", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public BroadcastQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// Grouped request to which customers can add request to indicate they are also affected.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Request" sub-query.</returns>
        public BroadcastQuery SelectRequest(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("request", query, false);
        }

        /// <summary>
        /// Used to select the service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This table field is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public BroadcastQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// Used to select the sites for which people need to see the broadcast.
        /// </summary>
        /// <param name="query">The sites query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Sites" sub-query.</returns>
        public BroadcastQuery SelectSites(SiteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sites", query, true);
        }

        /// <summary>
        /// Used to select the skill pools, to which people belong, that need to see the broadcast.
        /// </summary>
        /// <param name="query">The skill pools query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "SkillPools" sub-query.</returns>
        public BroadcastQuery SelectSkillPools(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPools", query, true);
        }

        /// <summary>
        /// Used to select the service level agreements for which the customer representatives will receive the email broadcast. This is only available for broadcasts when the message type "email" is selected.
        /// </summary>
        /// <param name="query">The slas query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Slas" sub-query.</returns>
        public BroadcastQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("slas", query, true);
        }

        /// <summary>
        /// Used to select the teams which members need to see the broadcast. This table field is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        /// <param name="query">The teams query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Teams" sub-query.</returns>
        public BroadcastQuery SelectTeams(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("teams", query, true);
        }

        /// <summary>
        /// Broadcast's message in different languages.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="BroadcastQuery"/>, updated to include the "Translations" sub-query.</returns>
        public BroadcastQuery SelectTranslations(BroadcastTranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
