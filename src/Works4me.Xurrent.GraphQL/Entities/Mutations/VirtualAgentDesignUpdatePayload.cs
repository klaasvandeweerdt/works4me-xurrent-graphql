using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/virtualagentdesignupdatepayload/">VirtualAgentDesignUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class VirtualAgentDesignUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("virtualAgentDesign", IsDefaultQueryProperty = true)]
        public VirtualAgentDesign? VirtualAgentDesign { get; internal set; }
    }
}
