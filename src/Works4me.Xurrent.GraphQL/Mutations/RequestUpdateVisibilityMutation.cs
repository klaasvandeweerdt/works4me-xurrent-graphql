namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates the visibility of a request account. Only for account administrators.
    /// </summary>
    internal sealed class RequestUpdateVisibilityMutation : Mutation<RequestUpdateVisibilityInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateVisibilityMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the success mutation.</param>
        internal RequestUpdateVisibilityMutation(RequestUpdateVisibilityInput data)
            : base("requestUpdateVisibility", "RequestUpdateVisibilityInput!", data, new MutationResponseQuery().SelectAll())
        {
        }
    }
}
