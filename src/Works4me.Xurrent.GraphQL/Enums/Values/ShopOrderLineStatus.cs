using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The shop order line status values.
    /// </summary>
    public enum ShopOrderLineStatus
    {
        /// <summary>
        /// Canceled.
        /// </summary>
        [XurrentEnum("canceled")]
        Canceled,

        /// <summary>
        /// Completed.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

        /// <summary>
        /// Fulfillment pending.
        /// </summary>
        [XurrentEnum("fulfillment_pending")]
        FulfillmentPending,

        /// <summary>
        /// In cart.
        /// </summary>
        [XurrentEnum("in_cart")]
        InCart,

        /// <summary>
        /// Workflow pending.
        /// </summary>
        [XurrentEnum("workflow_pending")]
        WorkflowPending
    }
}
