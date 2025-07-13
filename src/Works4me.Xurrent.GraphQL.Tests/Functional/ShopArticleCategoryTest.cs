using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ShopArticleCategoryTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ShopArticleCategory> shopArticleCategories = await _client.GetAsync(new ShopArticleCategoryQuery()
                .View(ShopArticleCategoryView.All)
                .SelectAll()
                .SelectFullDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new RiskSeverityQuery()
                        .SelectAll()
                        .ItemsPerRequest(1)))
                .SelectParent(new ShopArticleCategoryQuery().SelectAll()));

            Assert.NotNull(shopArticleCategories);

            if (shopArticleCategories.Count > 0)
            {
                shopArticleCategories = await _client.GetAsync(new ShopArticleCategoryQuery().WithId(shopArticleCategories.GetRandomItem().Id));
                Assert.NotNull(shopArticleCategories);
            }
        }
    }
}
