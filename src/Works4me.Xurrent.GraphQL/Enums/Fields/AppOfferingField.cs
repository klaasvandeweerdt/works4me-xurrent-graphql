using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AppOffering">AppOffering</see> fields.
    /// </summary>
    public enum AppOfferingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The card description field.
        /// </summary>
        [XurrentEnum("cardDescription")]
        CardDescription,

        /// <summary>
        /// The compliance field.
        /// </summary>
        [XurrentEnum("compliance")]
        Compliance,

        /// <summary>
        /// The configuration uri template field.
        /// </summary>
        [XurrentEnum("configurationUriTemplate")]
        ConfigurationUriTemplate,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The features field.
        /// </summary>
        [XurrentEnum("features")]
        Features,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The latest field.
        /// </summary>
        [XurrentEnum("latest")]
        Latest,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The oauth authorization endpoints field.
        /// </summary>
        [XurrentEnum("oauthAuthorizationEndpoints")]
        OauthAuthorizationEndpoints,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

        /// <summary>
        /// The policy jwt alg field.
        /// </summary>
        [XurrentEnum("policyJwtAlg")]
        PolicyJwtAlg,

        /// <summary>
        /// The policy jwt audience field.
        /// </summary>
        [XurrentEnum("policyJwtAudience")]
        PolicyJwtAudience,

        /// <summary>
        /// The policy jwt claim expires in field.
        /// </summary>
        [XurrentEnum("policyJwtClaimExpiresIn")]
        PolicyJwtClaimExpiresIn,

        /// <summary>
        /// The published field.
        /// </summary>
        [XurrentEnum("published")]
        Published,

        /// <summary>
        /// The reference field.
        /// </summary>
        [XurrentEnum("reference")]
        Reference,

        /// <summary>
        /// The requires enabled oauth person field.
        /// </summary>
        [XurrentEnum("requiresEnabledOauthPerson")]
        RequiresEnabledOauthPerson,

        /// <summary>
        /// The scopes field.
        /// </summary>
        [XurrentEnum("scopes")]
        Scopes,

        /// <summary>
        /// The service instance field.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The ui extension version field.
        /// </summary>
        [XurrentEnum("uiExtensionVersion")]
        UiExtensionVersion,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The webhook uri template field.
        /// </summary>
        [XurrentEnum("webhookUriTemplate")]
        WebhookUriTemplate
    }
}
