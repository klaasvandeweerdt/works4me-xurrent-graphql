using System;
using System.Linq;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class RequestTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Request> requests = await _client.GetAsync(new RequestQuery()
                .View(RequestView.All)
                .ItemsPerRequest(1)
                .SelectAll()
                .SelectAffectedSlas(new AffectedSlaQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectGroupedRequests(new RequestQuery()
                    .SelectAll())
                .SelectKnowledgeArticles(new KnowledgeArticleQuery()
                    .SelectAll())
                .SelectFeedbackOnKnowledgeArticle(new KnowledgeArticleQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll()
                    .SelectNoteReactions(new NoteReactionQuery()
                        .ItemsPerRequest(1)
                        .SelectAll()))
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll())
                .SelectWatches(new WatchQuery()
                    .SelectAll())
                .SelectTags(new TagQuery()
                    .ItemsPerRequest(5)
                    .SelectAll()));

            Assert.NotNull(requests);

            if (requests.Count > 0)
            {
                requests = await _client.GetAsync(new RequestQuery()
                    .WithId(requests.GetRandomItem().Id)
                    .Select(RequestField.RequestId));

                Assert.NotNull(requests);
                Request request = requests.First();
                Assert.True(request.GetIdentifier() > 0);
                Assert.Equal(request.GetIdentifier(), Convert.ToInt64(request.RequestId));
            }
        }
    }
}
