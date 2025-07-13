using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ServiceOfferingTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ServiceOffering> serviceOfferings = await _client.GetAsync(new ServiceOfferingQuery()
                .View(ServiceOfferingView.All)
                .SelectAll()
                .SelectChargesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectContinuityAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectEffortClasses(new EffortClassQuery()
                    .SelectAll())
                .SelectEffortClassRates(new EffortClassRateQuery()
                    .SelectAll())
                .SelectLimitationsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPenaltiesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPerformanceAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPrerequisitesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectShopArticles(new ShopArticleQuery()
                    .SelectAll())
                .SelectStandardServiceRequests(new StandardServiceRequestQuery()
                    .SelectAll())
                .SelectSummaryAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTerminationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSupportHoursCase(new CalendarQuery()
                    .SelectAll()));

            Assert.NotNull(serviceOfferings);

            if (serviceOfferings.Count > 0)
            {
                serviceOfferings = await _client.GetAsync(new ServiceOfferingQuery().WithId(serviceOfferings.GetRandomItem().Id));
                Assert.NotNull(serviceOfferings);
            }
        }
    }
}
