using System;
using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Builders;
using Works4me.Xurrent.GraphQL.Mutations;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Builders
{
    public class ExecutionBuilderSpecs
    {
        [Fact]
        public void Validate_ConnectionDepth()
        {
            PersonQuery query = new();
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal(1, builder.GetMaximumConnectionDepth());

            query = new PersonQuery()
                .SelectOrganization(new OrganizationQuery()
                    .SelectPeople(new PersonQuery()
                        .SelectTeams(new TeamQuery())));
            builder = new(query, 100);

            Assert.Equal(4, builder.GetMaximumConnectionDepth());
        }

        [Fact]
        public void Validate_GraphQLQuery_OnConnection()
        {
            PersonQuery query = new PersonQuery()
                .Select(PersonField.Id, PersonField.Name, PersonField.PrimaryEmail)
                .SelectTeams(new TeamQuery().Select(TeamField.Id, TeamField.Name));
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {people(first:100){nodes{id name primaryEmail teams(first:100){nodes{id name} pageInfo{endCursor hasNextPage}}} pageInfo{endCursor hasNextPage}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_OnSingleObject()
        {
            RateLimitQuery query = new RateLimitQuery()
                .Select(RateLimitField.Cost, RateLimitField.Limit, RateLimitField.Remaining, RateLimitField.ResetAt);
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {rateLimit {cost limit remaining resetAt}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_WithInterfaceProperties()
        {
            TrashQuery query = new TrashQuery()
                .SelectTrashed(new PersonQuery().Select(PersonField.Id))
                .SelectTrashed(new ConfigurationItemQuery().Select(ConfigurationItemField.Id));
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {trash(first:100){nodes{id trashed {__typename ... on Person {id} ... on ConfigurationItem {id}}} pageInfo{endCursor hasNextPage}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_WithIdFilter()
        {
            PersonQuery query = new PersonQuery()
                .WithId("identifier")
                .Select(PersonField.Id);
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {node(id: \"identifier\") {... on Person {id}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_WithWhereStatement()
        {
            PersonQuery query = new PersonQuery()
                .Where(PersonFilterField.Name, FilterOperator.Equals, "Howard", "Tanner")
                .Select(PersonField.Id);
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {people(first:100 filter:{name:{values:[\"Howard\",\"Tanner\"]}}){nodes{id} pageInfo{endCursor hasNextPage}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_WithSearchFilter()
        {
            PersonQuery query = new PersonQuery()
                .Search("Howard Tanner")
                .Select(PersonField.Id);
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {people(first:100 filter:{query:\"Howard Tanner\"}){nodes{id} pageInfo{endCursor hasNextPage}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_WithCustomFilter()
        {
            Dictionary<PersonQuery, string> peopleQueries = new() {
                { 
                    new PersonQuery().CustomFilter("employee_type", FilterOperator.Equals, "future hire").Select(PersonField.Id),
                    "query {people(first:100 filter:{customFilters:{name:\"employee_type\" values:[\"future hire\"]}}){nodes{id} pageInfo{endCursor hasNextPage}}}"
                },
                { 
                    new PersonQuery().CustomFilter("employee_type", FilterOperator.NotEquals, "future hire").Select(PersonField.Id),
                    "query {people(first:100 filter:{customFilters:{name:\"employee_type\" negate:true values:[\"future hire\"]}}){nodes{id} pageInfo{endCursor hasNextPage}}}"
                },
                { 
                    new PersonQuery().CustomFilter("employee_type", FilterOperator.Empty).Select(PersonField.Id),
                    "query {people(first:100 filter:{customFilters:{name:\"employee_type\" values:[null]}}){nodes{id} pageInfo{endCursor hasNextPage}}}"
                },
                { 
                    new PersonQuery().CustomFilter("employee_type", FilterOperator.Present).Select(PersonField.Id),
                    "query {people(first:100 filter:{customFilters:{name:\"employee_type\" negate:true values:[null]}}){nodes{id} pageInfo{endCursor hasNextPage}}}"
                }
            };

            foreach (KeyValuePair<PersonQuery, string> query in peopleQueries)
            {
                ExecutionBuilder builder = new(query.Key, 100);

                Assert.Equal(query.Value, builder.GetGraphQLQuery());
            }
        }

        [Fact]
        public void Validate_GraphQLQuery_WithInvalidCustomFilters()
        {
            List<PersonQuery> peopleQueries = new() {
                new PersonQuery().CustomFilter("employee_type", FilterOperator.GreaterThan, "future hire").Select(PersonField.Id),
                new PersonQuery().CustomFilter("employee_type", FilterOperator.GreaterThanOrEqualsTo, "future hire").Select(PersonField.Id),
                new PersonQuery().CustomFilter("employee_type", FilterOperator.LessThan, "future hire").Select(PersonField.Id),
                new PersonQuery().CustomFilter("employee_type", FilterOperator.LessThanOrEqualsTo, "future hire").Select(PersonField.Id),
                new PersonQuery().CustomFilter("employee_type", FilterOperator.GreaterThanAndLessThan, "future hire").Select(PersonField.Id),
                new PersonQuery().CustomFilter("employee_type", FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo, "future hire").Select(PersonField.Id),
            };

            foreach (PersonQuery query in peopleQueries)
            {
                ExecutionBuilder builder = new(query, 100);

                Assert.Throws<XurrentQueryException>(() => builder.GetGraphQLQuery());
            }
        }

        [Fact]
        public void Validate_GraphQLQuery_WithCustomNegateFilter()
        {
            PersonQuery query = new PersonQuery()
                .CustomFilter("employee_type", FilterOperator.NotEquals, "future hire");
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {people(first:100 filter:{customFilters:{name:\"employee_type\" negate:true values:[\"future hire\"]}}){nodes{id name} pageInfo{endCursor hasNextPage}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLQuery_WithBlankValueFilters()
        {
            PersonQuery query = new PersonQuery()
                .Search("")
                .CustomFilter("", FilterOperator.NotEquals, "future hire");
            ExecutionBuilder builder = new(query, 100);

            Assert.Equal("query {people(first:100){nodes{id name} pageInfo{endCursor hasNextPage}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLMutation_Create()
        {
            PersonCreateInput input = new()
            {
                Name = "John Doe",
                PrimaryEmail = "john.doe@example.com",
                OrganizationId = "eHVycmVudC9vcmdhbml6YXRpb24vMQ"
            };
            PersonQuery response = new PersonQuery()
                .Select(PersonField.Id, PersonField.Name, PersonField.Organization);
            PersonCreateMutation mutation = new(input, response);
            ExecutionBuilder builder = new(mutation);

            Assert.Equal("mutation($input: PersonCreateInput!) {personCreate(input: $input) {clientMutationId person {id name organization {id name}} errors {message path}}}", builder.GetGraphQLQuery());
        }

        [Fact]
        public void Validate_GraphQLMutation_Update()
        {
            PersonUpdateInput input = new()
            {
                Id = "eHVycmVudC9wZXJzb24vMQ",
                Name = "John Doe",
                PrimaryEmail = "john.doe@example.com",
                OrganizationId = "eHVycmVudC9vcmdhbml6YXRpb24vMQ"
            };
            PersonQuery response = new PersonQuery()
                .Select(PersonField.Id, PersonField.Name, PersonField.Organization);
            PersonUpdateMutation mutation = new(input, response);
            ExecutionBuilder builder = new(mutation);

            Assert.Equal("mutation($input: PersonUpdateInput!) {personUpdate(input: $input) {clientMutationId person {id name organization {id name}} errors {message path}}}", builder.GetGraphQLQuery());
        }
    }
}
