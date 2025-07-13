using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SyncSetTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<SyncSet> syncSets = await _client.GetAsync(new SyncSetQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSelectedRecordsAll()
                .SelectLastSnapshot(new SnapshotQuery()
                    .SelectAll()));

            Assert.NotNull(syncSets);

            if (syncSets.Count > 0)
            {
                syncSets = await _client.GetAsync(new SyncSetQuery().WithId(syncSets.GetRandomItem().Id));
                Assert.NotNull(syncSets);
            }
        }
    }
}
