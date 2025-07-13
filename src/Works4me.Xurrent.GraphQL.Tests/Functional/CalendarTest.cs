using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class CalendarTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Calendar> calendars = await _client.GetAsync(new CalendarQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectCalendarHours(new CalendarHourQuery()
                    .SelectAll()));

            Assert.NotNull(calendars);

            if (calendars.Count > 0)
            {
                calendars = await _client.GetAsync(new CalendarQuery().WithId(calendars.GetRandomItem().Id));
                Assert.NotNull(calendars);
            }
        }
    }
}
