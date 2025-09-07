using System;
using System.Threading.Tasks;
using Works4me.Xurrent.GraphQL.Mutations;
using Works4me.Xurrent.GraphQL.Tests.Shared;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Functional
{
    public class NoteTest
    {
        private readonly XurrentClient _client = Client.Get();

        [Fact]
        public async Task Create()
        {
            NoteCreatePayload noteCreatePayload = await _client.MutationAsync(new NoteCreateInput($"{DateTime.Now:HH:mm:ss.fff} - Hello World !!!", Client.GetConfigValue("NoteTest.Id"))
            {
                Internal = true
            }, new NoteQuery()
                .Select(NoteField.Id)
                .SelectNoteReactions(new NoteReactionQuery()));

            await Assert.ThrowsAsync<XurrentExecutionException>(async () =>
            {
                await _client.MutationAsync(new NoteCreateInput()
                {
                    Internal = true,
                    OwnerId = Client.GetConfigValue("NoteTest.Id")
                }, new NoteQuery()
                    .Select(NoteField.Id));
            });

            Assert.NotNull(noteCreatePayload);
            Assert.NotNull(noteCreatePayload.Note);
            Assert.NotNull(noteCreatePayload.Note.NoteReactions);

            NoteReactionCreatePayload noteReactionCreatePayload = await _client.MutationAsync(new NoteReactionCreateInput(noteCreatePayload.Note.Id, "👍"), new NoteReactionQuery()
                .SelectAll());

            Assert.NotNull(noteReactionCreatePayload);
            Assert.NotNull(noteReactionCreatePayload.NoteReaction);
            Assert.NotNull(noteReactionCreatePayload.NoteReaction.Note);

            NoteReactionDeleteMutationPayload noteReactionDeleteMutationPayload = await _client.MutationAsync(new NoteReactionDeleteMutationInput(noteReactionCreatePayload.NoteReaction.Id));

            Assert.NotNull(noteReactionDeleteMutationPayload);
            Assert.True(noteReactionDeleteMutationPayload.Success);
        }
    }
}
