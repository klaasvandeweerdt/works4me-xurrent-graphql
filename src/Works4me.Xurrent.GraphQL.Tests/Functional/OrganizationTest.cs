using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class OrganizationTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Organization> organizations = await _client.GetAsync(new OrganizationQuery()
                .View(OrganizationView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectChildOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectContacts(new ContactQuery()
                    .SelectAll())
                .SelectContracts(new ContractQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPeople(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRisks(new RiskQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectTimeAllocations(new TimeAllocationQuery()
                    .SelectAll()));

            Assert.NotNull(organizations);

            if (organizations.Count > 0)
            {
                organizations = await _client.GetAsync(new OrganizationQuery().WithId(organizations.GetRandomItem().Id));
                Assert.NotNull(organizations);
            }
        }
    }
}
