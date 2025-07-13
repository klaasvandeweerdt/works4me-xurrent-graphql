using System;
using System.Linq;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class PersonTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<Person> people = await _client.GetAsync(new PersonQuery()
                .View(PersonView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCart(new ShopOrderLineQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectContacts(new ContactQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectOutOfOfficePeriods(new OutOfOfficePeriodQuery()
                    .SelectAll())
                .SelectPermissions(new PermissionQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectTeams(new TeamQuery()
                    .SelectAll()));

            Assert.NotNull(people);

            if (people.Count > 0)
            {
                people = await _client.GetAsync(new PersonQuery()
                    .View(PersonView.All)
                    .Where(PersonFilterField.Id, FilterOperator.Equals, people.GetRandomItem().Id)
                    .Select(PersonField.Id, PersonField.Name, PersonField.CreatedAt, PersonField.UpdatedAt));

                Person? person = people.FirstOrDefault();
                Assert.NotNull(person);
                Assert.True(person.GetIdentifier() > 0);
                Assert.NotNull(person.CreatedAt);
                Assert.NotNull(person.UpdatedAt);
                Assert.Null(person.PrimaryEmail);
            }
        }

        [Fact]
        public async Task GetExceptions()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                _ = await _client.GetAsync(new PersonQuery().WithId(string.Empty));
            });
        }
    }
}
