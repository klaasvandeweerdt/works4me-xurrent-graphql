# Xurrent GraphQL .NET SDK

This SDK simplifies integration with the Xurrent GraphQL API by abstracting HTTP request construction, JSON serialization/deserialization, and connection data retrieval.
It exposes a set of fluent, strongly-typed query and mutation classes so you can build complex GraphQL operations with minimal boilerplate.
Under the covers, it manages rate-limit compliance, token renewal, and optimized handling of large result sets, letting you focus on application logic and business requirements.

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


## Getting Started

### Query Example

```csharp
using Works4me.Xurrent.GraphQL;

AuthenticationToken token = new("ClientId", "ClientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Demo, EnvironmentRegion.EU);

PersonQuery query = new PersonQuery()
    .Select(PersonField.Id, PersonField.Name, PersonField.PrimaryEmail)
    .SelectOrganization(new OrganizationQuery()
        .Select(OrganizationField.Id, OrganizationField.Name, OrganizationField.Disabled)
    .SelectAccount(new AccountQuery()
        .Select(AccountField.Name)));

IReadOnlyCollection<Person> people = await client.GetAsync(query);
```

### Mutation Example

```csharp
using Works4me.Xurrent.GraphQL;
using Works4me.Xurrent.GraphQL.Mutations;

AuthenticationToken token = new("ClientId", "ClientSecret");
XurrentClient client = new(token, "account-id", EnvironmentType.Demo, EnvironmentRegion.EU);

PersonCreateInput input = new()
{
    Name = "John Smith",
    PrimaryEmail = "john.smith@company.com",
    EmployeeID = "123",
    OrganizationId = "NG1lLnFhL1blanNvbk8zMjMkSjIv",
    TimeFormat24h = true,
    TimeZone = "Brussels",
    DoNotTranslateLanguages = ["en", "nl"]
};

PersonQuery response = new PersonQuery()
    .Select(PersonField.Id);

try
{
    PersonCreatePayload result = await client.MutationAsync(input, response);
}
catch (XurrentExecutionException ex)
{ 
}
```

## Documentation

For detailed usage, please refer to the following resources:
- Full [Xurrent GraphQL API Documentation](https://developer.xurrent.com/graphql).
- Additional examples and usage details in the [GitHub README](https://github.com/klaasvandeweerdt/works4me-xurrent-graphql).
