using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The task category values.
    /// </summary>
    public enum TaskCategory
    {
        /// <summary>
        /// Approval.
        /// </summary>
        [XurrentEnum("approval")]
        Approval,

        /// <summary>
        /// Automation.
        /// </summary>
        [XurrentEnum("automation")]
        Automation,

        /// <summary>
        /// Fulfillment placeholder.
        /// </summary>
        [XurrentEnum("fulfillment_placeholder")]
        FulfillmentPlaceholder,

        /// <summary>
        /// Implementation.
        /// </summary>
        [XurrentEnum("implementation")]
        Implementation,

        /// <summary>
        /// Risk impact.
        /// </summary>
        [XurrentEnum("risk_and_impact")]
        RiskAndImpact
    }
}
