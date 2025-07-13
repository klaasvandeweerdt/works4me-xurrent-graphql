using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AppOfferingScope"/> query class.
    /// </summary>
    public class AppOfferingScopeQuery : Query<AppOfferingScope, AppOfferingScopeQuery, DefaultView, AppOfferingScopeField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AppOfferingScopeQuery"/> instance.
        /// </summary>
        public AppOfferingScopeQuery() : base(string.Empty, false)
        {
        }
    }
}
