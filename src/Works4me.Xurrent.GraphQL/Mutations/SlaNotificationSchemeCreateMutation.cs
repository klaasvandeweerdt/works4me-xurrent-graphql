namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new SLA notification scheme.
    /// </summary>
    internal sealed class SlaNotificationSchemeCreateMutation : Mutation<SlaNotificationSchemeCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlaNotificationSchemeCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SlaNotificationSchemeCreateMutation(SlaNotificationSchemeCreateInput data, SlaNotificationSchemeQuery query)
            : base("slaNotificationSchemeCreate", "SlaNotificationSchemeCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "slaNotificationScheme")))
        {
        }
    }
}
