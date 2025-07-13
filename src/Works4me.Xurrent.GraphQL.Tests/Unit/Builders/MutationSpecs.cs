using System;
using System.Collections.Immutable;
using Works4me.Xurrent.GraphQL.Mutations;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Builders
{
    public class MutationSpecs
    {
        [Fact]
        public void Constructor_Sets_NameDataTypeNameDataAndQuery()
        {
            ConfigurationItemUpdateInput data = new("init-id");
            IQuery query = new ConfigurationItemQuery();
            query.Name = "oldName";
            query.IsConnection = true;
            Mutation<ConfigurationItemUpdateInput> mutation = new("mutName", "ConfigItemInput", data, query);

            Assert.Equal("mutName", mutation.Name);
            Assert.Equal("ConfigItemInput", mutation.DataTypeName);
            Assert.Same(data, mutation.Data);
            Assert.Same(query, mutation.Query);
        }

        [Fact]
        public void GetFields_DelegatesToUpdateInput()
        {
            ConfigurationItemUpdateInput data = new("id123")
            {
                Name = "TestName"
            };
            Uri testUri = new("http://example.com/img.png");
            data.PictureUri = testUri;
            IQuery query = new ConfigurationItemQuery();
            query.Name = string.Empty;
            query.IsConnection = false;
            Mutation<ConfigurationItemUpdateInput> mutation = new("m", "t", data, query);

            ImmutableHashSet<string> fields = mutation.GetFields();

            Assert.Contains("id", fields);
            Assert.Contains("name", fields);
            Assert.Contains("pictureUri", fields);
            Assert.Equal(3, fields.Count);
        }

        [Fact]
        public void UpdateQuery_SetsNameAndDisablesConnection()
        {
            IQuery query = new ConfigurationItemQuery();
            query.Name = "initial";
            query.IsConnection = true;
            IQuery result = Mutation<ConfigurationItemUpdateInput>.UpdateQuery(query, "newName");

            Assert.Same(query, result);
            Assert.Equal("newName", query.Name);
            Assert.False(query.IsConnection);
        }
    }
}