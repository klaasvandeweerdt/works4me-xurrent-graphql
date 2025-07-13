using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ScrumWorkspaceTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ScrumWorkspace> scrumWorkspaces = await _client.GetAsync(new ScrumWorkspaceQuery()
                .View(ScrumWorkspaceView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSprints(new SprintQuery()
                    .SelectAll()));

            Assert.NotNull(scrumWorkspaces);

            if (scrumWorkspaces.Count > 0)
            {
                scrumWorkspaces = await _client.GetAsync(new ScrumWorkspaceQuery().WithId(scrumWorkspaces.GetRandomItem().Id));
                Assert.NotNull(scrumWorkspaces);
            }
        }
    }
}
