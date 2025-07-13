using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class TimeAllocationTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<TimeAllocation> timeAllocations = await _client.GetAsync(new TimeAllocationQuery()
                .View(TimeAllocationView.All)
                .SelectAll()
                .SelectCustomers(new OrganizationQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectServices(new ServiceQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()));

            Assert.NotNull(timeAllocations);

            if (timeAllocations.Count > 0)
            {
                timeAllocations = await _client.GetAsync(new TimeAllocationQuery().WithId(timeAllocations.GetRandomItem().Id));
                Assert.NotNull(timeAllocations);
            }
        }
    }
}
