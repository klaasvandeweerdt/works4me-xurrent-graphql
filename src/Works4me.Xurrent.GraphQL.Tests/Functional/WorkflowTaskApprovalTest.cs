using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WorkflowTaskApprovalTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<WorkflowTaskApproval> workflowTaskApprovals = await _client.GetAsync(new WorkflowTaskApprovalQuery()
                .View(DefaultView.None)
                .SelectAll(), TestContext.Current.CancellationToken);

            Assert.NotNull(workflowTaskApprovals);

            if (workflowTaskApprovals.Count > 0)
            {
                workflowTaskApprovals = await _client.GetAsync(new WorkflowTaskApprovalQuery().WithId(workflowTaskApprovals.GetRandomItem().Id), TestContext.Current.CancellationToken);
                Assert.NotNull(workflowTaskApprovals);
            }
        }
    }
}
