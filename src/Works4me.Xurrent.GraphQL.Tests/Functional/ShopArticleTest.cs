using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ShopArticleTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ShopArticle> shopArticles = await _client.GetAsync(new ShopArticleQuery()
                .View(ShopArticleView.All)
                .SelectAll()
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new ShopArticleCategoryQuery()
                        .SelectAll()
                        .ItemsPerRequest(1))));

            Assert.NotNull(shopArticles);

            if (shopArticles.Count > 0)
            {
                shopArticles = await _client.GetAsync(new ShopArticleQuery().WithId(shopArticles.GetRandomItem().Id));
                Assert.NotNull(shopArticles);
            }
        }
    }
}
