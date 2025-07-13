using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ReservationTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Reservation> reservations = await _client.GetAsync(new ReservationQuery()
                .View(ReservationView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(reservations);

            if (reservations.Count > 0)
            {
                reservations = await _client.GetAsync(new ReservationQuery().WithId(reservations.GetRandomItem().Id));
                Assert.NotNull(reservations);
            }
        }
    }
}
