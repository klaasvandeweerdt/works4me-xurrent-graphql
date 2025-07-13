namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing request.
    /// </summary>
    internal sealed class RequestUpdateMutation : Mutation<RequestUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RequestUpdateMutation(RequestUpdateInput data, RequestQuery query)
            : base("requestUpdate", "RequestUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "request")))
        {
        }
    }
}
