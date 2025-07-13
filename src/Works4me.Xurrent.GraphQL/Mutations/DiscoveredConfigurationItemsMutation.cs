namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// This mutation can be used to push at most 100 discovered configuration items to Xurrent at once.<br />
    /// A more extensive description of this functionality can be found on the.<br />
    /// <a href="https://developer.xurrent.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</a>.<br />
    /// The query will be executed in the background. Typically the following fields should be queried:<br />
    /// <code>
    ///   asyncQuery { resultUrl errorCount }
    ///   configurationItems { id sourceID }
    /// </code><br />
    /// On initial submission the <c>configurationItems</c> field will be <c>null</c>.<br />
    /// The <c>resultUrl</c> contains an expiring link to the location where the resulting JSON is available.<br />
    /// once the query has been executed.<br />
    /// It is possible to poll the link every couple of seconds to check whether the query is completed.<br />
    /// Initially the link will point to an empty JSON document (<c>{}</c>), once the query is completed it will contain.<br />
    /// the JSON result of this mutation.<br />
    /// In the result both the <c>asyncQuery</c> and <c>configurationItems</c> fields as requested on submission are present.<br />
    /// The <c>errorCount</c> can for example be used to see whether processing was successful (then it is <c>0</c>).<br />
    /// </summary>
    internal sealed class DiscoveredConfigurationItemsMutation : Mutation<DiscoveredConfigurationItemsInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredConfigurationItemsMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the async query mutation.</param>
        /// <param name="query1">The query specifying which fields to return in the response.</param>
        /// <param name="query2">The query specifying which fields to return in the response.</param>
        internal DiscoveredConfigurationItemsMutation(DiscoveredConfigurationItemsInput data, AsyncQueryQuery query1, ConfigurationItemQuery query2)
            : base("discoveredConfigurationItems", "DiscoveredConfigurationItemsInput!", data, new MutationResponseQuery().Select(UpdateQuery(query1, "asyncQuery")).Select(UpdateQuery(query2, "configurationItems")))
        {
        }
    }
}
