using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SurveyTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Survey> surveys = await _client.GetAsync(new SurveyQuery()
                .View(SurveyView.All)
                .SelectAll()
                .SelectCompletionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCompletionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectIntroductionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectQuestions(new SurveyQuestionQuery()
                    .ItemsPerRequest(10)
                    .SelectTranslations(new TranslationQuery()
                        .ItemsPerRequest(1)
                        .SelectAll())
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .ItemsPerRequest(1)
                    .SelectAll()));

            Assert.NotNull(surveys);

            if (surveys.Count > 0)
            {
                surveys = await _client.GetAsync(new SurveyQuery().WithId(surveys.GetRandomItem().Id));
                Assert.NotNull(surveys);
            }
        }
    }
}
