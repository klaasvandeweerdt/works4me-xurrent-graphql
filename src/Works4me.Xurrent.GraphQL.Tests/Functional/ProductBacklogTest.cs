using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProductBacklogTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProductBacklog> productBacklogs = await _client.GetAsync(new ProductBacklogQuery()
                .View(ProductBacklogView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectItems(new ProblemQuery()
                    .Select(ProblemField.Id))
                .SelectItemsAll(
                    problemQuery: new ProblemQuery()
                        .Select(ProblemField.Id),
                    requestQuery: new RequestQuery()
                        .Select(RequestField.Id))
                .SelectScrumWorkspaces(new ScrumWorkspaceQuery()
                    .Select(ScrumWorkspaceField.Id)));

            Assert.NotNull(productBacklogs);

            if (productBacklogs.Count > 0)
            {
                productBacklogs = await _client.GetAsync(new ProductBacklogQuery().WithId(productBacklogs.GetRandomItem().Id));
                Assert.NotNull(productBacklogs);
            }
        }
    }
}
