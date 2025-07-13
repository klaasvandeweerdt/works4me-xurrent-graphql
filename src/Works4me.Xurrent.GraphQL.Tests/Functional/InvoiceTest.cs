using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class InvoiceTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Invoice> invoices = await _client.GetAsync(new InvoiceQuery()
                .View(InvoiceView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(invoices);

            if (invoices.Count > 0)
            {
                invoices = await _client.GetAsync(new InvoiceQuery().WithId(invoices.GetRandomItem().Id));
                Assert.NotNull(invoices);
            }
        }
    }
}
