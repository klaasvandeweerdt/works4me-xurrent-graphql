using System.Linq;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Mutations;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ConfigurationItemTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ConfigurationItem> cis = await _client.GetAsync(new ConfigurationItemQuery()
                .View(ConfigurationItemView.All)
                .SelectAll()
                .SelectCiRelations(new ConfigurationItemRelationQuery()
                    .SelectAll())
                .SelectContracts(new ContractQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectLicensedSites(new SiteQuery()
                    .SelectAll())
                .SelectProblems(new ProblemQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectUsers(new PersonQuery()
                    .SelectAll()));

            Assert.NotNull(cis);

            if (cis.Count > 0)
            {
                cis = await _client.GetAsync(new ConfigurationItemQuery().WithId(cis.GetRandomItem().Id));
                Assert.NotNull(cis);
            }
        }


        [Fact]
        public async Task UpdateStatus()
        {
            ConfigurationItemQuery ciQuery = new ConfigurationItemQuery()
                .WithId(Client.GetConfigValue("CiTest.Id"))
                .Select(ConfigurationItemField.Id, ConfigurationItemField.Status);

            ReadOnlyDataCollection<ConfigurationItem> cis = await _client.GetAsync(ciQuery);

            Assert.Single(cis);

            ConfigurationItem ci = cis.First();

            CiStatus newStatus = ci.Status switch
            {
                CiStatus.Installed => CiStatus.InStock,
                _ => CiStatus.Installed,
            };

            ConfigurationItemUpdatePayload result = await _client.MutationAsync(new ConfigurationItemUpdateInput() 
            {
                Id = ci.Id,
                Status = newStatus,
            }, new ConfigurationItemQuery().Select(ConfigurationItemField.Status));
            
            Assert.NotNull(result);
            Assert.NotNull(result.ConfigurationItem);
            Assert.Equal(newStatus, result.ConfigurationItem.Status);

        }
    }
}
