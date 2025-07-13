using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProviderShopOrderLine"/> query class.
    /// </summary>
    public class ProviderShopOrderLineQuery : Query<ProviderShopOrderLine, ProviderShopOrderLineQuery, DefaultView, ProviderShopOrderLineField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProviderShopOrderLineQuery"/> instance.
        /// </summary>
        public ProviderShopOrderLineQuery() : base(string.Empty, false)
        {
        }
    }
}
