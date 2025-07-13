using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/organizationcreatepayload/">OrganizationCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class OrganizationCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("organization", IsDefaultQueryProperty = true)]
        public Organization? Organization { get; internal set; }
    }
}
