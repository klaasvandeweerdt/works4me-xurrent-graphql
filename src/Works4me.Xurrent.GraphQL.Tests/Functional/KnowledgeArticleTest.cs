using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class KnowledgeArticleTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<KnowledgeArticle> knowledgeArticles = await _client.GetAsync(new KnowledgeArticleQuery()
                .View(KnowledgeArticleView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new KnowledgeArticleQuery()
                        .ItemsPerRequest(1)
                        .SelectAll())));

            Assert.NotNull(knowledgeArticles);

            if (knowledgeArticles.Count > 0)
            {
                knowledgeArticles = await _client.GetAsync(new KnowledgeArticleQuery().WithId(knowledgeArticles.GetRandomItem().Id));
                Assert.NotNull(knowledgeArticles);
            }
        }
    }
}
