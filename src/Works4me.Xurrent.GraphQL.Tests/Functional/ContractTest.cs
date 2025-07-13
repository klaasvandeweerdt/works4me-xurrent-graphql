using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ContractTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Contract> contracts = await _client.GetAsync(new ContractQuery()
                .View(ContractView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(contracts);

            if (contracts.Count > 0)
            {
                contracts = await _client.GetAsync(new ContractQuery().WithId(contracts.GetRandomItem().Id));
                Assert.NotNull(contracts);
            }
        }
    }
}
