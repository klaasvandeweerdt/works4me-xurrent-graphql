using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class TeamTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Team> teams = await _client.GetAsync(new TeamQuery()
                .View(TeamView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectMembers(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(teams);

            if (teams.Count > 0)
            {
                teams = await _client.GetAsync(new TeamQuery().WithId(teams.GetRandomItem().Id));
                Assert.NotNull(teams);
            }
        }
    }
}
