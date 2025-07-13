using System.Linq;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class TrashTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Trash> trashes = await _client.GetAsync(new TrashQuery()
                .View(TrashView.All)
                .SelectAll()
                .SelectTrashed(new ConfigurationItemQuery()
                    .Select(ConfigurationItemField.Id))
                .SelectTrashed(new PersonQuery()
                    .Select(PersonField.Id, PersonField.Name, PersonField.PrimaryEmail)));

            Assert.NotNull(trashes);

            if (trashes.Count > 0)
            {
                trashes = await _client.GetAsync(new TrashQuery()
                    .WithId(trashes.GetRandomItem().Id)
                    .Select(TrashField.Id, TrashField.CreatedAt));

                Trash trash = trashes.First();
                Assert.NotNull(trash.Id);
                Assert.NotNull(trash.CreatedAt);
            }
        }
    }
}
