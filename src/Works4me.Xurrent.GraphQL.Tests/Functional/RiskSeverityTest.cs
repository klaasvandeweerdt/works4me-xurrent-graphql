using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class RiskSeverityTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<RiskSeverity> riskSeverities = await _client.GetAsync(new RiskSeverityQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new RiskSeverityQuery()
                        .SelectAll()
                        .ItemsPerRequest(1))));

            Assert.NotNull(riskSeverities);

            if (riskSeverities.Count > 0)
            {
                riskSeverities = await _client.GetAsync(new RiskSeverityQuery().WithId(riskSeverities.GetRandomItem().Id));
                Assert.NotNull(riskSeverities);
            }
        }
    }
}
