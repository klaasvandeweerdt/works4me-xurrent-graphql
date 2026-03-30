using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class CiStagedChangeTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<CiStagedChange> ciStagedChanges = await _client.GetAsync(new CiStagedChangeQuery()
                .View(CiStagedChangeView.All)
                .SelectAccount(new AccountQuery().SelectAll())
                .SelectAutomationRule(new AutomationRuleQuery().SelectAll())
                .SelectCreatedBy(new PersonQuery().SelectAll())
                .SelectReviewedBy(new PersonQuery().SelectAll())
                .SelectAll(), TestContext.Current.CancellationToken);

            Assert.NotNull(ciStagedChanges);

            if (ciStagedChanges.Count > 0)
            {
                ciStagedChanges = await _client.GetAsync(new CiStagedChangeQuery().WithId(ciStagedChanges.GetRandomItem().Id), TestContext.Current.CancellationToken);
                Assert.NotNull(ciStagedChanges);
            }
        }
    }
}
