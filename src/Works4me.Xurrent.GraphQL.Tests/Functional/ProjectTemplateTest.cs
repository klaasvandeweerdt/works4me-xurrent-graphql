using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectTemplateTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProjectTemplate> projectTemplates = await _client.GetAsync(new ProjectTemplateQuery()
                .View(ProjectTemplateView.All)
                .SelectAll()
                .SelectPhases(new ProjectTemplatePhaseQuery()
                    .SelectAll())
                .SelectTaskTemplateRelations(new ProjectTaskTemplateRelationQuery()
                    .SelectAll()
                    .ItemsPerRequest(50)
                    .SelectAutomationRules(new AutomationRuleQuery()
                        .SelectAll()
                        .ItemsPerRequest(10))));

            Assert.NotNull(projectTemplates);

            if (projectTemplates.Count > 0)
            {
                projectTemplates = await _client.GetAsync(new ProjectTemplateQuery().WithId(projectTemplates.GetRandomItem().Id));
                Assert.NotNull(projectTemplates);
            }
        }
    }
}
