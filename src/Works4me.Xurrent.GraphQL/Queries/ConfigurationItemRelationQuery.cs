using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ConfigurationItemRelation"/> query class.
    /// </summary>
    public class ConfigurationItemRelationQuery : Query<ConfigurationItemRelation, ConfigurationItemRelationQuery, DefaultView, ConfigurationItemRelationField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ConfigurationItemRelationQuery"/> instance.
        /// </summary>
        public ConfigurationItemRelationQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Related configuration item.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>The same <see cref="ConfigurationItemRelationQuery"/>, updated to include the "ConfigurationItem" sub-query.</returns>
        public ConfigurationItemRelationQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItem", query, false);
        }
    }
}
