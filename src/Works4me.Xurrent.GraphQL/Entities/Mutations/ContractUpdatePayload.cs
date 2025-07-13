using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/contractupdatepayload/">ContractUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ContractUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("contract", IsDefaultQueryProperty = true)]
        public Contract? Contract { get; internal set; }
    }
}
