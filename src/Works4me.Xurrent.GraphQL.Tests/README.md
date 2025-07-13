# Test Configuration

The test project uses the `secret.json` file to store configuration values required for integration tests. This file contains your Xurrent account credentials, OAuth2 client details, and object identifiers used by the tests. **All values must be strings**, even for numeric IDs.

```json
{
  "Account": "<your-account-id>",
  "Token": "<your-personal-access-token>",
  "ClientId": "<your-oauth-client-id>",
  "ClientSecret": "<your-oauth-client-secret>",
  "NoteTest.Id": "<note-identifier-for-Note-tests>",
  "CiTest.Id": "<configuration-item-identifier-for-configuration-item-tests>",
  "EventApi.ServiceInstance": "<numeric-service-instance-id>",
  "EventApi.ConfigurationItem": "<numeric-configuration-item-id>",
  "EventApi.Team": "<numeric-team-id>"
}
```

| Property                       | Description                                                                          |
|--------------------------------|--------------------------------------------------------------------------------------|
| **Account**                    | The Xurrent account identifier.                                                      |
| **Token**                      | Your personal access token (PAT).                                                    |
| **ClientId**                   | The OAuth2 client identifier.                                                        |
| **ClientSecret**               | The OAuth2 client secret.                                                            |
| **NoteTest.Id**                | The Note identifier used in the `Note` integration tests.                            |
| **CiTest.Id**                  | The Configuration item identifier used in the `ConfigurationItem` integration tests. |
| **EventApi.ServiceInstance**   | The numeric (REST API) service instance ID for `EventsApi` tests.                    |
| **EventApi.ConfigurationItem** | The numeric (REST API) configuration item ID for `EventsApi` tests.                  |
| **EventApi.Team**              | The numeric (REST API) team ID for `EventsApi` tests.                                |

> **Note:** The structure shown above matches exactly what the `.NET User-Secrets` system expects. You do not need to manually maintain a physical `secret.json` file if using User-Secrets.  
> You can provide **either a personal access token (Token)** or a **ClientId/ClientSecret** pair for authentication. Only one option is required; both are not needed.  
> **User-Secrets are intended for development/testing only** and are not deployed with your application.  
>
> You can manage these secrets via the .NET CLI (`dotnet user-secrets`) or through the **Manage User Secrets** option in Visual Studio or Visual Studio Code.  
> **Command line**: `dotnet user-secrets`  
> **Visual Studio**: Right-click project → **Manage User Secrets**
