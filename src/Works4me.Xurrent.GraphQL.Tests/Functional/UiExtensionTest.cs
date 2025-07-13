using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class UiExtensionTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<UiExtension> uiExtensions = await _client.GetAsync(new UiExtensionQuery()
                .View(UiExtensionView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                .SelectVersions(new UiExtensionVersionQuery()
                    .SelectAll()));

            Assert.NotNull(uiExtensions);

            if (uiExtensions.Count > 0)
            {
                uiExtensions = await _client.GetAsync(new UiExtensionQuery().WithId(uiExtensions.GetRandomItem().Id));
                Assert.NotNull(uiExtensions);
            }
        }
    }
}
