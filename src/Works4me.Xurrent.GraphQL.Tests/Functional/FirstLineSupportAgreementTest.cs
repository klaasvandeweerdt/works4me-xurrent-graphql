using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class FirstLineSupportAgreementTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<FirstLineSupportAgreement> firstLineSupportAgreements = await _client.GetAsync(new FirstLineSupportAgreementQuery()
                .View(FirstLineSupportAgreementView.All)
                .SelectAll()
                .SelectChargesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectTargetDetailsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCustomerRepresentative(new PersonQuery()
                    .SelectAll())
                .SelectMajorIncidentManagers(new PersonQuery()
                    .SelectAll()));

            Assert.NotNull(firstLineSupportAgreements);

            if (firstLineSupportAgreements.Count > 0)
            {
                firstLineSupportAgreements = await _client.GetAsync(new FirstLineSupportAgreementQuery().WithId(firstLineSupportAgreements.GetRandomItem().Id));
                Assert.NotNull(firstLineSupportAgreements);
            }
        }
    }
}
