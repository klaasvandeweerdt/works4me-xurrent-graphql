using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ProjectCategoryTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ProjectCategory> projectCategories = await _client.GetAsync(new ProjectCategoryQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(projectCategories);

            if (projectCategories.Count > 0)
            {
                projectCategories = await _client.GetAsync(new ProjectCategoryQuery().WithId(projectCategories.GetRandomItem().Id));
                Assert.NotNull(projectCategories);
            }
        }
    }
}
