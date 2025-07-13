using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WaitingForCustomerFollowUpTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<WaitingForCustomerFollowUp> customCollections = await _client.GetAsync(new WaitingForCustomerFollowUpQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectWaitingForCustomerRules(new WaitingForCustomerRuleQuery()
                    .SelectAll()));

            Assert.NotNull(customCollections);

            if (customCollections.Count > 0)
            {
                customCollections = await _client.GetAsync(new WaitingForCustomerFollowUpQuery().WithId(customCollections.GetRandomItem().Id));
                Assert.NotNull(customCollections);
            }
        }
    }
}
