using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ServiceCategoryTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<ServiceCategory> serviceCategories = await _client.GetAsync(new ServiceCategoryQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServices(new ServiceQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new ServiceCategoryQuery()
                        .ItemsPerRequest(1)
                        .SelectAll())));

            Assert.NotNull(serviceCategories);

            if (serviceCategories.Count > 0)
            {
                serviceCategories = await _client.GetAsync(new ServiceCategoryQuery().WithId(serviceCategories.GetRandomItem().Id));
                Assert.NotNull(serviceCategories);
            }
        }
    }
}
