using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class RateLimitTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            RateLimit? rateLimits = await _client.GetAsync(new RateLimitQuery()
                .View(DefaultView.None)
                .SelectAll());

            Assert.NotNull(rateLimits);
            Assert.NotNull(rateLimits.Cost);
            Assert.Equal(1, rateLimits.Cost);
        }
    }
}
