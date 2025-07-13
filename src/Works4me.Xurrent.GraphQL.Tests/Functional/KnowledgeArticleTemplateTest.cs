using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class KnowledgeArticleTemplateTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<KnowledgeArticleTemplate> knowledgeArticleTemplates = await _client.GetAsync(new KnowledgeArticleTemplateQuery()
                .View(KnowledgeArticleTemplateView.All)
                .SelectAll()
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll()));

            Assert.NotNull(knowledgeArticleTemplates);

            if (knowledgeArticleTemplates.Count > 0)
            {
                knowledgeArticleTemplates = await _client.GetAsync(new KnowledgeArticleTemplateQuery().WithId(knowledgeArticleTemplates.GetRandomItem().Id));
                Assert.NotNull(knowledgeArticleTemplates);
            }
        }
    }
}
