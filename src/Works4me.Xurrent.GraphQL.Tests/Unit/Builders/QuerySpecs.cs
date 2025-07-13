using System;
using Works4me.Xurrent.GraphQL.Builders;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Builders
{
    public class QuerySpecs
    {
        [Fact]
        public void Constructor_Sets_DefaultProperties()
        {
            IQuery query = new PersonQuery();
            Assert.Equal("people", query.Name);
            Assert.True(query.IsConnection);
            Assert.Equal(typeof(Person), query.DataType);
            Assert.Equal("Person", query.DataTypeName);
        }

        [Fact]
        public void View_Sets_SelectedView()
        {
            IQuery query = new PersonQuery().View(PersonView.Archive);
            Assert.Equal("archive", query.SelectedView);
        }

        [Fact]
        public void Select_Adds_Fields()
        {
            IQuery query = new PersonQuery().Select(PersonField.Name, PersonField.JobTitle);
            Assert.Contains("name", query.Fields);
            Assert.Contains("jobTitle", query.Fields);
            Assert.Equal(2, query.Fields.Count);
        }

        [Fact]
        public void Select_Throws_WhenNull()
        {
            PersonQuery query = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentNullException>(() => query.Select(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [Fact]
        public void SelectAll_Sets_Flag()
        {
            IQuery query = new PersonQuery().SelectAll();
            Assert.True(query.SelectAll);
        }

        [Fact]
        public void WithId_Sets_IdAndThrowsOnInvalid()
        {
            PersonQuery query = new PersonQuery().WithId("123");
            Assert.Equal("123", ((IQuery)query).Id);
            Assert.Throws<ArgumentException>(() => query.WithId(" "));
        }

        [Fact]
        public void OrderBy_Sets_OrderAndSort()
        {
            IQuery query = new PersonQuery().OrderBy(PersonOrderField.Name, SortOrder.Descending);
            Assert.Equal("name", query.OrderBy);
            Assert.Equal("desc", query.SortOrder);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        public void ItemsPerRequest_Valid(int count)
        {
            IQuery query = new PersonQuery().ItemsPerRequest(count);
            Assert.Equal(count, query.ItemsPerRequest);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        public void ItemsPerRequest_InvalidThrows(int count)
        {
            PersonQuery query = new();
            Assert.Throws<XurrentQueryException>(() => query.ItemsPerRequest(count));
        }

        [Fact]
        public void SelectAccount_Adds_NestedQuery()
        {
            IQuery query = new PersonQuery().SelectAccount(new AccountQuery());
            Assert.Single(query.Queries);
            IQuery nested = query.Queries[0];
            Assert.Equal("account", nested.Name);
            Assert.False(nested.IsConnection);
        }

        [Fact]
        public void SelectAddresses_Adds_ConnectionQuery()
        {
            IQuery query = new PersonQuery().SelectAddresses(new AddressQuery());
            Assert.Single(query.Queries);
            IQuery nested = query.Queries[0];
            Assert.Equal("addresses", nested.Name);
            Assert.True(nested.IsConnection);
        }

        [Fact]
        public void Where_Adds_Filter()
        {
            IQuery query = new PersonQuery().Where(PersonFilterField.Name, FilterOperator.Equals, "John", "Jane");
            Assert.Single(query.Filters);
            QueryFilter f = query.Filters[0];
            Assert.Equal("name", f.FieldName);
            Assert.Equal(FilterOperator.Equals, f.Operator);
            Assert.Equal(2, f.Values.Count);
            Assert.Equal(FilterValueType.String, f.ValueType);
        }

        [Fact]
        public void CustomFilter_Adds_CustomFilter()
        {
            IQuery query = new PersonQuery().CustomFilter("myField", FilterOperator.NotEquals, "x");
            Assert.Single(query.Filters);
            QueryFilter f = query.Filters[0];
            Assert.Equal("myField", f.FieldName);
            Assert.Equal(FilterOperator.NotEquals, f.Operator);
            Assert.Equal(FilterValueType.Custom, f.ValueType);
        }

        [Fact]
        public void Search_Adds_QueryFilter()
        {
            IQuery query = new PersonQuery().Search("test");
            Assert.Single(query.Filters);
            QueryFilter f = query.Filters[0];
            Assert.Equal("query", f.FieldName);
            Assert.Equal(FilterOperator.Equals, f.Operator);
            Assert.Equal(FilterValueType.Query, f.ValueType);
        }

        [Fact]
        public void Clone_Creates_DeepCopy()
        {
            PersonQuery original = new PersonQuery()
                .Select(PersonField.Name)
                .Where(PersonFilterField.Id, FilterOperator.Equals, "1");
            IQuery clone = ((IQuery)original).Clone();

            original = original.Select(PersonField.JobTitle);
            original = original.Where(PersonFilterField.Name, FilterOperator.NotEquals, "x");

            IQuery originalIq = original;
            IQuery cloneIq = clone;

            Assert.NotEqual(originalIq.Fields.Count, cloneIq.Fields.Count);
            Assert.NotEqual(originalIq.Filters.Count, cloneIq.Filters.Count);
        }

        [Fact]
        public void Default_Properties_Are_Initialized_Correctly()
        {
            IQuery query = new PersonQuery();
            Assert.Null(query.Id);
            Assert.Null(query.SelectedView);
            Assert.False(query.SelectAll);
            Assert.Null(query.OrderBy);
            Assert.Null(query.SortOrder);
            Assert.Null(query.ItemsPerRequest);
            Assert.Empty(query.Fields);
            Assert.Empty(query.Filters);
            Assert.Empty(query.Queries);
            Assert.Empty(query.OnTypeQueries);
            Assert.Equal(typeof(PersonFilterField), query.FilterType);
        }
    }
}