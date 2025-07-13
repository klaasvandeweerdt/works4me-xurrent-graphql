namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new request template.
    /// </summary>
    internal sealed class RequestTemplateCreateMutation : Mutation<RequestTemplateCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTemplateCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the request template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RequestTemplateCreateMutation(RequestTemplateCreateInput data, RequestTemplateQuery query)
            : base("requestTemplateCreate", "RequestTemplateCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "requestTemplate")))
        {
        }
    }
}
