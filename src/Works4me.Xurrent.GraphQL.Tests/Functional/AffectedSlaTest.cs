using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AffectedSlaTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<AffectedSla> affectedSlas = await _client.GetAsync(new AffectedSlaQuery()
                .View(AffectedSlaView.All)
                .ItemsPerRequest(2)
                .SelectAll());

            Assert.NotNull(affectedSlas);

            if (affectedSlas.Count > 0)
            {
                AffectedSla affectedSla = affectedSlas.GetRandomItem();
                Assert.NotNull(affectedSla.Id);

                ReadOnlyDataCollection<AffectedSla> selectedAffectedSlas = await _client.GetAsync(new AffectedSlaQuery().WithId(affectedSla.Id));
                Assert.NotNull(selectedAffectedSlas.First()?.Id);

                IEnumerable<AffectedSla> noTargets = affectedSlas.Where(x => x.NextTargetAt is not null && x.NextTargetAt.Value.IsNoTarget());
                Assert.NotNull(noTargets);

                IEnumerable<AffectedSla> clocksStopped = affectedSlas.Where(x => x.NextTargetAt is not null && x.NextTargetAt.Value.IsClockStopped());
                Assert.NotNull(clocksStopped);

                IEnumerable<AffectedSla> bestEfforts = affectedSlas.Where(x => x.NextTargetAt is not null && x.NextTargetAt.Value.IsBestEffort());
                Assert.NotNull(bestEfforts);
            }
        }
    }
}
