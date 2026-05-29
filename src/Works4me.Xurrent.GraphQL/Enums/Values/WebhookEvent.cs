using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The webhook event values.
    /// </summary>
    public enum WebhookEvent
    {
        /// <summary>
        /// App instance create.
        /// </summary>
        [XurrentEnum("app_instance.create")]
        AppInstanceCreate,

        /// <summary>
        /// App instance delete.
        /// </summary>
        [XurrentEnum("app_instance.delete")]
        AppInstanceDelete,

        /// <summary>
        /// App instance secrets update.
        /// </summary>
        [XurrentEnum("app_instance.secrets-update")]
        AppInstanceSecretsUpdate,

        /// <summary>
        /// App instance update.
        /// </summary>
        [XurrentEnum("app_instance.update")]
        AppInstanceUpdate,

        /// <summary>
        /// Automation rule.
        /// </summary>
        [XurrentEnum("automation_rule")]
        AutomationRule,

        /// <summary>
        /// Broadcast create.
        /// </summary>
        [XurrentEnum("broadcast.create")]
        BroadcastCreate,

        /// <summary>
        /// Broadcast update.
        /// </summary>
        [XurrentEnum("broadcast.update")]
        BroadcastUpdate,

        /// <summary>
        /// Ci create.
        /// </summary>
        [XurrentEnum("ci.create")]
        CiCreate,

        /// <summary>
        /// Ci update.
        /// </summary>
        [XurrentEnum("ci.update")]
        CiUpdate,

        /// <summary>
        /// Contract create.
        /// </summary>
        [XurrentEnum("contract.create")]
        ContractCreate,

        /// <summary>
        /// Contract update.
        /// </summary>
        [XurrentEnum("contract.update")]
        ContractUpdate,

        /// <summary>
        /// Flsa create.
        /// </summary>
        [XurrentEnum("flsa.create")]
        FlsaCreate,

        /// <summary>
        /// Flsa update.
        /// </summary>
        [XurrentEnum("flsa.update")]
        FlsaUpdate,

        /// <summary>
        /// Knowledge article create.
        /// </summary>
        [XurrentEnum("knowledge_article.create")]
        KnowledgeArticleCreate,

        /// <summary>
        /// Knowledge article update.
        /// </summary>
        [XurrentEnum("knowledge_article.update")]
        KnowledgeArticleUpdate,

        /// <summary>
        /// Organization create.
        /// </summary>
        [XurrentEnum("organization.create")]
        OrganizationCreate,

        /// <summary>
        /// Organization update.
        /// </summary>
        [XurrentEnum("organization.update")]
        OrganizationUpdate,

        /// <summary>
        /// Out of office period create.
        /// </summary>
        [XurrentEnum("out_of_office_period.create")]
        OutOfOfficePeriodCreate,

        /// <summary>
        /// Out of office period delete.
        /// </summary>
        [XurrentEnum("out_of_office_period.delete")]
        OutOfOfficePeriodDelete,

        /// <summary>
        /// Out of office period update.
        /// </summary>
        [XurrentEnum("out_of_office_period.update")]
        OutOfOfficePeriodUpdate,

        /// <summary>
        /// Person create.
        /// </summary>
        [XurrentEnum("person.create")]
        PersonCreate,

        /// <summary>
        /// Person update.
        /// </summary>
        [XurrentEnum("person.update")]
        PersonUpdate,

        /// <summary>
        /// Problem create.
        /// </summary>
        [XurrentEnum("problem.create")]
        ProblemCreate,

        /// <summary>
        /// Problem manager changed.
        /// </summary>
        [XurrentEnum("problem.manager-changed")]
        ProblemManagerChanged,

        /// <summary>
        /// Problem member changed.
        /// </summary>
        [XurrentEnum("problem.member-changed")]
        ProblemMemberChanged,

        /// <summary>
        /// Problem note added.
        /// </summary>
        [XurrentEnum("problem.note-added")]
        ProblemNoteAdded,

        /// <summary>
        /// Problem status changed.
        /// </summary>
        [XurrentEnum("problem.status-changed")]
        ProblemStatusChanged,

        /// <summary>
        /// Problem team changed.
        /// </summary>
        [XurrentEnum("problem.team-changed")]
        ProblemTeamChanged,

        /// <summary>
        /// Problem update.
        /// </summary>
        [XurrentEnum("problem.update")]
        ProblemUpdate,

        /// <summary>
        /// Product create.
        /// </summary>
        [XurrentEnum("product.create")]
        ProductCreate,

        /// <summary>
        /// Product update.
        /// </summary>
        [XurrentEnum("product.update")]
        ProductUpdate,

        /// <summary>
        /// Project task create.
        /// </summary>
        [XurrentEnum("project_task.create")]
        ProjectTaskCreate,

        /// <summary>
        /// Project task delete.
        /// </summary>
        [XurrentEnum("project_task.delete")]
        ProjectTaskDelete,

        /// <summary>
        /// Project task note added.
        /// </summary>
        [XurrentEnum("project_task.note-added")]
        ProjectTaskNoteAdded,

        /// <summary>
        /// Project task status changed.
        /// </summary>
        [XurrentEnum("project_task.status-changed")]
        ProjectTaskStatusChanged,

        /// <summary>
        /// Project task update.
        /// </summary>
        [XurrentEnum("project_task.update")]
        ProjectTaskUpdate,

        /// <summary>
        /// Project create.
        /// </summary>
        [XurrentEnum("project.create")]
        ProjectCreate,

        /// <summary>
        /// Project manager changed.
        /// </summary>
        [XurrentEnum("project.manager-changed")]
        ProjectManagerChanged,

        /// <summary>
        /// Project note added.
        /// </summary>
        [XurrentEnum("project.note-added")]
        ProjectNoteAdded,

        /// <summary>
        /// Project status changed.
        /// </summary>
        [XurrentEnum("project.status-changed")]
        ProjectStatusChanged,

        /// <summary>
        /// Project update.
        /// </summary>
        [XurrentEnum("project.update")]
        ProjectUpdate,

        /// <summary>
        /// Release create.
        /// </summary>
        [XurrentEnum("release.create")]
        ReleaseCreate,

        /// <summary>
        /// Release manager changed.
        /// </summary>
        [XurrentEnum("release.manager-changed")]
        ReleaseManagerChanged,

        /// <summary>
        /// Release note added.
        /// </summary>
        [XurrentEnum("release.note-added")]
        ReleaseNoteAdded,

        /// <summary>
        /// Release update.
        /// </summary>
        [XurrentEnum("release.update")]
        ReleaseUpdate,

        /// <summary>
        /// Request agile board column changed.
        /// </summary>
        [XurrentEnum("request.agile-board-column-changed")]
        RequestAgileBoardColumnChanged,

        /// <summary>
        /// Request create.
        /// </summary>
        [XurrentEnum("request.create")]
        RequestCreate,

        /// <summary>
        /// Request major incident status changed.
        /// </summary>
        [XurrentEnum("request.major-incident-status-changed")]
        RequestMajorIncidentStatusChanged,

        /// <summary>
        /// Request member changed.
        /// </summary>
        [XurrentEnum("request.member-changed")]
        RequestMemberChanged,

        /// <summary>
        /// Request note added.
        /// </summary>
        [XurrentEnum("request.note-added")]
        RequestNoteAdded,

        /// <summary>
        /// Request status changed.
        /// </summary>
        [XurrentEnum("request.status-changed")]
        RequestStatusChanged,

        /// <summary>
        /// Request team changed.
        /// </summary>
        [XurrentEnum("request.team-changed")]
        RequestTeamChanged,

        /// <summary>
        /// Request update.
        /// </summary>
        [XurrentEnum("request.update")]
        RequestUpdate,

        /// <summary>
        /// Risk create.
        /// </summary>
        [XurrentEnum("risk.create")]
        RiskCreate,

        /// <summary>
        /// Risk manager changed.
        /// </summary>
        [XurrentEnum("risk.manager-changed")]
        RiskManagerChanged,

        /// <summary>
        /// Risk note added.
        /// </summary>
        [XurrentEnum("risk.note-added")]
        RiskNoteAdded,

        /// <summary>
        /// Risk status changed.
        /// </summary>
        [XurrentEnum("risk.status-changed")]
        RiskStatusChanged,

        /// <summary>
        /// Risk update.
        /// </summary>
        [XurrentEnum("risk.update")]
        RiskUpdate,

        /// <summary>
        /// Service instance create.
        /// </summary>
        [XurrentEnum("service_instance.create")]
        ServiceInstanceCreate,

        /// <summary>
        /// Service instance update.
        /// </summary>
        [XurrentEnum("service_instance.update")]
        ServiceInstanceUpdate,

        /// <summary>
        /// Service offering create.
        /// </summary>
        [XurrentEnum("service_offering.create")]
        ServiceOfferingCreate,

        /// <summary>
        /// Service offering update.
        /// </summary>
        [XurrentEnum("service_offering.update")]
        ServiceOfferingUpdate,

        /// <summary>
        /// Service create.
        /// </summary>
        [XurrentEnum("service.create")]
        ServiceCreate,

        /// <summary>
        /// Service update.
        /// </summary>
        [XurrentEnum("service.update")]
        ServiceUpdate,

        /// <summary>
        /// Sla create.
        /// </summary>
        [XurrentEnum("sla.create")]
        SlaCreate,

        /// <summary>
        /// Sla update.
        /// </summary>
        [XurrentEnum("sla.update")]
        SlaUpdate,

        /// <summary>
        /// Task create.
        /// </summary>
        [XurrentEnum("task.create")]
        TaskCreate,

        /// <summary>
        /// Task member changed.
        /// </summary>
        [XurrentEnum("task.member-changed")]
        TaskMemberChanged,

        /// <summary>
        /// Task note added.
        /// </summary>
        [XurrentEnum("task.note-added")]
        TaskNoteAdded,

        /// <summary>
        /// Task status changed.
        /// </summary>
        [XurrentEnum("task.status-changed")]
        TaskStatusChanged,

        /// <summary>
        /// Task team changed.
        /// </summary>
        [XurrentEnum("task.team-changed")]
        TaskTeamChanged,

        /// <summary>
        /// Task update.
        /// </summary>
        [XurrentEnum("task.update")]
        TaskUpdate,

        /// <summary>
        /// Team create.
        /// </summary>
        [XurrentEnum("team.create")]
        TeamCreate,

        /// <summary>
        /// Team update.
        /// </summary>
        [XurrentEnum("team.update")]
        TeamUpdate,

        /// <summary>
        /// Time entry create.
        /// </summary>
        [XurrentEnum("time_entry.create")]
        TimeEntryCreate,

        /// <summary>
        /// Time entry delete.
        /// </summary>
        [XurrentEnum("time_entry.delete")]
        TimeEntryDelete,

        /// <summary>
        /// Time entry update.
        /// </summary>
        [XurrentEnum("time_entry.update")]
        TimeEntryUpdate,

        /// <summary>
        /// Webhook verify.
        /// </summary>
        [XurrentEnum("webhook.verify")]
        WebhookVerify,

        /// <summary>
        /// Workflow create.
        /// </summary>
        [XurrentEnum("workflow.create")]
        WorkflowCreate,

        /// <summary>
        /// Workflow manager changed.
        /// </summary>
        [XurrentEnum("workflow.manager-changed")]
        WorkflowManagerChanged,

        /// <summary>
        /// Workflow note added.
        /// </summary>
        [XurrentEnum("workflow.note-added")]
        WorkflowNoteAdded,

        /// <summary>
        /// Workflow status changed.
        /// </summary>
        [XurrentEnum("workflow.status-changed")]
        WorkflowStatusChanged,

        /// <summary>
        /// Workflow update.
        /// </summary>
        [XurrentEnum("workflow.update")]
        WorkflowUpdate
    }
}
