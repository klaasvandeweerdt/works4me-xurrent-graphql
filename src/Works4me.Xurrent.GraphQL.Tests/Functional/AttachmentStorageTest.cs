using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class AttachmentStorageTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            AttachmentStorage? attachmentStorage = await _client.GetAsync(new AttachmentStorageQuery()
                .View(DefaultView.None)
                .SelectAll());

            Assert.NotNull(attachmentStorage);
        }
    }
}
