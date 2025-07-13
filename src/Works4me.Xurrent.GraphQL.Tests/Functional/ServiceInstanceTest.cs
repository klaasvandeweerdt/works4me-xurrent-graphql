using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ServiceInstanceTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ServiceInstance> serviceInstances = await _client.GetAsync(new ServiceInstanceQuery()
                .View(ServiceInstanceView.All)
                .ItemsPerRequest(10)
                .SelectAll()
                .SelectChildServiceInstances(new ServiceInstanceQuery())
                .SelectConfigurationItems(new ConfigurationItemQuery())
                .SelectCustomFieldsAttachments(new AttachmentQuery())
                .SelectParentServiceInstances(new ServiceInstanceQuery())
                .SelectRemarksAttachments(new AttachmentQuery())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery())
                .SelectTranslations(new TranslationQuery()
                    .SelectOwnerAll(
                        serviceQuery: new ServiceQuery()
                            .Select(ServiceField.Id),
                        serviceInstanceQuery: new ServiceInstanceQuery()
                            .Select(ServiceInstanceField.Id))));

            Assert.NotNull(serviceInstances);

            if (serviceInstances.Count > 0)
            {
                serviceInstances = await _client.GetAsync(new ServiceInstanceQuery().WithId(serviceInstances.GetRandomItem().Id));
                Assert.NotNull(serviceInstances);
            }
        }
    }
}
