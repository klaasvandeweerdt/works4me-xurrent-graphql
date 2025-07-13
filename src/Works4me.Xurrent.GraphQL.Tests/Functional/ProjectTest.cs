using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Project> projects = await _client.GetAsync(new ProjectQuery()
                .View(ProjectView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectPhases(new ProjectPhaseQuery()
                    .SelectAll())
                .SelectProblems(new ProblemQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectRisks(new RiskQuery()
                    .SelectAll())
                .SelectTasks(new ProjectTaskQuery()
                    .SelectAll())
                .SelectWorkflows(new WorkflowQuery()
                    .SelectAll()));

            Assert.NotNull(projects);

            if (projects.Count > 0)
            {
                projects = await _client.GetAsync(new ProjectQuery().WithId(projects.GetRandomItem().Id));
                Assert.NotNull(projects);
            }
        }
    }
}
