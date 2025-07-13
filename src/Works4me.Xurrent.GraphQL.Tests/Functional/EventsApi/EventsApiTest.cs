using System;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional.EventsApi
{
    public class EventsApiTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Create()
        {
            RequestEventCreateInput requestCreate = new RequestEventCreateInput()
                .Category(RequestCategory.Incident)
                .Note("An event note")
                .Subject("SDK Test")
                .Source("Xurrent.Sdk.GraphQL")
                .SourceID("1")
                .ServiceInstance(Convert.ToInt32(Client.GetConfigValue("EventApi.ServiceInstance")))
                .Impact(RequestImpact.Medium)
                .ConfigurationItem(Convert.ToInt32(Client.GetConfigValue("EventApi.ConfigurationItem")))
                .Team(Convert.ToInt32(Client.GetConfigValue("EventApi.Team")));

            Request request = await _client.CreateEventAsync(requestCreate);

            Assert.NotNull(request);
            Assert.NotNull(request.Id);
            Assert.NotNull(request.RequestId);
        }
    }
}
