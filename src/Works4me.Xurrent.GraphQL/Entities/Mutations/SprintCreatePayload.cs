using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/sprintcreatepayload/">SprintCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SprintCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("sprint", IsDefaultQueryProperty = true)]
        public Sprint? Sprint { get; internal set; }
    }
}
