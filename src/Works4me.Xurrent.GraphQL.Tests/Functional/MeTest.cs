using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class MeTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            Person? me = await _client.GetAsync(new MeQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCart(new ShopOrderLineQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectContacts(new ContactQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectOutOfOfficePeriods(new OutOfOfficePeriodQuery()
                    .SelectAll())
                .SelectPermissions(new PermissionQuery()
                    .ItemsPerRequest(100)
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectTeams(new TeamQuery()
                    .SelectAll()));

            Assert.NotNull(me);
        }
    }
}
