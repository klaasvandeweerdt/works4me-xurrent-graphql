using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SlaNotificationSchemeTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<SlaNotificationScheme> slaNotificationSchemes = await _client.GetAsync(new SlaNotificationSchemeQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectSlaNotificationRules(new SlaNotificationRuleQuery()
                    .SelectAll()));

            Assert.NotNull(slaNotificationSchemes);

            if (slaNotificationSchemes.Count > 0)
            {
                slaNotificationSchemes = await _client.GetAsync(new SlaNotificationSchemeQuery().WithId(slaNotificationSchemes.GetRandomItem().Id));
                Assert.NotNull(slaNotificationSchemes);
            }
        }
    }
}
