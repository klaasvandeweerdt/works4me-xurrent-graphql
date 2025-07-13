using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The oauth application grant type values.
    /// </summary>
    public enum OauthApplicationGrantType
    {
        /// <summary>
        /// Authorization code grant.
        /// </summary>
        [XurrentEnum("authorization_code")]
        AuthorizationCode,

        /// <summary>
        /// Client credentials grant.
        /// </summary>
        [XurrentEnum("client_credentials")]
        ClientCredentials
    }
}
