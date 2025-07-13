using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ReservationOfferingTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ReservationOffering> reservationOfferings = await _client.GetAsync(new ReservationOfferingQuery()
                .View(ReservationOfferingView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectRequestTemplates(new RequestTemplateQuery()
                    .SelectAll()));

            Assert.NotNull(reservationOfferings);

            if (reservationOfferings.Count > 0)
            {
                reservationOfferings = await _client.GetAsync(new ReservationOfferingQuery().WithId(reservationOfferings.GetRandomItem().Id));
                Assert.NotNull(reservationOfferings);
            }
        }
    }
}
