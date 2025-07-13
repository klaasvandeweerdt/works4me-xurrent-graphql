using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class HolidayTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Holiday> holidays = await _client.GetAsync(new HolidayQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectCalendars(new CalendarQuery()
                    .SelectAll()));

            Assert.NotNull(holidays);

            if (holidays.Count > 0)
            {
                holidays = await _client.GetAsync(new HolidayQuery().WithId(holidays.GetRandomItem().Id));
                Assert.NotNull(holidays);
            }
        }
    }
}
