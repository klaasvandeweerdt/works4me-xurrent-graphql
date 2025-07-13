using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WebhookTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Webhook> webhooks = await _client.GetAsync(new WebhookQuery()
                .View(DefaultView.None)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll()));

            Assert.NotNull(webhooks);

            if (webhooks.Count > 0)
            {
                webhooks = await _client.GetAsync(new WebhookQuery().WithId(webhooks.GetRandomItem().Id));
                Assert.NotNull(webhooks);
            }
        }
    }
}
