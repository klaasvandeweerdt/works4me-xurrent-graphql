using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WorkflowTaskTemplateTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<WorkflowTaskTemplate> taskTemplates = await _client.GetAsync(new WorkflowTaskTemplateQuery()
                .View(WorkflowTaskTemplateView.All)
                .SelectAll()
                .SelectApprovals(new TaskTemplateApprovalQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectTasks(new WorkflowTaskQuery()
                    .SelectAll())
                .SelectWorkflowTemplates(new WorkflowTemplateQuery()
                    .SelectAll()));

            Assert.NotNull(taskTemplates);

            if (taskTemplates.Count > 0)
            {
                taskTemplates = await _client.GetAsync(new WorkflowTaskTemplateQuery().WithId(taskTemplates.GetRandomItem().Id));
                Assert.NotNull(taskTemplates);
            }
        }
    }
}
