using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AppOfferingTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<AppOffering> appOfferings = await _client.GetAsync(new AppOfferingQuery()
                .View(AppOfferingView.All)
                .SelectAll()
                .SelectAppInstances(new AppInstanceQuery()
                    .SelectAll())
                .SelectAutomationRules(new AppOfferingAutomationRuleQuery()
                    .SelectAll())
                .SelectComplianceAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(appOfferings);

            if (appOfferings.Count > 0)
            {
                appOfferings = await _client.GetAsync(new AppOfferingQuery().WithId(appOfferings.GetRandomItem().Id));
                Assert.NotNull(appOfferings);
            }
        }
    }
}
