using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AgileBoardTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<AgileBoard> agileBoards = await _client.GetAsync(new AgileBoardQuery()
                .View(AgileBoardView.All)
                .OrderBy(AgileBoardOrderField.CreatedAt, SortOrder.Ascending)
                .SelectAll()
                .SelectColumns(new AgileBoardColumnQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCustomerRepresentativeSlas(new ServiceLevelAgreementQuery()
                    .SelectAll()));

            Assert.NotNull(agileBoards);

            if (agileBoards.Count > 0)
            {
                agileBoards = await _client.GetAsync(new AgileBoardQuery().WithId(agileBoards.GetRandomItem().Id));
                Assert.NotNull(agileBoards);
            }
        }
    }
}
