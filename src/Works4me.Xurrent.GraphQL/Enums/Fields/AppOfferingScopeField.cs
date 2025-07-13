using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AppOfferingScope">AppOfferingScope</see> fields.
    /// </summary>
    public enum AppOfferingScopeField
    {
        /// <summary>
        /// The actions field.
        /// </summary>
        [XurrentEnum("actions")]
        Actions,

        /// <summary>
        /// The conditions field.
        /// </summary>
        [XurrentEnum("conditions")]
        Conditions,

        /// <summary>
        /// The effect field.
        /// </summary>
        [XurrentEnum("effect")]
        Effect,

        /// <summary>
        /// The grant type field.
        /// </summary>
        [XurrentEnum("grantType")]
        GrantType,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id
    }
}
