using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AppInstanceTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<AppInstance> appInstances = await _client.GetAsync(new AppInstanceQuery()
                .View(AppInstanceView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(appInstances);

            if (appInstances.Count > 0)
            {
                appInstances = await _client.GetAsync(new AppInstanceQuery().WithId(appInstances.GetRandomItem().Id));
                Assert.NotNull(appInstances);
            }
        }
    }
}
