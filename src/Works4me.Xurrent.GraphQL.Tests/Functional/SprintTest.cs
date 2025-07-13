using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SprintTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Sprint> sprints = await _client.GetAsync(new SprintQuery()
                .View(SprintView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll()
                    .SelectRecordAll(
                        problemQuery: new ProblemQuery()
                            .SelectAll(),
                        projectTaskQuery: new ProjectTaskQuery()
                            .SelectAll(),
                        requestQuery: new RequestQuery()
                            .SelectAll(),
                        workflowTaskQuery: new WorkflowTaskQuery()
                            .SelectAll())));

            Assert.NotNull(sprints);

            if (sprints.Count > 0)
            {
                sprints = await _client.GetAsync(new SprintQuery().WithId(sprints.GetRandomItem().Id));
                Assert.NotNull(sprints);
            }
        }
    }
}
