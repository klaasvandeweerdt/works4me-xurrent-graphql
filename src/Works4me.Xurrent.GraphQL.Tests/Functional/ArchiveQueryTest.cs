using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class ArchiveQueryTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Archive> archives = await _client.GetAsync(new ArchiveQuery()
                .View(ArchiveView.All)
                .SelectAll()
                .SelectArchivedAll(
                    personQuery: new PersonQuery().Select(PersonField.Id, PersonField.PrimaryEmail, PersonField.Name),
                    configurationItemQuery: new ConfigurationItemQuery().Select(ConfigurationItemField.Id, ConfigurationItemField.Label, ConfigurationItemField.Name)
                ));

            Assert.NotNull(archives);

            if (archives.Count > 0)
            {
                archives = await _client.GetAsync(new ArchiveQuery().WithId(archives.GetRandomItem().Id));
                Assert.NotNull(archives);
            }
        }
    }
}
