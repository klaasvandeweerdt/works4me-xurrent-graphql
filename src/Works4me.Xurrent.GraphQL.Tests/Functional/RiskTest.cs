using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class RiskTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Risk> risks = await _client.GetAsync(new RiskQuery()
                .View(RiskView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectProjects(new ProjectQuery()
                    .SelectAll())
                .SelectServices(new ServiceQuery()
                    .SelectAll()));

            Assert.NotNull(risks);

            if (risks.Count > 0)
            {
                risks = await _client.GetAsync(new RiskQuery().WithId(risks.GetRandomItem().Id));
                Assert.NotNull(risks);
            }
        }
    }
}
