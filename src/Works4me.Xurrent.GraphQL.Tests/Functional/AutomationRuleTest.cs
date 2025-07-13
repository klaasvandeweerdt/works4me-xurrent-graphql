using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AutomationRuleTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<AutomationRule> automationRules = await _client.GetAsync(new AutomationRuleQuery()
                .View(AutomationRuleView.All)
                .SelectAll()
                .SelectOwner(new ProjectTaskQuery()
                    .SelectAll()
                    .ItemsPerRequest(1)
                    .SelectAutomationRules(new AutomationRuleQuery()
                        .SelectAll()))
                .SelectOwnerAll(
                    projectTaskTemplateQuery: new ProjectTaskTemplateQuery()
                        .Select(ProjectTaskTemplateField.Id)
                        .ItemsPerRequest(1),
                    projectTaskTemplateRelationQuery: new ProjectTaskTemplateRelationQuery()
                        .Select(ProjectTaskTemplateRelationField.Id)
                        .ItemsPerRequest(1),
                    requestQuery: new RequestQuery()
                        .SelectAll()
                        .ItemsPerRequest(1),
                    requestTemplateQuery: new RequestTemplateQuery()
                        .Select(RequestTemplateField.Id)
                        .ItemsPerRequest(1),
                    workflowTaskQuery: new WorkflowTaskQuery()
                        .Select(WorkflowTaskField.Id)
                        .ItemsPerRequest(1),
                    workflowTaskTemplateQuery: new WorkflowTaskTemplateQuery()
                        .Select(WorkflowTaskTemplateField.Id)
                        .ItemsPerRequest(1),
                    workflowQuery: new WorkflowQuery()
                        .SelectAll()
                        .ItemsPerRequest(1),
                    workflowTemplateQuery: new WorkflowTemplateQuery()
                        .Select(WorkflowTemplateField.Id)
                        .ItemsPerRequest(1)));

            Assert.NotNull(automationRules);
        }
    }
}
