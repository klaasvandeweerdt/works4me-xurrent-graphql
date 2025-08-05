# .NET SDK for Xurrent GraphQL

A .NET Framework and .NET client for accessing the [Xurrent GraphQL API](https://developer.xurrent.com/graphql/).

## Table of Contents

- [NuGet](#nuget)
- [Quick Example](#quick-example)
- [Introduction](#introduction)
- [Client](#client)
- [Authentication](#authentication)
- [Querying](#querying)
  - [Query Execution Options](#query-execution-options)
  - [Filtering](#filtering)
  - [View Argument](#view-argument)
  - [Sorting](#sorting)
  - [Data Retrieval and Large Result Sets](#data-retrieval-and-large-result-sets)
  - [Special Timestamps](#special-timestamps)
  - [Interface-Based Properties](#interface-based-properties)
  - [Default Field Selection](#default-field-selection)
- [Mutations](#mutations)
- [Attachments](#attachments)
- [Events API](#events-api)
- [Bulk API](#bulk-api)
- [Client Behavior and Limits](#client-behavior-and-limits)
  - [Multiple Authentication Tokens](#multiple-authentication-tokens)
  - [Rate and Cost Limits](#rate-and-cost-limits)
  - [Response Timing](#response-timing)
  - [Logging Capabilities](#logging-capabilities)
- [Examples](#examples)
  - [Queries](#queries)
  - [Mutations](#mutations-1)
  - [Attachments](#attachments-1)
  - [Create a New Event via the Events API](#create-a-new-event-via-the-events-api)
  - [Bulk Import and Export](#bulk-import-and-export)
  - [Exception Handling](#exception-handling)
  - [Client Behavior Examples](#client-behavior-examples)


## NuGet

Stable binaries are published to [NuGet.org](https://www.nuget.org/packages/Works4me.Xurrent.GraphQL) and contain everything needed to use the .NET SDK for Xurrent GraphQL in your application.

**Package Manager Console**

```powershell
Install-Package Works4me.Xurrent.GraphQL
```

**.NET CLI**

```
dotnet add package Works4me.Xurrent.GraphQL
```

**Visual Studio**  
Use the NuGet Package Manager in Visual Studio to search for and install `Works4me.Xurrent.GraphQL`.

## Quick Example

```csharp
using Works4me.Xurrent.GraphQL;

AuthenticationToken token = new("ClientId", "ClientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Demo, EnvironmentRegion.EU);

PersonQuery query = new PersonQuery()
    .View(PersonView.All)
    .Select(PersonField.Name)
    .SelectOrganization(new OrganizationQuery().Select(OrganizationField.Name))
    .SelectTeams(new TeamQuery().Select(TeamField.Id))
    .SelectConfigurationItems(new ConfigurationItemQuery().Select(ConfigurationItemField.Id));

await foreach (Person person in client.StreamAsync(query))
{
    string orgName = person.Organization?.Name ?? "no organization";
    int teamCount = person.Teams?.Count ?? 0;
    int ciCount = person.ConfigurationItems?.Count ?? 0;

    Console.WriteLine($"{person.Name} works at {orgName}, is a member of {teamCount} team(s), and has {ciCount} configuration item(s) assigned.");
}
```

Want more? See the full [Examples](#examples) section below.

## Introduction

This SDK simplifies integration with the Xurrent GraphQL API by abstracting HTTP request construction, JSON serialization/deserialization, and connection data retrieval. It exposes a set of fluent, strongly-typed query and mutation classes so you can build complex GraphQL operations with minimal boilerplate. Under the covers, it manages rate-limit compliance, token renewal, and optimized handling of large result sets, letting you focus on application logic and business requirements.

For a primer on GraphQL, see [graphql.org](https://graphql.org/).  
For Xurrent-specific tutorials and reference material, visit [Xurrent GraphQL Training docs](https://learning.xurrent.com/integrations_graphql/).

The entity classes and fields in this SDK mirror the Xurrent Quality Assurance schema and may include preview features or fields not yet available in production.

## Client

The `XurrentClient` class provides access to all necessary methods for querying and modifying data, with `GetAsync` and `MutationAsync` methods. You can customize client behavior through four key properties:

- `AccountId`: Update the Xurrent Account ID after initializing the client, enabling account switching using the same client instance.
- `DefaultItemsPerRequest`: Set the number of items per connection request. The default and maximum value is 100.
- `MaximumConnectionDepth`: Set the depth for nested queries. While this can be increased, higher values may negatively impact performance. The default value is 2, the maximum value is 13.
- `MaximumRequestsPerQuery`: Control the maximum number of recursive requests the client can make when paginating top-level queries. The default value is 1000, the maximum value is 10000.

## Authentication

The SDK supports both Personal Access Token and OAuth 2.0 Client Credential Grant authentication methods.  
When using OAuth 2.0 Client Credential Grant, token renewal is handled automatically two minutes before expiration.

## Querying

The SDK provides a fluent, strongly-typed interface for building GraphQL queries. It enables precise field selection and supports fetching nested and hierarchical data structures within a single request.

### Query Execution Options

The SDK offers two primary ways to execute queries:

- **Batch Mode**  
  Retrieve all results in a single aggregated call. The SDK automatically handles any underlying pagination, so you receive the full result set without additional effort.

- **Streaming Mode**  
  Process results item-by-item using C#'s `await foreach` construct. This approach improves memory efficiency and responsiveness when working with large result sets.

Both modes fully support nested selections, enabling you to retrieve related and hierarchical data in a single request.

See [Query Examples](#queries) for practical usage.

### Filtering

Filters can be easily applied on root connections when building a query, allowing retrieval of specific data. 
Filtering enables limiting the results returned by the query by adding conditions to the queried fields. 
It is possible to filter results based on specific values or ranges, simplifying the process of locating relevant data.

See [Filtering Examples](#filtering-1) for practical usage.

### View Argument

In addition to filtering capabilities, the SDK supports specifying the scope of a query using the `view` argument on root connections.  
The `view` argument can be used to target a specific set of data. By default, it is set to the current account, but it is also possible to query all accounts or another predefined subset of data for a particular data entity.

### Sorting

The SDK provides the ability to sort query results based on a specific field and order. Sorting can only be applied to the top-level query and is not supported on nested connections or subqueries.
To define sorting behavior, use the `OrderBy` method, specifying both the field to sort on and the desired sort order.
The sort order is controlled by the `SortOrder` parameter, which supports ascending or descending sorting.
If no sorting is applied, the default order of results is determined by the Xurrent GraphQL API.

See [Sorting Examples](#sorting-1) for practical usage.

### Data Retrieval and Large Result Sets

The SDK automatically handles retrieving large result sets when a connection contains more than 100 items. By default, results are fetched in increments of 100 items per request, with no manual intervention required.

To prevent excessive API usage, the SDK limits the number of consecutive requests it can make when retrieving large datasets for a single top-level query. This limit is controlled by the `MaximumRequestsPerQuery` property, which is set on the client instance.

- `MaximumRequestsPerQuery`: Defines the maximum number of recursive requests the client will perform to fetch additional items for top-level queries. The default value is 1000, and the maximum allowed value is 10,000.

In most scenarios, the default value is sufficient. However, when working with very large datasets or when you need to respect API rate limits (such as avoiding more than 3600 requests per hour with a single token), you can lower this setting to control the client's behavior.

This approach simplifies working with large datasets while providing flexibility for advanced use cases and API rate management.

### Special Timestamps

The Xurrent GraphQL API uses a data type called `ISO8601Timestamp`, which can include three special non-datetime values: `best_effort`, `no_target`, and `clock_stopped`. These values cannot be represented as standard date and time values.

To support these exceptions, the SDK provides a custom `JsonConverter` that maps each exception value to a specific `DateTime` instance:

- `best_effort` is mapped to `0001-01-01 01:01:01.111`
- `no_target` is mapped to `0002-02-02 02:02:02.222`
- `clock_stopped` is mapped to `0003-03-03 03:03:03.333`

These special mappings are available as predefined `SpecialTimestamp` instances under `Works4me.Xurrent.GraphQL.SpecialTimestamps`.  
The `SpecialTimestamps` class also provides dictionaries for converting between the textual keys and their `DateTime` representations.  
This allows for straightforward comparison and detection of these special values in application logic, making it easy to identify and handle exception cases when working with timestamps in the SDK.

### Interface-Based Properties

Some properties in the API return objects that implement an interface, allowing for flexibility in the types of objects that may be provided.  
When querying these interface-based properties, it is necessary to indicate the desired concrete type in the select statement. If a type is not specified in the select statement, the property will return `null` for that object.

The SDK supports this scenario by enabling multiple select statements for a single interface-based property. This allows for querying and retrieving various concrete types and their respective fields in a single operation.

### Default Field Selection

When building a query, you must explicitly specify the fields to include for each object unless you rely on the SDK's **default field selection** behavior.
The default field selection determines which fields are automatically included when no query is provided for an object.

- For most objects
  - `id`
  - `name` or `subject` (if available)

- If the object contains an `id` field, but not a `name` or `subject` field:
  - Only `id` is returned by default

- If the object does not contain an `id` field:
  - All fields, except connection (relationship) properties, are returned by default

- Exceptions:
  - For `CustomField`, `Address`, and `Contact` objects, all fields are returned by default, regardless of the rules above

This behavior applies to new instances:

```csharp
new OrganizationQuery();
```

 and reference fields such as:

```csharp
.Select(PersonField.Organization)
```

In this case, unless you explicitly provide an `OrganizationQuery` via `.SelectOrganization()`, the SDK automatically applies default field selection to the `Organization` object in the response.

Default field selection simplifies common queries while ensuring that only essential fields are retrieved when no query is defined.

## Mutations

The SDK provides a fluent, strongly-typed interface for creating, updating, and deleting data through GraphQL mutations.

See [Mutation Examples](#mutations-1) for practical usage.

### Mutation Behavior

- Mutations return the newly created or updated object (delete operations return no object).
- You must explicitly specify which fields to return in the mutation.
- Connection fields included in a mutation response are not paged.

## Attachments

The SDK provides an `UploadAttachment` method for uploading attachments, which can then be associated with any create or update mutation.  
The response from this method includes the information required to link the uploaded attachments to other objects.

See [Attachment Examples](#attachments-1) for practical usage.

## Events API

The .NET SDK provides access to the Xurrent Events REST API.  
For more information, see the [Xurrent Developer Pages](https://developer.xurrent.com/v1/requests/events/).  
The response will only include the request identifier and the request number.

See [Events API Examples](#create-a-new-event-via-the-events-api) for practical usage.

## Bulk API

The .NET SDK provides access to the Xurrent Bulk REST API, enabling data import and export.  
For more information, see the [Xurrent Developer Pages](https://developer.xurrent.com/v1/bulk/).

See [Bulk API Examples](#bulk-import-and-export) for practical usage.

## Client Behavior and Limits

### Multiple Authentication Tokens

The client allows for the use of multiple authentication tokens. A single token is limited to 3600 API requests per hour or 5000 points per hour for Query Cost. In some situations, this may not be sufficient.  
When multiple tokens are in use, the client will automatically select the token with the most remaining requests.  
More information about [Rate Limiting](https://developer.xurrent.com/graphql/#request-rate-limits) and [Query Cost Limits](https://developer.xurrent.com/graphql/#query-cost-limit) is available on the [Xurrent Developer Pages](https://developer.xurrent.com/graphql).

### Rate and Cost Limits

Each `AuthenticationToken` exposes its current rate and cost counters once you execute your first query or mutation with this token.

After your first query/mutation, each token exposes its live rate-limit and cost-limit counters:

- **`AuthenticationToken.RequestLimit.Limit`**  
  The maximum number of requests permitted in a rolling 60-minute window.

- **`AuthenticationToken.RequestLimit.Remaining`**  
  How many requests remain in the current rate-limit window.

- **`AuthenticationToken.RequestLimit.Reset`**  
  The timestamp when the current rate-limit window will reset.

- **`AuthenticationToken.CostLimit.Limit`**  
  The maximum number of query-cost points permitted in a rolling 60-minute window.

- **`AuthenticationToken.CostLimit.Remaining`**  
  How many cost points remain in the current cost-limit window.

- **`AuthenticationToken.CostLimit.Reset`**  
  The timestamp when the current cost-limit window will reset.

See [Rate and Cost Limits Examples](#rate-and-cost-limits-values) for practical usage.

### Response Timing

The Xurrent GraphQL API limits the number of requests to 20 per 2 seconds. The SDK tracks responses and ensures the limit is not exceeded.  
These limits are associated with each authentication token, which has to represent a unique user or application in Xurrent.

### Logging Capabilities

All details are logged using [ILogger](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger) as structured `XurrentTraceMessage` objects.

You can configure any [logging provider](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging-providers) (e.g., console, file, Seq, Application Insights) to capture this information for debugging, monitoring, or auditing.

Each request generates two log entries with the same unique identifier:
- The first entry logs the account ID, HTTP verb, URL, and request content.
- The second entry logs the HTTP response status code and the response time in milliseconds.

Logs are structured and include all relevant context through the `XurrentTraceMessage` type.

# Examples

## Minimum Example
```csharp
using Works4me.Xurrent.GraphQL;

AuthenticationToken token = new("ClientId", "ClientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Demo, EnvironmentRegion.EU);
```

## Queries

Note: All query examples assume `using Works4me.Xurrent.GraphQL;` is present.

### Get People - Batch Mode

You must always specify the fields to include in the response for each object you want to retrieve.
In the following example, fields like `Id`, `Name`, `PrimaryEmail` and `Organization` are selected for the `Person` object.

```csharp
PersonQuery query = new PersonQuery()
    .Select(PersonField.Id, PersonField.Name, PersonField.PrimaryEmail, PersonField.Organization);

IReadOnlyCollection<Person> people = await client.GetAsync(query);
```

To further refine the selection of fields by using a query for a specific GraphQL Object type field, in this case, `Organization`.
By using the `SelectOrganization` method on the `PersonQuery` object, you can specify the fields to include for the `Organization` field.
The example demonstrates the selection of fields like `Id`, `Name`, and `Disabled` for the `Organization` field, and the `Name` of the `Account`.

```csharp
PersonQuery query = new PersonQuery()
    .Select(PersonField.Id, PersonField.Name, PersonField.PrimaryEmail)
    .SelectOrganization(new OrganizationQuery()
        .Select(OrganizationField.Id, OrganizationField.Name, OrganizationField.Disabled)
    .SelectAccount(new AccountQuery()
        .Select(AccountField.Name)));

IReadOnlyCollection<Person> people = await client.GetAsync(query);
```

### Get People - Streaming Mode

The SDK also supports streaming query results using `StreamAsync`.
While results are still retrieved in pages behind the scenes, the SDK yields items one by one as they become available, allowing you to process each item individually without loading the entire result set into memory at once.

This approach is ideal for working with large datasets or when you want to start processing results immediately, without waiting for the full query to complete.

The query structure remains identical to the previous example, but results are consumed item-by-item using C#'s `await foreach` construct.


```csharp
PersonQuery query = new PersonQuery()
    .Select(PersonField.Id, PersonField.Name, PersonField.PrimaryEmail)
    .SelectOrganization(new OrganizationQuery()
        .Select(OrganizationField.Id, OrganizationField.Name, OrganizationField.Disabled)
    .SelectAccount(new AccountQuery()
        .Select(AccountField.Name)));

await foreach (Person person in client.StreamAsync(query))
{

}
```

#### Select All Fields

`SelectAll()` should only be used for debugging purposes as it may include fields that are not yet available in production and can negatively impact performance. It's recommended to only select the necessary fields.

```csharp
PersonQuery query = new PersonQuery().SelectAll();

IReadOnlyCollection<Person> people = await client.GetAsync(query);
```

#### Views

The `View` argument can be specified at any level within a query, but only the value provided on the top-level query is considered.

```csharp
PersonQuery query = new PersonQuery().View(PersonView.All);

IReadOnlyCollection<Person> people = await client.GetAsync(query);
```

#### Nested Queries and ItemsPerRequest

The default and maximum number of items per request for any connection is 100. The maximum total number of items that can be returned in a single request across all connections is 500,000.

When querying nested data — for example, 100 organizations with 100 people and 100 configuration items each — the total number of items (100 × 100 × 100 = 1,000,000) exceeds this limit. To avoid exceeding the 500,000 item maximum, it is important to explicitly specify the number of items per request for each connection using `.ItemsPerRequest()`.

```csharp
OrganizationQuery query = new OrganizationQuery()
    .Select(OrganizationField.Name)
    .ItemsPerRequest(50)
    .SelectPeople(new PersonQuery()
        .Select(PersonField.Name)
        .SelectConfigurationItems(new ConfigurationItemQuery()
            .Select(ConfigurationItemField.Label, ConfigurationItemField.Name)));

client.MaximumConnectionDepth = 3;
IReadOnlyCollection<Organization> organizations = await client.GetAsync(query);
```

The default maximum depth for nested queries is 2. While this can be increased using `MaximumConnectionDepth`, higher values may negatively impact performance, especially when items per request are applied to deeply nested connections that require pagination.

#### Controlling Maximum Requests for Large Result Sets

The maximum number of consecutive requests the SDK will make when retrieving large datasets is defined on the client using `MaximumRequestsPerQuery`.
This property limits how many follow-up requests the client will automatically perform to retrieve additional items for top-level queries. The default value is 1000.

```csharp
XurrentClient client = new(token, "account-id", EnvironmentType.Demo, EnvironmentRegion.EU)
{
    MaximumRequestsPerQuery = 500
};


PersonQuery query = new PersonQuery()
    .View(PersonView.All);

IReadOnlyCollection<Person> people = await client.GetAsync(query);
```

In most cases, the default value is sufficient. However, when working with very large datasets or when API rate limits (such as 3600 requests per hour per token) are a concern, lowering this setting can help control request volumes.

### Filtering

There are four methods for filtering: `Where`, `WithId`, `CustomFilter`, and `Search`.
While technically `Where` and `WithId` can be specified at any level within a query, only the value provided on the top-level query is considered.

#### Where Filters
The `Where` method allows you to specify field filters at the top level of the query.
You define the field, the operator (e.g., equals, not equals), and the value(s) to match against.
When multiple values are provided for a single filter, they are combined using a logical **OR**. When multiple `.Where()` calls are used, the filters are combined using a logical **AND**.

```csharp
PersonQuery query = new PersonQuery()
    .Where(PersonFilterField.Name, FilterOperator.Equals, "Howard", "James")
    .Where(PersonFilterField.Billable, FilterOperator.Equals, true)
    .Where(PersonFilterField.CreatedAt, FilterOperator.GreaterThan, new DateTime(2012, 1, 1));

```

In this example:
- The `Name` field matches **Howard OR James**
- The `Billable` field must be `true`
- The `CreatedAt` date must be after January 1st, 2012

All `.Where()` calls are combined using **AND**, meaning all conditions must be satisfied for a record to be returned.

#### Filter by Identifier

The `WithId()` method allows you to search for an object by its unique identifier.
When using `WithId()` on the top-level query, any additional filters or view selections applied to that query are ignored. This ensures a highly optimized, direct lookup.

It is recommended to use `WithId()` instead of `.Where(PersonFilter.Id, FilterOperator.Equals, ...)` for ID-based queries, as it typically improves response times by approximately 15%.

```csharp
PersonQuery query = new PersonQuery().WithId("NG1lLnFhL1blcnNvbi8yMjMxSjIx");
```

#### Custom Filters

The `CustomFilter` method allows you to filter by custom fields that have been marked as "Filterable" in their UI Extension.

```csharp
PersonQuery query = new PersonQuery()
    .CustomFilter("Age", FilterOperator.NotEquals, [null]);
```

In this example, a custom filter named `Age` excludes records where the value is `null`.

#### Search Filters

The `Search` method applies the same quick-search filter functionality available in the top screen of the Xurrent user interface (UI).

```csharp
PersonQuery query = new PersonQuery().Search("Howard Tanner");
```
This performs a broad, UI-like search based on the provided value.

### Sorting

```csharp
PersonQuery query = new PersonQuery().OrderBy(PersonOrderField.Name, SortOrder.Ascending);
```

Sorting can only be applied to the top-level query. The `SortOrder` specifies ascending or descending order.

### Nested Query with Filtering and Sorting

This example builds a deeply nested query with filtering, sorting, and optimized item retrieval for each connection using `.ItemsPerRequest()`.

It filters people by creation date, sorts by the `Vip` field, and selects related data including contacts, permissions, teams, configuration items, and requests, each with their own selected fields and controlled number of items per request.

The `MaximumConnectionDepth` is set to 3 to support the required nesting.

Results are processed item by item using `StreamAsync` for efficient handling of large datasets.

```csharp
PersonQuery query = new PersonQuery()
    .View(PersonView.All)
    .OrderBy(PersonOrderField.Vip, SortOrder.Ascending)
    .Where(PersonFilterField.CreatedAt, FilterOperator.GreaterThanOrEqualsTo, new DateTime(2020, 1, 1))
    .SelectContacts(new ContactQuery()
        .SelectAll())
    .SelectPermissions(new PermissionQuery()
        .ItemsPerRequest(10)
        .Select(PermissionField.Account, PermissionField.Roles))
    .SelectTeams(new TeamQuery()
        .ItemsPerRequest(10)
        .SelectConfigurationManager(new PersonQuery()
            .Select(PersonField.Name, PersonField.EmployeeID)))
    .SelectConfigurationItems(new ConfigurationItemQuery()
        .Select(ConfigurationItemField.Label)
        .ItemsPerRequest(10)
        .SelectRequests(new RequestQuery()
            .ItemsPerRequest(10)
            .Select(RequestField.Subject, RequestField.Supplier))
    .SelectRequests(new RequestQuery()
        .ItemsPerRequest(10)
        .Select(RequestField.Id, RequestField.RequestId, RequestField.Subject)));

client.MaximumConnectionDepth = 3;

await foreach (Person people in client.StreamAsync(query))
{
    Console.WriteLine(people.Count);
}
```

### Interface-Based Properties

Some properties in the Xurrent GraphQL API return interface-based objects, meaning the underlying type can vary depending on the data.

The SDK provides two convenient approaches for selecting these types when building your query, `.Select{Name}()` and `.Select{Name}All()`.

#### Select()

Use `.Select{Name}()` to explicitly specify which types and fields to include in the response for the interface-based property `{Name}`.

If you don't select a type using this method, objects of that type will be returned as `null`.


##### Example

```csharp
TrashQuery query = new TrashQuery()
    .Select(TrashField.Id)
    .SelectTrashed(new PersonQuery().Select(PersonField.Id, PersonField.Name))
    .SelectTrashed(new RequestQuery().Select(RequestField.Id, RequestField.Subject));

ReadOnlyDataCollection<Trash> trash = await client.GetAsync(query);
```

In this example:
- Only trashed `Person` and `Request` objects will be populated.
- Other types supported by the `Trashed` property will be returned as `null`.

#### SelectAll()

The `.Select{Name}All()` method allows you to easily include all supported types for the `{Name}` property in your query.

For each supported type:
- You can optionally provide a sub-query to control which fields are included.
- If no sub-query is provided for a type, the SDK applies the default field selection.

##### Example

```csharp
TrashQuery query = new TrashQuery()
    .Select(TrashField.Id)
    .SelectTrashedAll(
        personQuery: new PersonQuery().Select(PersonField.Id, PersonField.Name),
        requestQuery: new RequestQuery().Select(RequestField.Id, RequestField.Subject)
    );

ReadOnlyDataCollection<Trash> trash = await client.GetAsync(query);
```

In this example:
- The `Trashed` property will return all supported types.
- For `Person` and `Request` objects, only the specified fields are included.
- For all other types, the default set of fields is automatically included.

This provides an easy way to retrieve the complete set of supported types without manually specifying queries for each one, while still allowing field-level control where needed.

## Mutations

Note: All mutation examples assume the following namespaces are included:
```csharp
using Works4me.Xurrent.GraphQL;
using Works4me.Xurrent.GraphQL.Mutations;
```

### Create a New Person and Return the Identifier

This example demonstrates how to create a new person using the `PersonCreateInput` class.
Standard fields like `Name`, `PrimaryEmail`, `OrganizationId`, and `EmployeeID` are provided, along with time zone settings and custom fields.

The mutation uses a `PersonQuery` to specify the fields to return, in this case, the new person's identifier. Errors are handled using a `try/catch` block.

```csharp
PersonCreateInput input = new()
{
    Name = "John Smith",
    PrimaryEmail = "john.smith@company.com",
    EmployeeID = "123",
    OrganizationId = "NG1lLnFhL1blanNvbk8zMjMkSjIv",
    TimeFormat24h = true,
    TimeZone = "Brussels",
    DoNotTranslateLanguages = ["en", "nl"],
    CustomFields =
    [
        new CustomField() { Id = "hire_date", Value = DateTime.Now.ToJsonElement() },
        new CustomField() { Id = "employee_reference", Value = "internal employee reference".ToJsonElement() }
    ]
};

PersonQuery response = new PersonQuery()
    .Select(PersonField.Id, PersonField.CustomFields);

try
{
    PersonCreatePayload result = await client.MutationAsync(input, response);

    DateTime? hireDate = result.Person?.CustomFields?["hire_date"].Value.GetValue<DateTime>();
}
catch (XurrentExecutionException ex)
{ 
}
```

Custom fields are supplied using the `CustomField` type, where the `Value` property accepts a `JsonObject`.
To simplify working with common types, the SDK provides extension methods such as `.ToJsonElement()` and `.GetValue<T>()`.

These methods require:

```csharp
using Works4me.Xurrent.GraphQL.Extensions;
```

### Updating an Existing Person

This example demonstrates how to update an existing person using the `PersonUpdateInput` class.
The record is identified by its unique `Id`, and specific fields such as `Name`, `PrimaryEmail`, and a custom field are updated.

A corresponding `PersonQuery` defines the fields to return after the update, including the person's identifier and custom fields.
The example shows how to retrieve a custom field value using `.GetValue<T>()`.

Errors are handled with a `try/catch` block for `XurrentExecutionException`.


```csharp
PersonUpdateInput input = new()
{
    Id = "NG1lLnFhL1blcnNvbi8yMjMxSjIx",
    Name = "John Doe",
    PrimaryEmail = "john.doe@company.com",
    CustomFields =
    [
        new CustomField() { Id = "employee_reference", Value = "a new reference".ToJsonElement() }
    ]
};

PersonQuery response = new PersonQuery()
    .Select(PersonField.Id, PersonField.CustomFields);

try
{
    PersonUpdatePayload result = await client.MutationAsync(input, response);

    DateTime? hireDate = result.Person?.CustomFields?["hire_date"].Value.GetValue<DateTime>();
    string? employeeReference = result.Person?.CustomFields?["employee_reference"].Value.GetValue<string>();
}
catch (XurrentExecutionException ex)
{
}
```

## Attachments

### Add a Note with Attachment to a Request

This example shows how to add a note with an attachment to a request.

```csharp
AttachmentUploadResponse attachment = await client.UploadAttachmentAsync(@"summary.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
NoteCreateInput input = new()
{
    Text = $"I added the latest summary to the request.",
    OwnerId = "NG1lLnFhL1nNvb4MjMxSjIx",
    Attachments = [new() { Inline = false, Key = attachment.Key, Size = attachment.Size }]
};
            
try
{
    NoteCreatePayload response = await client.MutationAsync(input, new NoteQuery().Select(NoteField.Internal));
}
catch (XurrentExecutionException ex)
{

}
```

When uploading an attachment using the `UploadAttachmentAsync` method, you receive a `key` and `size` as part of the response.
The `key` is required, as it uniquely identifies the uploaded file. The `size` is optional but recommended for completeness when referencing the file.

### Add an Inline Attachment to the Person Information Field

This example demonstrates how to add an embedded or inline attachment.

```csharp
AttachmentUploadResponse attachment = await client.UploadAttachmentAsync(@"happy_friday.png", "image/png");
PersonUpdateInput input = new PersonUpdateInput()
{
    Id = "NG1lLnFhL1blcnNvbi8yMjMxSjIx",
    Information = $"Happy Friday\n![]({attachment.Key})"
};
            
try
{
    PersonUpdatePayload response = await client.MutationAsync(
        input,
        new PersonQuery()
            .Select(PersonField.Id, PersonField.Information)
            .SelectInformationAttachments(new AttachmentQuery()));
}
catch (XurrentExecutionException ex)
{

}
```

## Create a New Event via the Events API

This example creates a new request using the Xurrent Events REST API.

```csharp
RequestEventCreateInput requestCreate = new RequestEventCreateInput()
    .Category(RequestCategory.Incident)
    .Note("An event note")
    .Subject("SDK Test")
    .Source("Works4me.Xurrent.GraphQL")
    .SourceID("1")
    .ServiceInstance(120262)
    .Impact(RequestImpact.Medium)
    .ConfigurationItem(4801722)
    .Team(17544);

try
{
    Request request = await client.CreateEventAsync(requestCreate);
}
catch (XurrentException ex)
{
}
```

Note that the Xurrent Events API operates as a REST API, not GraphQL, and requires REST object identifiers (numeric IDs), as shown in the example.
The response will only include the request identifier and request number, which are available on the returned `Request` object.

## Bulk Import and Export

The Bulk API allows you to export data to CSV and Excel files, and import data from CSV files.

### Excel Export

This example demonstrates how to start an export of changed configuration items, people, and requests from the last 10 days.
The code waits for the export to complete, using a polling interval of 10 seconds and a timeout of 10 minutes. Once complete, it outputs the download URL for the exported file.

```csharp
CancellationTokenSource ct = new CancellationTokenSource(TimeSpan.FromMinutes(10));

string token = await client.Bulk.StartExcelExportAsync(["cis", "people", "requests"], DateTime.Now.AddDays(-10));
BulkExportResponse result = await client.Bulk.AwaitExportAsync(token, TimeSpan.FromSeconds(10), ct.Token);
            
Console.WriteLine(result.Url);
```

### CSV Export

This example shows how to export changed tasks from the last 15 days to a CSV file.
The code waits for completion, polling every 10 seconds with a timeout of 10 minutes, and saves the result as `tasks.csv`.

For more information, see the [Xurrent Developer Pages](https://developer.xurrent.com/v1/bulk/).


```csharp
CancellationTokenSource ct = new(TimeSpan.FromMinutes(10));

string token = await client.Bulk.StartCsvExportAsync(["tasks"], ExportLineSeparator.LineFeed, DateTime.Now.AddDays(15), ct.Token);
await client.Bulk.AwaitDownloadAndSaveAsync(@".\tasks.csv", token, TimeSpan.FromSeconds(10), ct.Token);
```

### CSV Import

This example demonstrates how to import data from a CSV file.
The code starts the import, waits for completion with a polling interval of 15 seconds and a timeout of 5 minutes, and then prints the results.

```csharp
CancellationTokenSource ct = new(TimeSpan.FromMinutes(5));

string token = await client.Bulk.StartImportAsync("new_cis.csv", "cis", ct.Token);
BulkImportResponse response = await client.Bulk.AwaitImportAsync(token, TimeSpan.FromSeconds(15), ct.Token);
if (response.State == ImportExportStatus.Done)
{
    Console.WriteLine($"  Created: {response.Results.Created}");
    Console.WriteLine($"   Update: {response.Results.Updated}");
    Console.WriteLine($"  Deleted: {response.Results.Deleted}");
    Console.WriteLine($" Failures: {response.Results.Failures}");
    Console.WriteLine($"Unchanged: {response.Results.Unchanged}");
}

```

## Exception Handling

The SDK defines three types of exceptions to help identify and handle different categories of errors:
- **XurrentException**: The base or generic exception for all SDK-related errors.
- **XurrentExecutionException**: Inherits from `XurrentException` and is thrown when an error occurs during the execution of a GraphQL API request. The exception typically contains details from the GraphQL response, when available.
- **XurrentQueryException**: Inherits from `XurrentException` and is thrown when a query is incorrectly constructed. This occurs at runtime when the SDK detects invalid query configuration, even though the SDK provides strong typing.

### Example: Invalid Item Per Request

The following example will throw an exception because the `ItemsPerRequest` exceeds the allowed maximum of 100.

```csharp
try
{
    PersonQuery query = new PersonQuery()
        .ItemsPerRequest(1000000);

    ReadOnlyDataCollection<Person> result = await client.GetAsync(query);
}
catch (XurrentQueryException ex)
{
    Console.Write(ex.Message);
}
```

The exception message.

```
Invalid item per request: 1000000. ItemsPerRequest must be between 1 and 100 inclusive.
```

## Client Behavior Examples

### Multiple Authentication Tokens

When using multiple Xurrent authentication tokens, the SDK automatically selects the token with the highest combined score based on two factors:

- Remaining API Requests
- Remaining Query Cost Points

```
score = (remaining requests percentage × RequestWeight) + (remaining cost percentage × CostWeight)
```

By default, RequestWeight is set to 0.6 and CostWeight to 0.4, meaning tokens with more remaining API requests are prioritized slightly over tokens with more remaining cost points.

These weights are user-configurable, allowing fine-tuning based on your application's needs. Increasing RequestWeight favors tokens with more available requests, while increasing CostWeight prioritizes tokens with higher remaining query cost limits.

#### Token Weight Constraints

When configuring token weights with `ConfigureTokenWeight`, the following rules apply:
- Both `requestWeight` and `costWeight` must be between 0.0 and 1.0, inclusive.
- The sum of both weights must equal exactly 1.0.
- If these conditions are not met, the method will throw an `ArgumentOutOfRangeException`.

This ensures the token scoring system remains balanced and mathematically valid.

#### Example: Configuring Token Weights

```csharp
AuthenticationTokenCollection tokens = 
[
    new ("TestPersonalAccessToken"),
    new ("App1_ClientId", "App1_ClientSecret"),
    new ("App2_ClientId", "App2_ClientSecret")
];
tokens.ConfigureTokenWeight(requestWeight: 0.5, costWeight: 0.5);

XurrentClient xurrentClient = new(tokens, "account-id", EnvironmentType.Quality, EnvironmentRegion.EU);
```

In this example, the importance of remaining requests and remaining cost is weighted equally when selecting the optimal token for API requests.

### Rate and Cost Limits Values

Below is a quick code snippet showing how to fetch and print the current rate- and cost-limit values on an `AuthenticationToken`.

```csharp
AuthenticationToken token = new("My Personal Access Token");

Console.WriteLine("Request limits");
Console.WriteLine($"  Limit     : {token.RequestLimit.Limit}");
Console.WriteLine($"  Remaining : {token.RequestLimit.Remaining}");
Console.WriteLine($"  Reset     : {token.RequestLimit.Reset:f}");

Console.WriteLine("Cost limits");
Console.WriteLine($"  Limit     : {token.CostLimit.Limit}");
Console.WriteLine($"  Remaining : {token.CostLimit.Remaining}");
Console.WriteLine($"  Reset     : {token.CostLimit.Reset:f}");
```

### Log Output

The SDK emits structured trace data for each request and response using `ILogger`. Each log entry is represented as a `XurrentTraceMessage` object, available under `Works4me.Xurrent.GraphQL`.

Each request results in two log entries sharing the same ID:
- One for the HTTP request (method, URI, payload, etc.).
- One for the HTTP response (status code, response time, and optional retry delay).

- Example output:

```
{"id":"62733dd0-8f65-415e-bfff-1b20b7b19be5","method":"POST","uri":"https://oauth.xurrent.qa/token","content":"***"}
{"id":"62733dd0-8f65-415e-bfff-1b20b7b19be5","response_code":200,"response_time_in_ms":346}

{"id":"e5c5984a-c680-475f-a8c9-d1d234c459e1","method":"POST","uri":"https://graphql.xurrent.qa","content":"{\"query\":\"query {people(first:30 view: all){nodes{id name} pageInfo{endCursor hasNextPage}}}\"}","account_id":"account-id"}
{"id":"e5c5984a-c680-475f-a8c9-d1d234c459e1","response_code":200,"response_time_in_ms":167}

{"id":"569bb2de-c67f-4483-b9a5-85a37164362d","method":"POST","uri":"https://graphql.xurrent.qa","content":"{\"query\":\"query {people(first:30 after: \\"eyJvZmZzZXQiOjI5LCJjdXJzb3IiOlsxNjc2MjgzODMyMDAwLDMyMjY2NzZdfQ\\" view: all){nodes{id name} pageInfo{endCursor hasNextPage}}}\"}","account_id":"account-id"}
{"id":"569bb2de-c67f-4483-b9a5-85a37164362d","response_code":200,"response_time_in_ms":101}
```

#### Minimal Console Logger Example

To display log entries as raw JSON in the console, configure a basic logger:

```csharp
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Works4me.Xurrent.GraphQL;

using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder.ClearProviders();
    builder.SetMinimumLevel(LogLevel.Information);
    builder.AddProvider(new JsonConsoleLoggerProvider());
});
ILogger<XurrentClient> logger = loggerFactory.CreateLogger<XurrentClient>();

AuthenticationToken token = new("ClientId", "ClientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Demo, EnvironmentRegion.EU, logger);
```

And define the logger implementation:

```csharp
using Works4me.Xurrent.GraphQL;

internal class JsonConsoleLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName) => new JsonConsoleLogger();
    public void Dispose() { }
}

internal class JsonConsoleLogger : ILogger
{
    private readonly JsonSerializerOptions _traceSerializationOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = false };

    public bool IsEnabled(LogLevel logLevel) => true;

    IDisposable ILogger.BeginScope<TState>(TState state) => default!;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (state is IReadOnlyList<KeyValuePair<string, object?>> kvps)
        {
            foreach (KeyValuePair<string, object?> kv in kvps)
            {
                if (kv.Key == "@Trace" && kv.Value is XurrentTraceMessage msg)
                {
                    if (msg.ResponseCode is not null)
                    {
                        Console.WriteLine($"Response ID   : {msg.Id}");
                        Console.WriteLine($"Response      : {msg.ResponseCode}");
                        Console.WriteLine($"Response Time : {msg.ResponseTimeInMilliseconds}ms");
                        Console.WriteLine($"Retry After   : {msg.RetryAfterInMilliseconds ?? 0}ms");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Request ID    : {msg.Id}");
                        Console.WriteLine($"Method        : {msg.Method}");
                        Console.WriteLine($"URI           : {msg.Uri}");
                        Console.WriteLine($"Account       : {msg.AccountId}");
                        Console.WriteLine($"Content       : {msg.Content}");
                        Console.WriteLine();
                    }
                    return;
                }
            }
        }

        Console.WriteLine(formatter(state, exception));

        if (exception is not null)
            Console.WriteLine(exception);
    }
}

```

> The `@Trace` key is a special syntax used by `Microsoft.Extensions.Logging` to indicate structured logging.
>
> When you log an object using a message template like `{@Trace}`, the logger serializes the full contents of the object instead of just calling `.ToString()`.
>
> This makes individual properties available to structured log providers such as Serilog, Seq, or Application Insights, enabling advanced filtering, searching, and indexing.
