using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class EffortClassTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<EffortClass> effortClasses = await _client.GetAsync(new EffortClassQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectServiceOfferings(new ServiceOfferingQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectTimesheetSettings(new TimesheetSettingQuery()
                    .SelectAll()));

            Assert.NotNull(effortClasses);

            if (effortClasses.Count > 0)
            {
                effortClasses = await _client.GetAsync(new EffortClassQuery().WithId(effortClasses.GetRandomItem().Id));
                Assert.NotNull(effortClasses);
            }
        }
    }
}
