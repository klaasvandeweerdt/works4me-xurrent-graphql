using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ShortUrlTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ShortUrl> shortUrls = await _client.GetAsync(new ShortUrlQuery()
                .View(ShortUrlView.All)
                .SelectAll());

            Assert.NotNull(shortUrls);

            if (shortUrls.Count > 0)
            {
                shortUrls = await _client.GetAsync(new ShortUrlQuery().WithId(shortUrls.GetRandomItem().Id));
                Assert.NotNull(shortUrls);
            }
        }
    }
}
