using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Mutations;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class WebhookPolicyTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<WebhookPolicy> webhookPolicies = await _client.GetAsync(new WebhookPolicyQuery()
                .View(DefaultView.None)
                .SelectAll());

            Assert.NotNull(webhookPolicies);

            if (webhookPolicies.Count > 0)
            {
                webhookPolicies = await _client.GetAsync(new WebhookPolicyQuery().WithId(webhookPolicies.GetRandomItem().Id));
                Assert.NotNull(webhookPolicies);
            }
        }

        [Fact]
        public async Task CreateAndDelete()
        {
            WebhookPolicyCreatePayload webhookPolicyCreatePayload = await _client.MutationAsync(
                new WebhookPolicyCreateInput(WebhookPolicyJwtAlg.Rs512) { Disabled = false, ClientMutationId = "CMID" },
                new WebhookPolicyCreateResponseQuery().Select(WebhookPolicyCreateResponseField.Id, WebhookPolicyCreateResponseField.PublicKeyPem));

            Assert.NotNull(webhookPolicyCreatePayload);
            Assert.NotNull(webhookPolicyCreatePayload.WebhookPolicy);
            Assert.False(string.IsNullOrWhiteSpace(webhookPolicyCreatePayload.WebhookPolicy.PublicKeyPem));
            Assert.Equal("CMID", webhookPolicyCreatePayload.ClientMutationId);

            WebhookPolicyDeleteMutationPayload webhookPolicyDeleteMutationPayload = await _client.MutationAsync(new WebhookPolicyDeleteMutationInput(webhookPolicyCreatePayload.WebhookPolicy.Id));

            Assert.NotNull(webhookPolicyDeleteMutationPayload);
        }
    }
}
