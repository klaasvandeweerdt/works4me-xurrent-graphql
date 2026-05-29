using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/seraaistudioupdatepayload/">SeraAiStudioUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SeraAiStudioUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("seraAiStudio", IsDefaultQueryProperty = true)]
        public SeraAiStudio? SeraAiStudio { get; internal set; }
    }
}
