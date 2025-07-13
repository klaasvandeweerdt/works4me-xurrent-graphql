using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ServiceLevelAgreementTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ServiceLevelAgreement> serviceLevelAgreements = await _client.GetAsync(new ServiceLevelAgreementQuery()
                .View(ServiceLevelAgreementView.All)
                .SelectAll()
                .SelectCustomerRepresentatives(new PersonQuery()
                    .SelectAll())
                .SelectEffortClassRateIDs(new EffortClassRateIDQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectPeople(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ParentServiceInstanceQuery()
                    .SelectAll())
                .SelectSites(new SiteQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectCoverageGroups(new SlaCoverageGroupQuery()
                    .SelectAll())
                .SelectStandardServiceRequestActivityIDs(new StandardServiceRequestActivityIDQuery()
                    .SelectAll()));

            Assert.NotNull(serviceLevelAgreements);

            if (serviceLevelAgreements.Count > 0)
            {
                serviceLevelAgreements = await _client.GetAsync(new ServiceLevelAgreementQuery().WithId(serviceLevelAgreements.GetRandomItem().Id));
                Assert.NotNull(serviceLevelAgreements);
            }
        }
    }
}
