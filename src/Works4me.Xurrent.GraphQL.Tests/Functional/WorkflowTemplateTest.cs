using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WorkflowTemplateTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<WorkflowTemplate> workflowTemplates = await _client.GetAsync(new WorkflowTemplateQuery()
                .View(WorkflowTemplateView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTaskTemplateRelations(new WorkflowTaskTemplateRelationQuery()
                    .SelectAll())
                .SelectWorkflows(new WorkflowQuery()
                    .SelectAll()));

            Assert.NotNull(workflowTemplates);

            if (workflowTemplates.Count > 0)
            {
                workflowTemplates = await _client.GetAsync(new WorkflowTemplateQuery().WithId(workflowTemplates.GetRandomItem().Id));
                Assert.NotNull(workflowTemplates);
            }
        }
    }
}
