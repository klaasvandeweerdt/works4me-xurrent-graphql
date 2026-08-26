using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectTaskAssignmentTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProjectTaskAssignment> projectTaskAssignments = await _client.GetAsync(new ProjectTaskAssignmentQuery()
                .View(DefaultView.None)
                .SelectAll(), TestContext.Current.CancellationToken);

            if (projectTaskAssignments.Count > 0)
            {
                projectTaskAssignments = await _client.GetAsync(new ProjectTaskAssignmentQuery().WithId(projectTaskAssignments.GetRandomItem().Id), TestContext.Current.CancellationToken);
                Assert.NotNull(projectTaskAssignments);
            }
        }
    }
}
