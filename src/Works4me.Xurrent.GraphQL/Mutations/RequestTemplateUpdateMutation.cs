namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing request template.
    /// </summary>
    internal sealed class RequestTemplateUpdateMutation : Mutation<RequestTemplateUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTemplateUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RequestTemplateUpdateMutation(RequestTemplateUpdateInput data, RequestTemplateQuery query)
            : base("requestTemplateUpdate", "RequestTemplateUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "requestTemplate")))
        {
        }
    }
}
