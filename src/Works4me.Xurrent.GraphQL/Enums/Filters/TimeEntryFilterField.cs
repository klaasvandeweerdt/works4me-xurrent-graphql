using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which TimeEntry records are returned.
    /// </summary>
    public enum TimeEntryFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on Customer.
        /// </summary>
        [XurrentEnum("customer")]
        Customer,

        /// <summary>
        /// Date in supplied range.
        /// </summary>
        [XurrentEnum("date")]
        Date,

        /// <summary>
        /// Include only if Deleted matches supplied value.
        /// </summary>
        [XurrentEnum("deleted")]
        Deleted,

        /// <summary>
        /// Filter on Effort class.
        /// </summary>
        [XurrentEnum("effortClass")]
        EffortClass,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Organization.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// Filter on Person.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// Filter on Project.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// Filter on Project manager.
        /// </summary>
        [XurrentEnum("projectManager")]
        ProjectManager,

        /// <summary>
        /// Filter on Request category.
        /// </summary>
        [XurrentEnum("requestCategory")]
        RequestCategory,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service instance.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// Filter on Service level agreement.
        /// </summary>
        [XurrentEnum("sla")]
        Sla,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt,

        /// <summary>
        /// Filter on Team.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// Filter on Time allocation.
        /// </summary>
        [XurrentEnum("timeAllocation")]
        TimeAllocation,

        /// <summary>
        /// Filter on Time allocation group.
        /// </summary>
        [XurrentEnum("timeAllocationGroup")]
        TimeAllocationGroup,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Filter on Workflow.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow
    }
}
