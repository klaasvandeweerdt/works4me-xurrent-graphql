using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/configurationitemupdatepayload/">ConfigurationItemUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ConfigurationItemUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("configurationItem", IsDefaultQueryProperty = true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }
    }
}
