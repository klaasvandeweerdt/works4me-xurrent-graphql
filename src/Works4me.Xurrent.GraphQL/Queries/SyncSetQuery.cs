using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SyncSet"/> query class.
    /// </summary>
    public class SyncSetQuery : Query<SyncSet, SyncSetQuery, DefaultView, SyncSetField, SyncSetFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SyncSetQuery"/> instance.
        /// </summary>
        public SyncSetQuery() : base("syncSets", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "Account" sub-query.</returns>
        public SyncSetQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the <c>description</c> field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public SyncSetQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// The latest completed snapshot of this sync set.
        /// </summary>
        /// <param name="query">The last snapshot query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "LastSnapshot" sub-query.</returns>
        public SyncSetQuery SelectLastSnapshot(SnapshotQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("lastSnapshot", query, false);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="accountDesignQuery">The account design query.</param>
        /// <param name="agileBoardQuery">The agile board query.</param>
        /// <param name="agileBoardColumnQuery">The agile board column query.</param>
        /// <param name="appInstanceQuery">The app instance query.</param>
        /// <param name="appOfferingQuery">The app offering query.</param>
        /// <param name="appOfferingAutomationRuleQuery">The app offering automation rule query.</param>
        /// <param name="automationRuleQuery">The automation rule query.</param>
        /// <param name="broadcastQuery">The broadcast query.</param>
        /// <param name="calendarQuery">The calendar query.</param>
        /// <param name="closureCodeQuery">The closure code query.</param>
        /// <param name="configurationItemQuery">The configuration item query.</param>
        /// <param name="contractQuery">The contract query.</param>
        /// <param name="customCollectionQuery">The custom collection query.</param>
        /// <param name="customCollectionElementQuery">The custom collection element query.</param>
        /// <param name="effortClassQuery">The effort class query.</param>
        /// <param name="emailTemplateQuery">The email template query.</param>
        /// <param name="firstLineSupportAgreementQuery">The first line support agreement query.</param>
        /// <param name="holidayQuery">The holiday query.</param>
        /// <param name="invoiceQuery">The invoice query.</param>
        /// <param name="knowledgeArticleQuery">The knowledge article query.</param>
        /// <param name="knowledgeArticleTemplateQuery">The knowledge article template query.</param>
        /// <param name="organizationQuery">The organization query.</param>
        /// <param name="outOfOfficePeriodQuery">The out of office period query.</param>
        /// <param name="pdfDesignQuery">The pdf design query.</param>
        /// <param name="personQuery">The person query.</param>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="productQuery">The product query.</param>
        /// <param name="productBacklogQuery">The product backlog query.</param>
        /// <param name="productCategoryQuery">The product category query.</param>
        /// <param name="projectQuery">The project query.</param>
        /// <param name="projectCategoryQuery">The project category query.</param>
        /// <param name="projectRiskLevelQuery">The project risk level query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="projectTaskTemplateQuery">The project task template query.</param>
        /// <param name="projectTemplateQuery">The project template query.</param>
        /// <param name="releaseQuery">The release query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="requestTemplateQuery">The request template query.</param>
        /// <param name="reservationQuery">The reservation query.</param>
        /// <param name="reservationOfferingQuery">The reservation offering query.</param>
        /// <param name="riskQuery">The risk query.</param>
        /// <param name="riskSeverityQuery">The risk severity query.</param>
        /// <param name="scrumWorkspaceQuery">The scrum workspace query.</param>
        /// <param name="serviceQuery">The service query.</param>
        /// <param name="serviceCategoryQuery">The service category query.</param>
        /// <param name="serviceInstanceQuery">The service instance query.</param>
        /// <param name="serviceLevelAgreementQuery">The service level agreement query.</param>
        /// <param name="serviceOfferingQuery">The service offering query.</param>
        /// <param name="shopArticleQuery">The shop article query.</param>
        /// <param name="shopArticleCategoryQuery">The shop article category query.</param>
        /// <param name="shopOrderLineQuery">The shop order line query.</param>
        /// <param name="shortUrlQuery">The short url query.</param>
        /// <param name="siteQuery">The site query.</param>
        /// <param name="skillPoolQuery">The skill pool query.</param>
        /// <param name="slaCoverageGroupQuery">The sla coverage group query.</param>
        /// <param name="slaNotificationSchemeQuery">The sla notification scheme query.</param>
        /// <param name="sprintQuery">The sprint query.</param>
        /// <param name="sprintBacklogItemQuery">The sprint backlog item query.</param>
        /// <param name="surveyQuery">The survey query.</param>
        /// <param name="surveyAnswerQuery">The survey answer query.</param>
        /// <param name="surveyQuestionQuery">The survey question query.</param>
        /// <param name="surveyResponseQuery">The survey response query.</param>
        /// <param name="syncSetQuery">The sync set query.</param>
        /// <param name="tagQuery">The tag query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <param name="workflowTaskTemplateQuery">The workflow task template query.</param>
        /// <param name="teamQuery">The team query.</param>
        /// <param name="timeAllocationQuery">The time allocation query.</param>
        /// <param name="timeEntryQuery">The time entry query.</param>
        /// <param name="timesheetSettingQuery">The timesheet setting query.</param>
        /// <param name="translationQuery">The translation query.</param>
        /// <param name="uiExtensionQuery">The ui extension query.</param>
        /// <param name="waitingForCustomerFollowUpQuery">The waiting for customer follow up query.</param>
        /// <param name="webhookQuery">The webhook query.</param>
        /// <param name="webhookPolicyQuery">The webhook policy query.</param>
        /// <param name="workflowQuery">The workflow query.</param>
        /// <param name="workflowTemplateQuery">The workflow template query.</param>
        /// <param name="workflowTypeQuery">The workflow type query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the sub-queries.</returns>
        public SyncSetQuery SelectSelectedRecordsAll(
            AccountDesignQuery? accountDesignQuery = null,
            AgileBoardQuery? agileBoardQuery = null,
            AgileBoardColumnQuery? agileBoardColumnQuery = null,
            AppInstanceQuery? appInstanceQuery = null,
            AppOfferingQuery? appOfferingQuery = null,
            AppOfferingAutomationRuleQuery? appOfferingAutomationRuleQuery = null,
            AutomationRuleQuery? automationRuleQuery = null,
            BroadcastQuery? broadcastQuery = null,
            CalendarQuery? calendarQuery = null,
            ClosureCodeQuery? closureCodeQuery = null,
            ConfigurationItemQuery? configurationItemQuery = null,
            ContractQuery? contractQuery = null,
            CustomCollectionQuery? customCollectionQuery = null,
            CustomCollectionElementQuery? customCollectionElementQuery = null,
            EffortClassQuery? effortClassQuery = null,
            EmailTemplateQuery? emailTemplateQuery = null,
            FirstLineSupportAgreementQuery? firstLineSupportAgreementQuery = null,
            HolidayQuery? holidayQuery = null,
            InvoiceQuery? invoiceQuery = null,
            KnowledgeArticleQuery? knowledgeArticleQuery = null,
            KnowledgeArticleTemplateQuery? knowledgeArticleTemplateQuery = null,
            OrganizationQuery? organizationQuery = null,
            OutOfOfficePeriodQuery? outOfOfficePeriodQuery = null,
            PdfDesignQuery? pdfDesignQuery = null,
            PersonQuery? personQuery = null,
            ProblemQuery? problemQuery = null,
            ProductQuery? productQuery = null,
            ProductBacklogQuery? productBacklogQuery = null,
            ProductCategoryQuery? productCategoryQuery = null,
            ProjectQuery? projectQuery = null,
            ProjectCategoryQuery? projectCategoryQuery = null,
            ProjectRiskLevelQuery? projectRiskLevelQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            ProjectTaskTemplateQuery? projectTaskTemplateQuery = null,
            ProjectTemplateQuery? projectTemplateQuery = null,
            ReleaseQuery? releaseQuery = null,
            RequestQuery? requestQuery = null,
            RequestTemplateQuery? requestTemplateQuery = null,
            ReservationQuery? reservationQuery = null,
            ReservationOfferingQuery? reservationOfferingQuery = null,
            RiskQuery? riskQuery = null,
            RiskSeverityQuery? riskSeverityQuery = null,
            ScrumWorkspaceQuery? scrumWorkspaceQuery = null,
            ServiceQuery? serviceQuery = null,
            ServiceCategoryQuery? serviceCategoryQuery = null,
            ServiceInstanceQuery? serviceInstanceQuery = null,
            ServiceLevelAgreementQuery? serviceLevelAgreementQuery = null,
            ServiceOfferingQuery? serviceOfferingQuery = null,
            ShopArticleQuery? shopArticleQuery = null,
            ShopArticleCategoryQuery? shopArticleCategoryQuery = null,
            ShopOrderLineQuery? shopOrderLineQuery = null,
            ShortUrlQuery? shortUrlQuery = null,
            SiteQuery? siteQuery = null,
            SkillPoolQuery? skillPoolQuery = null,
            SlaCoverageGroupQuery? slaCoverageGroupQuery = null,
            SlaNotificationSchemeQuery? slaNotificationSchemeQuery = null,
            SprintQuery? sprintQuery = null,
            SprintBacklogItemQuery? sprintBacklogItemQuery = null,
            SurveyQuery? surveyQuery = null,
            SurveyAnswerQuery? surveyAnswerQuery = null,
            SurveyQuestionQuery? surveyQuestionQuery = null,
            SurveyResponseQuery? surveyResponseQuery = null,
            SyncSetQuery? syncSetQuery = null,
            TagQuery? tagQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null,
            WorkflowTaskTemplateQuery? workflowTaskTemplateQuery = null,
            TeamQuery? teamQuery = null,
            TimeAllocationQuery? timeAllocationQuery = null,
            TimeEntryQuery? timeEntryQuery = null,
            TimesheetSettingQuery? timesheetSettingQuery = null,
            TranslationQuery? translationQuery = null,
            UiExtensionQuery? uiExtensionQuery = null,
            WaitingForCustomerFollowUpQuery? waitingForCustomerFollowUpQuery = null,
            WebhookQuery? webhookQuery = null,
            WebhookPolicyQuery? webhookPolicyQuery = null,
            WorkflowQuery? workflowQuery = null,
            WorkflowTemplateQuery? workflowTemplateQuery = null,
            WorkflowTypeQuery? workflowTypeQuery = null)
        {
            SyncSetQuery query = SelectOnType("selectedRecords", accountDesignQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", agileBoardQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", agileBoardColumnQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", appInstanceQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", appOfferingQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", appOfferingAutomationRuleQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", automationRuleQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", broadcastQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", calendarQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", closureCodeQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", configurationItemQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", contractQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", customCollectionQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", customCollectionElementQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", effortClassQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", emailTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", firstLineSupportAgreementQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", holidayQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", invoiceQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", knowledgeArticleQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", knowledgeArticleTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", organizationQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", outOfOfficePeriodQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", pdfDesignQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", personQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", problemQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", productQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", productBacklogQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", productCategoryQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", projectQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", projectCategoryQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", projectRiskLevelQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", projectTaskQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", projectTaskTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", projectTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", releaseQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", requestQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", requestTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", reservationQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", reservationOfferingQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", riskQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", riskSeverityQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", scrumWorkspaceQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", serviceQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", serviceCategoryQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", serviceInstanceQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", serviceLevelAgreementQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", serviceOfferingQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", shopArticleQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", shopArticleCategoryQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", shopOrderLineQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", shortUrlQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", siteQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", skillPoolQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", slaCoverageGroupQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", slaNotificationSchemeQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", sprintQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", sprintBacklogItemQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", surveyQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", surveyAnswerQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", surveyQuestionQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", surveyResponseQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", syncSetQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", tagQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", workflowTaskQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", workflowTaskTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", teamQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", timeAllocationQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", timeEntryQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", timesheetSettingQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", translationQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", uiExtensionQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", waitingForCustomerFollowUpQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", webhookQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", webhookPolicyQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", workflowQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", workflowTemplateQuery ?? new(), true);
            query = query.SelectOnType("selectedRecords", workflowTypeQuery ?? new(), true);
            return query;
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AccountDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AppInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AppOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AppOfferingAutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(BroadcastQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ClosureCodeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ContractQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(CustomCollectionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(CustomCollectionElementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(EmailTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(FirstLineSupportAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(HolidayQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(KnowledgeArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(KnowledgeArticleTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(OutOfOfficePeriodQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(PdfDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProductQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProductBacklogQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProductCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProjectCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProjectRiskLevelQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProjectTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ProjectTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ReleaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ReservationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ReservationOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(RiskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(RiskSeverityQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ScrumWorkspaceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ServiceCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ShopArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ShopArticleCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ShopOrderLineQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(ShortUrlQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SiteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SlaCoverageGroupQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SlaNotificationSchemeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SprintQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SprintBacklogItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SurveyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SurveyAnswerQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SurveyQuestionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SurveyResponseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(SyncSetQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(TagQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WorkflowTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(TimeAllocationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(TimesheetSettingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WaitingForCustomerFollowUpQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WebhookQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WebhookPolicyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }

        /// <summary>
        /// Individual records selected to be included in the sync set.<br />
        /// Use this method along with other <c>SelectSelectedRecords()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectSelectedRecords()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The selected records query.</param>
        /// <returns>The same <see cref="SyncSetQuery"/>, updated to include the "SelectedRecords" sub-query.</returns>
        public SyncSetQuery SelectSelectedRecords(WorkflowTypeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("selectedRecords", query, true);
        }
    }
}
