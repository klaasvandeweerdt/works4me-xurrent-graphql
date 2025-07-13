using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequestActivityID">StandardServiceRequestActivityID</see> fields.
    /// </summary>
    public enum StandardServiceRequestActivityIDField
    {
        /// <summary>
        /// The activity id field.
        /// </summary>
        [XurrentEnum("activityID")]
        ActivityID,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The standard service request field.
        /// </summary>
        [XurrentEnum("standardServiceRequest")]
        StandardServiceRequest
    }
}
