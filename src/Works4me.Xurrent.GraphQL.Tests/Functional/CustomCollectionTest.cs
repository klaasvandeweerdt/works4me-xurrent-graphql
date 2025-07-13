using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class CustomCollectionTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<CustomCollection> customCollections = await _client.GetAsync(new CustomCollectionQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectCollectionElements(new CustomCollectionElementQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(customCollections);

            if (customCollections.Count > 0)
            {
                customCollections = await _client.GetAsync(new CustomCollectionQuery().WithId(customCollections.GetRandomItem().Id));
                Assert.NotNull(customCollections);
            }
        }
    }
}
