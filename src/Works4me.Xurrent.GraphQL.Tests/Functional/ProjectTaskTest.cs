using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectTaskTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProjectTask> projectsTasks = await _client.GetAsync(new ProjectTaskQuery()
                .View(ProjectTaskView.All)
                .SelectAll()
                .SelectAssignments(new ProjectTaskAssignmentQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectPredecessors(new ProjectTaskQuery()
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectSuccessors(new ProjectTaskQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll()));

            Assert.NotNull(projectsTasks);

            if (projectsTasks.Count > 0)
            {
                projectsTasks = await _client.GetAsync(new ProjectTaskQuery().WithId(projectsTasks.GetRandomItem().Id));
                Assert.NotNull(projectsTasks);
            }
        }
    }
}
