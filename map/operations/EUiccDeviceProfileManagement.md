<!-- Generated file — do not edit; regenerated with the SDK. -->

# EUiccDeviceProfileManagement — operations

Accessor: `client.EUiccDeviceProfileManagement` · Source: `src/Verizon/Api/EUiccDeviceProfileManagement.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteLocalProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteLocalProfile(DeleteLocalProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<DeleteLocalProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLocalProfileRequest` | `src/Verizon/Requests/EUiccDeviceProfileManagement/DeleteLocalProfileRequest.cs` |
| `ProfileChangeStateRequest` | `src/Verizon/Models/ProfileChangeStateRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `DeleteLocalProfileError` | `src/Verizon/Errors/DeleteLocalProfileError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### DisableLocalProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DisableLocalProfile(DisableLocalProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<DisableLocalProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableLocalProfileRequest` | `src/Verizon/Requests/EUiccDeviceProfileManagement/DisableLocalProfileRequest.cs` |
| `ProfileChangeStateRequest` | `src/Verizon/Models/ProfileChangeStateRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `DisableLocalProfileError` | `src/Verizon/Errors/DisableLocalProfileError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### DownloadLocalProfileToDisable

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DownloadLocalProfileToDisable(DownloadLocalProfileToDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<DownloadLocalProfileToDisableError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadLocalProfileToDisableRequest` | `src/Verizon/Requests/EUiccDeviceProfileManagement/DownloadLocalProfileToDisableRequest.cs` |
| `ProfileChangeStateRequest` | `src/Verizon/Models/ProfileChangeStateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `DownloadLocalProfileToDisableError` | `src/Verizon/Errors/DownloadLocalProfileToDisableError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### DownloadLocalProfileToEnable

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DownloadLocalProfileToEnable(DownloadLocalProfileToEnableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<DownloadLocalProfileToEnableError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadLocalProfileToEnableRequest` | `src/Verizon/Requests/EUiccDeviceProfileManagement/DownloadLocalProfileToEnableRequest.cs` |
| `ProfileChangeStateRequest` | `src/Verizon/Models/ProfileChangeStateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `DownloadLocalProfileToEnableError` | `src/Verizon/Errors/DownloadLocalProfileToEnableError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### EnableLocalProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `EnableLocalProfile(EnableLocalProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<EnableLocalProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableLocalProfileRequest` | `src/Verizon/Requests/EUiccDeviceProfileManagement/EnableLocalProfileRequest.cs` |
| `ProfileChangeStateRequest` | `src/Verizon/Models/ProfileChangeStateRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `EnableLocalProfileError` | `src/Verizon/Errors/EnableLocalProfileError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

