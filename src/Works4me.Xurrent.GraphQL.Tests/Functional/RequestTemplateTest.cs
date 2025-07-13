using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class RequestTemplateTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<RequestTemplate> requestTemplates = await _client.GetAsync(new RequestTemplateQuery()
                .View(RequestTemplateView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectRegistrationHintsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectReservationOfferings(new ReservationOfferingQuery()
                    .SelectAll())
                .SelectStandardServiceRequests(new StandardServiceRequestQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()));

            Assert.NotNull(requestTemplates);

            if (requestTemplates.Count > 0)
            {
                requestTemplates = await _client.GetAsync(new RequestTemplateQuery().WithId(requestTemplates.GetRandomItem().Id));
                Assert.NotNull(requestTemplates);
            }
        }
    }
}
