using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class TimeEntryTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<TimeEntry> timeEntries = await _client.GetAsync(new TimeEntryQuery()
                .View(TimeEntryView.All)
                .SelectAll()
                .SelectAssignmentAll(
                    problemQuery: new ProblemQuery()
                        .SelectAll(),
                    projectTaskQuery: new ProjectTaskQuery()
                        .SelectAll(),
                    requestQuery: new RequestQuery()
                        .SelectAll(),
                    workflowTaskQuery: new WorkflowTaskQuery()
                        .SelectAll()
                ));

            Assert.NotNull(timeEntries);

            if (timeEntries.Count > 0)
            {
                timeEntries = await _client.GetAsync(new TimeEntryQuery().WithId(timeEntries.GetRandomItem().Id));
                Assert.NotNull(timeEntries);
            }
        }
    }
}
