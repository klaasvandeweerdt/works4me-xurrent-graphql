using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Tests.Extensions;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class SkillPoolTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Get()
        {
            ReadOnlyDataCollection<SkillPool> skillPools = await _client.GetAsync(new SkillPoolQuery()
                .View(SkillPoolView.All)
                .SelectAll()
                .SelectEffortClasses(new EffortClassQuery()
                    .SelectAll())
                .SelectMembers(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll()), TestContext.Current.CancellationToken);

            Assert.NotNull(skillPools);

            if (skillPools.Count > 0)
            {
                skillPools = await _client.GetAsync(new SkillPoolQuery().WithId(skillPools.GetRandomItem().Id), TestContext.Current.CancellationToken);
                Assert.NotNull(skillPools);
            }
        }
    }
}
