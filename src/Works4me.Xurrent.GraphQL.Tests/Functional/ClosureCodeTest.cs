using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ClosureCodeTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ClosureCode> closureCodes = await _client.GetAsync(new ClosureCodeQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectTranslations(new TranslationQuery()
                    .ItemsPerRequest(1))
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(closureCodes);

            if (closureCodes.Count > 0)
            {
                closureCodes = await _client.GetAsync(new ClosureCodeQuery().WithId(closureCodes.GetRandomItem().Id));
                Assert.NotNull(closureCodes);
            }
        }
    }
}
