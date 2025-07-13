using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class CustomCollectionElementTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<CustomCollectionElement> customCollectionElements = await _client.GetAsync(new CustomCollectionElementQuery()
                .View(CustomCollectionElementView.All)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()));

            Assert.NotNull(customCollectionElements);

            if (customCollectionElements.Count > 0)
            {
                customCollectionElements = await _client.GetAsync(new CustomCollectionElementQuery().WithId(customCollectionElements.GetRandomItem().Id));
                Assert.NotNull(customCollectionElements);
            }
        }
    }
}
