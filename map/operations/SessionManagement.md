<!-- Generated file — do not edit; regenerated with the SDK. -->

# SessionManagement — operations

Accessor: `client.SessionManagement` · Source: `src/Verizon/Api/SessionManagement.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EndConnectivityManagementSession

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `EndConnectivityManagementSession(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `LogOutRequest`
- **Error**: `ApiException<EndConnectivityManagementSessionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LogOutRequest` | `src/Verizon/Models/LogOutRequest.cs` |
| `EndConnectivityManagementSessionError` | `src/Verizon/Errors/EndConnectivityManagementSessionError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ResetConnectivityManagementPassword

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ResetConnectivityManagementPassword(ResetConnectivityManagementPasswordRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SessionResetPasswordResult`
- **Error**: `ApiException<ResetConnectivityManagementPasswordError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ResetConnectivityManagementPasswordRequest` | `src/Verizon/Requests/SessionManagement/ResetConnectivityManagementPasswordRequest.cs` |
| `SessionResetPasswordRequest` | `src/Verizon/Models/SessionResetPasswordRequest.cs` |
| `SessionResetPasswordResult` | `src/Verizon/Models/SessionResetPasswordResult.cs` |
| `ResetConnectivityManagementPasswordError` | `src/Verizon/Errors/ResetConnectivityManagementPasswordError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### StartConnectivityManagementSession

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth`
- **Signature**: `StartConnectivityManagementSession(StartConnectivityManagementSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `LogInResult`
- **Error**: `ApiException<StartConnectivityManagementSessionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `StartConnectivityManagementSessionRequest` | `src/Verizon/Requests/SessionManagement/StartConnectivityManagementSessionRequest.cs` |
| `LogInRequest` | `src/Verizon/Models/LogInRequest.cs` |
| `LogInResult` | `src/Verizon/Models/LogInResult.cs` |
| `StartConnectivityManagementSessionError` | `src/Verizon/Errors/StartConnectivityManagementSessionError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

