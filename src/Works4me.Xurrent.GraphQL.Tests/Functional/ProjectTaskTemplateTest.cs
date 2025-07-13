using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectTaskTemplateTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProjectTaskTemplate> projectTaskTemplates = await _client.GetAsync(new ProjectTaskTemplateQuery()
                .View(ProjectTaskTemplateView.All)
                .SelectAll()
                .SelectAssignments(new ProjectTaskTemplateAssignmentQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectProjectTemplates(new ProjectTemplateQuery()
                    .SelectAll())
                .SelectTasks(new ProjectTaskQuery()
                    .SelectAll()));

            Assert.NotNull(projectTaskTemplates);

            if (projectTaskTemplates.Count > 0)
            {
                projectTaskTemplates = await _client.GetAsync(new ProjectTaskTemplateQuery().WithId(projectTaskTemplates.GetRandomItem().Id));
                Assert.NotNull(projectTaskTemplates);
            }
        }
    }
}
