using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TaskTemplateApproval">TaskTemplateApproval</see> fields.
    /// </summary>
    public enum TaskTemplateApprovalField
    {
        /// <summary>
        /// The approver field.
        /// </summary>
        [XurrentEnum("approver")]
        Approver,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort
    }
}
