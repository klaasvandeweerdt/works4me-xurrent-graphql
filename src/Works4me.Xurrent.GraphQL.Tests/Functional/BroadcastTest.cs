using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class BroadcastTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Broadcast> broadcasts = await _client.GetAsync(new BroadcastQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectCustomers(new OrganizationQuery()
                    .ItemsPerRequest(10)
                    .SelectAll()
                    .SelectAddresses(new AddressQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectChildOrganizations(new OrganizationQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectContacts(new ContactQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectCustomFieldsAttachments(new AttachmentQuery()
                        .ItemsPerRequest(10)
                        .SelectAll()))
                .SelectRemarksAttachments(new AttachmentQuery()
                    .ItemsPerRequest(10)
                    .SelectAll())
                .SelectTranslations(new BroadcastTranslationQuery()
                    .ItemsPerRequest(1)));

            Assert.NotNull(broadcasts);

            if (broadcasts.Count > 0)
            {
                broadcasts = await _client.GetAsync(new BroadcastQuery().WithId(broadcasts.GetRandomItem().Id));
                Assert.NotNull(broadcasts);
            }
        }
    }
}
