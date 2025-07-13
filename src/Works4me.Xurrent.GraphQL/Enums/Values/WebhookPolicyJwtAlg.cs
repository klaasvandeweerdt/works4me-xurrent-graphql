using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The webhook policy jwt alg values.
    /// </summary>
    public enum WebhookPolicyJwtAlg
    {
        /// <summary>
        /// Ecdsa using p 256 and sha 256.
        /// </summary>
        [XurrentEnum("es256")]
        Es256,

        /// <summary>
        /// Ecdsa using p 384 and sha 384.
        /// </summary>
        [XurrentEnum("es384")]
        Es384,

        /// <summary>
        /// Ecdsa using p 521 and sha 512.
        /// </summary>
        [XurrentEnum("es512")]
        Es512,

        /// <summary>
        /// Hmac using sha 256.
        /// </summary>
        [XurrentEnum("hs256")]
        Hs256,

        /// <summary>
        /// Hmac using sha 384.
        /// </summary>
        [XurrentEnum("hs384")]
        Hs384,

        /// <summary>
        /// Hmac using sha 512.
        /// </summary>
        [XurrentEnum("hs512")]
        Hs512,

        /// <summary>
        /// No digital signature or mac performed.
        /// </summary>
        [XurrentEnum("none")]
        None,

        /// <summary>
        /// Rsa using sha 256.
        /// </summary>
        [XurrentEnum("rs256")]
        Rs256,

        /// <summary>
        /// Rsa using sha 384.
        /// </summary>
        [XurrentEnum("rs384")]
        Rs384,

        /// <summary>
        /// Rsa using sha 512.
        /// </summary>
        [XurrentEnum("rs512")]
        Rs512
    }
}
