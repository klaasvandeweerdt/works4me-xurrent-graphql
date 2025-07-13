using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/personcreatepayload/">PersonCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class PersonCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("person", IsDefaultQueryProperty = true)]
        public Person? Person { get; internal set; }
    }
}
