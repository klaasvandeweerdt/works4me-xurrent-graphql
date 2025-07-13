using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ReleaseTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Release> releases = await _client.GetAsync(new ReleaseQuery()
                .View(ReleaseView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectWorkflows(new WorkflowQuery()
                    .SelectAll()));

            Assert.NotNull(releases);

            if (releases.Count > 0)
            {
                releases = await _client.GetAsync(new ReleaseQuery().WithId(releases.GetRandomItem().Id));
                Assert.NotNull(releases);
            }
        }
    }
}
