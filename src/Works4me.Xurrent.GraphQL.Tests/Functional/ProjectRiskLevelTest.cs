using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectRiskLevelTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProjectRiskLevel> projectRiskLevels = await _client.GetAsync(new ProjectRiskLevelQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(projectRiskLevels);

            if (projectRiskLevels.Count > 0)
            {
                projectRiskLevels = await _client.GetAsync(new ProjectRiskLevelQuery().WithId(projectRiskLevels.GetRandomItem().Id));
                Assert.NotNull(projectRiskLevels);
            }
        }
    }
}
