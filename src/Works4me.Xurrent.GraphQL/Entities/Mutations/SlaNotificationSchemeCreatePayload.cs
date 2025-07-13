using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slanotificationschemecreatepayload/">SlaNotificationSchemeCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SlaNotificationSchemeCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("slaNotificationScheme", IsDefaultQueryProperty = true)]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }
    }
}
