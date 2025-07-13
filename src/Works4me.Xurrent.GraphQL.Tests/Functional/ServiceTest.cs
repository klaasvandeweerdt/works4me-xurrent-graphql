using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ServiceTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Service> services = await _client.GetAsync(new ServiceQuery()
                .View(ServiceView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectServiceOfferings(new ServiceOfferingQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()));

            Assert.NotNull(services);

            if (services.Count > 0)
            {
                services = await _client.GetAsync(new ServiceQuery().WithId(services.GetRandomItem().Id));
                Assert.NotNull(services);
            }
        }
    }
}
