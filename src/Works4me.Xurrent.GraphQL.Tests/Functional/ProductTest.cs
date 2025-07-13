using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProductTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Product> products = await _client.GetAsync(new ProductQuery()
                .View(ProductView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(products);

            if (products.Count > 0)
            {
                products = await _client.GetAsync(new ProductQuery().WithId(products.GetRandomItem().Id));
                Assert.NotNull(products);
            }
        }
    }
}
