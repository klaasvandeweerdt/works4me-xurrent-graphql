using System.Collections.Immutable;
using Works4me.Xurrent.GraphQL.Mutations;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Models.Mutations
{
    public class PropertyChangeSetSpecs
    {
        [Fact]
        public void Set_AddsField_ToChangeSet()
        {
            PropertyChangeSet changeSet = new();

            string result = changeSet.Set("field_a", "test");

            ImmutableHashSet<string> fields = changeSet.GetFields();

            Assert.Equal("test", result);
            Assert.Contains("field_a", fields);
        }

        [Fact]
        public void Set_Allows_MultipleFields()
        {
            PropertyChangeSet changeSet = new();

            changeSet.Set("field_a", 1);
            changeSet.Set("field_b", 2);
            changeSet.Set("field_a", 3);

            ImmutableHashSet<string> fields = changeSet.GetFields();

            Assert.Equal(2, fields.Count);
            Assert.Contains("field_a", fields);
            Assert.Contains("field_b", fields);
        }

        [Fact]
        public void GetFields_ReturnsImmutableSet()
        {
            PropertyChangeSet changeSet = new();

            changeSet.Set("field_x", true);

            ImmutableHashSet<string> fields = changeSet.GetFields();

            Assert.Single(fields);
            Assert.Contains("field_x", fields);

            Assert.IsType<ImmutableHashSet<string>>(fields);
        }
    }
}
