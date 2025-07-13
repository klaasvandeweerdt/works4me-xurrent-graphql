using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ShopOrderLineTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ShopOrderLine> shopOrderLines = await _client.GetAsync(new ShopOrderLineQuery()
                .View(ShopOrderLineView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCustomFields(new CustomFieldQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(shopOrderLines);

            if (shopOrderLines.Count > 0)
            {
                shopOrderLines = await _client.GetAsync(new ShopOrderLineQuery().WithId(shopOrderLines.GetRandomItem().Id));
                Assert.NotNull(shopOrderLines);
            }
        }
    }
}
