using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class TimesheetSettingTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<TimesheetSetting> timesheetSettings = await _client.GetAsync(new TimesheetSettingQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectEffortClasses(new EffortClassQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll()));

            Assert.NotNull(timesheetSettings);

            if (timesheetSettings.Count > 0)
            {
                timesheetSettings = await _client.GetAsync(new TimesheetSettingQuery().WithId(timesheetSettings.GetRandomItem().Id));
                Assert.NotNull(timesheetSettings);
            }
        }
    }
}
