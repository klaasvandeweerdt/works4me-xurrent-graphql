using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/uiextensionupdatepayload/">UiExtensionUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class UiExtensionUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("uiExtension", IsDefaultQueryProperty = true)]
        public UiExtension? UiExtension { get; internal set; }
    }
}
