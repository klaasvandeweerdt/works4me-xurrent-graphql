using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The permission role values.
    /// </summary>
    public enum PermissionRole
    {
        /// <summary>
        /// Account administrator.
        /// </summary>
        [XurrentEnum("account_administrator")]
        AccountAdministrator,

        /// <summary>
        /// Account designer.
        /// </summary>
        [XurrentEnum("account_designer")]
        AccountDesigner,

        /// <summary>
        /// Account owner.
        /// </summary>
        [XurrentEnum("account_owner")]
        AccountOwner,

        /// <summary>
        /// Auditor.
        /// </summary>
        [XurrentEnum("auditor")]
        Auditor,

        /// <summary>
        /// Configuration manager.
        /// </summary>
        [XurrentEnum("configuration_manager")]
        ConfigurationManager,

        /// <summary>
        /// Directory administrator.
        /// </summary>
        [XurrentEnum("directory_administrator")]
        DirectoryAdministrator,

        /// <summary>
        /// Directory auditor.
        /// </summary>
        [XurrentEnum("directory_auditor")]
        DirectoryAuditor,

        /// <summary>
        /// Directory designer.
        /// </summary>
        [XurrentEnum("directory_designer")]
        DirectoryDesigner,

        /// <summary>
        /// Financial manager.
        /// </summary>
        [XurrentEnum("financial_manager")]
        FinancialManager,

        /// <summary>
        /// Key contact.
        /// </summary>
        [XurrentEnum("key_contact")]
        KeyContact,

        /// <summary>
        /// Knowledge manager.
        /// </summary>
        [XurrentEnum("knowledge_manager")]
        KnowledgeManager,

        /// <summary>
        /// Problem manager.
        /// </summary>
        [XurrentEnum("problem_manager")]
        ProblemManager,

        /// <summary>
        /// Project manager.
        /// </summary>
        [XurrentEnum("project_manager")]
        ProjectManager,

        /// <summary>
        /// Release manager.
        /// </summary>
        [XurrentEnum("release_manager")]
        ReleaseManager,

        /// <summary>
        /// Service desk analyst.
        /// </summary>
        [XurrentEnum("service_desk_analyst")]
        ServiceDeskAnalyst,

        /// <summary>
        /// Service desk manager.
        /// </summary>
        [XurrentEnum("service_desk_manager")]
        ServiceDeskManager,

        /// <summary>
        /// Service level manager.
        /// </summary>
        [XurrentEnum("service_level_manager")]
        ServiceLevelManager,

        /// <summary>
        /// Specialist.
        /// </summary>
        [XurrentEnum("specialist")]
        Specialist,

        /// <summary>
        /// Workflow automator auditor.
        /// </summary>
        [XurrentEnum("workflow_automator_auditor")]
        WorkflowAutomatorAuditor,

        /// <summary>
        /// Workflow automator specialist.
        /// </summary>
        [XurrentEnum("workflow_automator_specialist")]
        WorkflowAutomatorSpecialist,

        /// <summary>
        /// Workflow manager.
        /// </summary>
        [XurrentEnum("workflow_manager")]
        WorkflowManager
    }
}
