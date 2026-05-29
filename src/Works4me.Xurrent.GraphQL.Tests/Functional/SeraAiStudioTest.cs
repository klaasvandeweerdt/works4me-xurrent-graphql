using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SeraAiStudioTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            SeraAiStudio? seraAiStudio = await _client.GetAsync(new SeraAiStudioQuery()
                .View(DefaultView.None)
                .SelectGoldenSetItems(new GoldenSetItemQuery()
                    .SelectAll())
                .SelectAll(), TestContext.Current.CancellationToken);

            Assert.NotNull(seraAiStudio);
        }
    }
}
