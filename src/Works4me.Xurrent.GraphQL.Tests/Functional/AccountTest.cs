using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AccountTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            Account? account = await _client.GetAsync(new AccountQuery()
                .SelectAll()
                .SelectDesign(new AccountDesignQuery()
                    .SelectAll())
                .View(DefaultView.None));

            Assert.NotNull(account);
            Assert.NotNull(account.Id);
        }
    }
}
