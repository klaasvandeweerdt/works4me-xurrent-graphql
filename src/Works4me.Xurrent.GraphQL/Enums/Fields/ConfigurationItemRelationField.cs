using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ConfigurationItemRelation">ConfigurationItemRelation</see> fields.
    /// </summary>
    public enum ConfigurationItemRelationField
    {
        /// <summary>
        /// The configuration item field.
        /// </summary>
        [XurrentEnum("configurationItem")]
        ConfigurationItem,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The relation type field.
        /// </summary>
        [XurrentEnum("relationType")]
        RelationType,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source
    }
}
