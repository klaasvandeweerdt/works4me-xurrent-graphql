using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appinstancecreatepayload/">AppInstanceCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class AppInstanceCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("appInstance", IsDefaultQueryProperty = true)]
        public AppInstance? AppInstance { get; internal set; }
    }
}
