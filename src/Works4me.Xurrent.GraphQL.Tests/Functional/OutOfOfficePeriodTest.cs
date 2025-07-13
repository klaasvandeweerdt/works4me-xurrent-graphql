using System;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Mutations;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class OutOfOfficePeriodTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<OutOfOfficePeriod> outOfOfficePeriods = await _client.GetAsync(new OutOfOfficePeriodQuery()
                .View(OutOfOfficePeriodView.All)
                .SelectAll());

            Assert.NotNull(outOfOfficePeriods);

            if (outOfOfficePeriods.Count > 0)
            {
                outOfOfficePeriods = await _client.GetAsync(new OutOfOfficePeriodQuery().WithId(outOfOfficePeriods.GetRandomItem().Id));
                Assert.NotNull(outOfOfficePeriods);
            }
        }

        [Fact]
        public async Task CreateAndDelete()
        {
            Person? result = await _client.GetAsync(new MeQuery().Select(PersonField.Id));

            Assert.NotNull(result);
            Assert.NotNull(result.Id);

            DateTime now = DateTime.Now.Date;
            OutOfOfficePeriodCreatePayload createdOoO = await _client.MutationAsync(new OutOfOfficePeriodCreateInput()
            {
                PersonId = result.Id,
                StartAt = now.AddDays(10),
                EndAt = now.AddDays(11),
                Reason = "Works4me.Xurrent.GraphQL Test"
            }, new OutOfOfficePeriodQuery());

            Assert.NotNull(createdOoO);
            Assert.NotNull(createdOoO.OutOfOfficePeriod);
            Assert.NotNull(createdOoO.OutOfOfficePeriod.Id);

            OutOfOfficePeriodDeleteMutationPayload deletedOoO = await _client.MutationAsync(new OutOfOfficePeriodDeleteMutationInput(createdOoO.OutOfOfficePeriod.Id));

            Assert.NotNull(deletedOoO);
            Assert.True(deletedOoO.Success);
        }
    }
}
