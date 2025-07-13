using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/uiextensioncreatepayload/">UiExtensionCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class UiExtensionCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("uiExtension", IsDefaultQueryProperty = true)]
        public UiExtension? UiExtension { get; internal set; }
    }
}
