using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WorkflowTypeTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<WorkflowType> workflowTypes = await _client.GetAsync(new WorkflowTypeQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .ItemsPerRequest(1)
                    .SelectAll()));

            Assert.NotNull(workflowTypes);

            if (workflowTypes.Count > 0)
            {
                workflowTypes = await _client.GetAsync(new WorkflowTypeQuery().WithId(workflowTypes.GetRandomItem().Id));
                Assert.NotNull(workflowTypes);
            }
        }
    }
}
