namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing SLA notification scheme.
    /// </summary>
    internal sealed class SlaNotificationSchemeUpdateMutation : Mutation<SlaNotificationSchemeUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlaNotificationSchemeUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sla notification scheme mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SlaNotificationSchemeUpdateMutation(SlaNotificationSchemeUpdateInput data, SlaNotificationSchemeQuery query)
            : base("slaNotificationSchemeUpdate", "SlaNotificationSchemeUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "slaNotificationScheme")))
        {
        }
    }
}
