using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProductCategoryTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProductCategory> productCategories = await _client.GetAsync(new ProductCategoryQuery()
                .View(ProductCategoryView.CurrentAccount)
                .SelectAll()
                .SelectProducts(new ProductQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new ProductCategoryQuery()
                        .SelectAll()
                        .ItemsPerRequest(1))));

            Assert.NotNull(productCategories);

            if (productCategories.Count > 0)
            {
                productCategories = await _client.GetAsync(new ProductCategoryQuery().WithId(productCategories.GetRandomItem().Id));
                Assert.NotNull(productCategories);
            }
        }
    }
}
