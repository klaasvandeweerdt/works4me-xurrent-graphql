namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new configuration item. <b>Important</b>: To facilitate integrations with discovery tools, the create is treated as an update in case the provided <c>name</c> or <c>label</c> is already used by an inactive CI in the same account.
    /// </summary>
    internal sealed class ConfigurationItemCreateMutation : Mutation<ConfigurationItemCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationItemCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the configuration item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ConfigurationItemCreateMutation(ConfigurationItemCreateInput data, ConfigurationItemQuery query)
            : base("configurationItemCreate", "ConfigurationItemCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "configurationItem")))
        {
        }
    }
}
