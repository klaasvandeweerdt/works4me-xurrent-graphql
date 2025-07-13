using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class PdfDesignTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<PdfDesign> pdfDesigns = await _client.GetAsync(new PdfDesignQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .ItemsPerRequest(10)
                    .SelectOwner(new PdfDesignQuery()
                        .ItemsPerRequest(1)
                        .SelectTranslations(new TranslationQuery())))
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(pdfDesigns);

            if (pdfDesigns.Count > 0)
            {
                pdfDesigns = await _client.GetAsync(new PdfDesignQuery().WithId(pdfDesigns.GetRandomItem().Id));
                Assert.NotNull(pdfDesigns);
            }
        }
    }
}
