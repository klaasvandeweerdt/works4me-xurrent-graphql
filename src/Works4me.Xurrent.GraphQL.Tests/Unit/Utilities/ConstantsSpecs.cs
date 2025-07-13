using Works4me.Xurrent.GraphQL.Utilities;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Utilities
{
    public class ConstantsSpecs
    {
        [Fact]
        public void AccountHeader_ShouldHaveExpectedValue()
        {
            Assert.Equal("x-xurrent-account", Constants.AccountHeader);
        }

        [Fact]
        public void ApplicationJsonMediaType_ShouldHaveExpectedValue()
        {
            Assert.Equal("application/json", Constants.ApplicationJsonMediaType);
        }

        [Fact]
        public void DateTimeFormat_ShouldHaveExpectedValue()
        {
            Assert.Equal("yyyy-MM-dd'T'HH:mm:sszzz", Constants.DateTimeFormat);
        }
    }
}
