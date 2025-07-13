namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new request.
    /// </summary>
    internal sealed class RequestCreateMutation : Mutation<RequestCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the request mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RequestCreateMutation(RequestCreateInput data, RequestQuery query)
            : base("requestCreate", "RequestCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "request")))
        {
        }
    }
}
