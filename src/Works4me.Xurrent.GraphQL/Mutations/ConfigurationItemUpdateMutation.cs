namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing configuration item.
    /// </summary>
    internal sealed class ConfigurationItemUpdateMutation : Mutation<ConfigurationItemUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationItemUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ConfigurationItemUpdateMutation(ConfigurationItemUpdateInput data, ConfigurationItemQuery query)
            : base("configurationItemUpdate", "ConfigurationItemUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "configurationItem")))
        {
        }
    }
}
