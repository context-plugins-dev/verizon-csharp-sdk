<!-- Generated file — do not edit; regenerated with the SDK. -->

# Accounts — operations

Accessor: `client.Accounts` · Source: `src/Verizon/Api/Accounts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountInformation(GetAccountInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `Account`
- **Error**: `ApiException<GetAccountInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountInformationRequest` | `src/Verizon/Requests/Accounts/GetAccountInformationRequest.cs` |
| `Account` | `src/Verizon/Models/Account.cs` |
| `GetAccountInformationError` | `src/Verizon/Errors/GetAccountInformationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListAccountLeads

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountLeads(ListAccountLeadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Query params (wire ← C#)**: `next` ← `Next`
- **Returns**: `AccountLeadsResult`
- **Error**: `ApiException<ListAccountLeadsError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountLeadsRequest` | `src/Verizon/Requests/Accounts/ListAccountLeadsRequest.cs` |
| `AccountLeadsResult` | `src/Verizon/Models/AccountLeadsResult.cs` |
| `ListAccountLeadsError` | `src/Verizon/Errors/ListAccountLeadsError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListAccountStatesAndServices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountStatesAndServices(ListAccountStatesAndServicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `AccountStatesAndServices`
- **Error**: `ApiException<ListAccountStatesAndServicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountStatesAndServicesRequest` | `src/Verizon/Requests/Accounts/ListAccountStatesAndServicesRequest.cs` |
| `AccountStatesAndServices` | `src/Verizon/Models/AccountStatesAndServices.cs` |
| `ListAccountStatesAndServicesError` | `src/Verizon/Errors/ListAccountStatesAndServicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

