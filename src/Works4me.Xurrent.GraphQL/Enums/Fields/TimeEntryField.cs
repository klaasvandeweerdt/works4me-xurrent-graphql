using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TimeEntry">TimeEntry</see> fields.
    /// </summary>
    public enum TimeEntryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The activity id field.
        /// </summary>
        [XurrentEnum("activityID")]
        ActivityID,

        /// <summary>
        /// The agreement id field.
        /// </summary>
        [XurrentEnum("agreementID")]
        AgreementID,

        /// <summary>
        /// The assignment field.
        /// </summary>
        [XurrentEnum("assignment")]
        Assignment,

        /// <summary>
        /// The charge field.
        /// </summary>
        [XurrentEnum("charge")]
        Charge,

        /// <summary>
        /// The charge currency field.
        /// </summary>
        [XurrentEnum("chargeCurrency")]
        ChargeCurrency,

        /// <summary>
        /// The charge rate field.
        /// </summary>
        [XurrentEnum("chargeRate")]
        ChargeRate,

        /// <summary>
        /// The charge type field.
        /// </summary>
        [XurrentEnum("chargeType")]
        ChargeType,

        /// <summary>
        /// The correction field.
        /// </summary>
        [XurrentEnum("correction")]
        Correction,

        /// <summary>
        /// The cost field.
        /// </summary>
        [XurrentEnum("cost")]
        Cost,

        /// <summary>
        /// The cost currency field.
        /// </summary>
        [XurrentEnum("costCurrency")]
        CostCurrency,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The customer field.
        /// </summary>
        [XurrentEnum("customer")]
        Customer,

        /// <summary>
        /// The date field.
        /// </summary>
        [XurrentEnum("date")]
        Date,

        /// <summary>
        /// The deleted field.
        /// </summary>
        [XurrentEnum("deleted")]
        Deleted,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The effort class field.
        /// </summary>
        [XurrentEnum("effortClass")]
        EffortClass,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// The note field.
        /// </summary>
        [XurrentEnum("note")]
        Note,

        /// <summary>
        /// The organization field.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// The person field.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// The rate id field.
        /// </summary>
        [XurrentEnum("rateID")]
        RateID,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// The service instance field.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// The service level agreement field.
        /// </summary>
        [XurrentEnum("serviceLevelAgreement")]
        ServiceLevelAgreement,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The started at field.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt,

        /// <summary>
        /// The team field.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// The time allocation field.
        /// </summary>
        [XurrentEnum("timeAllocation")]
        TimeAllocation,

        /// <summary>
        /// The time spent field.
        /// </summary>
        [XurrentEnum("timeSpent")]
        TimeSpent,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
