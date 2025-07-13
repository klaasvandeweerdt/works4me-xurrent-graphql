using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class TranslationTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Translation> translations = await _client.GetAsync(new TranslationQuery()
                .View(TranslationView.CurrentAccount)
                .SelectAll()
                .SelectOwner(new ServiceQuery()
                    .ItemsPerRequest(1)
                    .SelectAll()));

            Assert.NotNull(translations);

            if (translations.Count > 0)
            {
                translations = await _client.GetAsync(new TranslationQuery().WithId(translations.GetRandomItem().Id));
                Assert.NotNull(translations);
            }
        }
    }
}
