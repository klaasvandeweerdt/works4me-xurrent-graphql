using Works4me.Xurrent.GraphQL.Utilities;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Utilities
{
    public class EndpointUrlBuilderSpecs
    {
        [Theory]
        [InlineData(EnvironmentRegion.AU, EnvironmentType.Quality, "au.xurrent.qa")]
        [InlineData(EnvironmentRegion.AU, EnvironmentType.Demo, "xurrent-demo.com")]
        [InlineData(EnvironmentRegion.AU, EnvironmentType.Production, "au.xurrent.com")]
        [InlineData(EnvironmentRegion.UK, EnvironmentType.Quality, "uk.xurrent.qa")]
        [InlineData(EnvironmentRegion.US, EnvironmentType.Production, "us.xurrent.com")]
        [InlineData(EnvironmentRegion.CH, EnvironmentType.Demo, "xurrent-demo.com")]
        [InlineData((EnvironmentRegion)(-1), EnvironmentType.Quality, "xurrent.qa")]
        [InlineData((EnvironmentRegion)(-1), EnvironmentType.Production, "xurrent.com")]
        public void GetBaseUrl_ReturnsExpectedUrl(EnvironmentRegion region, EnvironmentType environment, string expected)
        {
            string result = EndpointUrlBuilder.GetBaseUrl(region, environment);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Get_ReturnsExpectedGraphQLUrl()
        {
            string result = EndpointUrlBuilder.Get("my.custom.domain");

            Assert.Equal("https://graphql.my.custom.domain", result);
        }

        [Fact]
        public void GetRest_ReturnsExpectedApiUrl()
        {
            string result = EndpointUrlBuilder.GetRest("my.custom.domain");

            Assert.Equal("https://api.my.custom.domain/v1", result);
        }

        [Fact]
        public void GetOAuth2_ReturnsExpectedOAuthUrl()
        {
            string result = EndpointUrlBuilder.GetOAuth2("my.custom.domain");

            Assert.Equal("https://oauth.my.custom.domain/token", result);
        }

        [Theory]
        [InlineData("", "https://graphql.")]
        public void Get_ReturnsExpectedResultForEmptyDomain(string domainName, string expected)
        {
            string result = EndpointUrlBuilder.Get(domainName);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("", "https://api./v1")]
        public void GetRest_ReturnsExpectedResultForEmptyDomain(string domainName, string expected)
        {
            string result = EndpointUrlBuilder.GetRest(domainName);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("", "https://oauth./token")]
        public void GetOAuth2_ReturnsExpectedResultForEmptyDomain(string domainName, string expected)
        {
            string result = EndpointUrlBuilder.GetOAuth2(domainName);

            Assert.Equal(expected, result);
        }
    }
}
