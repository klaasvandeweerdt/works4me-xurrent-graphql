using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/translationcreatepayload/">TranslationCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class TranslationCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("translation", IsDefaultQueryProperty = true)]
        public Translation? Translation { get; internal set; }
    }
}
