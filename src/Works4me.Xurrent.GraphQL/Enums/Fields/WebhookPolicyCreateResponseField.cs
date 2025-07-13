using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WebhookPolicyCreateResponse">WebhookPolicyCreateResponse</see> fields.
    /// </summary>
    public enum WebhookPolicyCreateResponseField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The jwt alg field.
        /// </summary>
        [XurrentEnum("jwtAlg")]
        JwtAlg,

        /// <summary>
        /// The jwt audience field.
        /// </summary>
        [XurrentEnum("jwtAudience")]
        JwtAudience,

        /// <summary>
        /// The jwt claim expires in field.
        /// </summary>
        [XurrentEnum("jwtClaimExpiresIn")]
        JwtClaimExpiresIn,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The public key pem field.
        /// </summary>
        [XurrentEnum("publicKeyPem")]
        PublicKeyPem,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
