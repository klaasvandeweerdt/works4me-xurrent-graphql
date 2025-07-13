using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SurveyResponseTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<SurveyResponse> surveyResponses = await _client.GetAsync(new SurveyResponseQuery()
                .View(SurveyResponseView.All)
                .SelectAll()
                .SelectAnswers(new SurveyAnswerQuery()
                    .SelectAll())
                .SelectSlas(new ServiceLevelAgreementQuery()
                    .SelectAll()));

            Assert.NotNull(surveyResponses);

            if (surveyResponses.Count > 0)
            {
                surveyResponses = await _client.GetAsync(new SurveyResponseQuery().WithId(surveyResponses.GetRandomItem().Id));
                Assert.NotNull(surveyResponses);
            }
        }
    }
}
