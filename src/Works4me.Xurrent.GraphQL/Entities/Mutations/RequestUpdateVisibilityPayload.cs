using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requestupdatevisibilitypayload/">RequestUpdateVisibilityPayload</see> in Xurrent.
    /// </summary>
    public sealed class RequestUpdateVisibilityPayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("success", IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
