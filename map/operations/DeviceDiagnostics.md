<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceDiagnostics — operations

Accessor: `client.DeviceDiagnostics` · Source: `src/Verizon/Api/DeviceDiagnostics.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceReachabilityStatusUsingPost

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceReachabilityStatusUsingPost(DeviceReachabilityStatusUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<DeviceReachabilityStatusUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceReachabilityStatusUsingPostRequest` | `src/Verizon/Requests/DeviceDiagnostics/DeviceReachabilityStatusUsingPostRequest.cs` |
| `NotificationReportStatusRequest` | `src/Verizon/Models/NotificationReportStatusRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `DeviceReachabilityStatusUsingPostError` | `src/Verizon/Errors/DeviceReachabilityStatusUsingPostError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### RetrieveActiveMonitorsUsingPost

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveActiveMonitorsUsingPost(RetrieveActiveMonitorsUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<RetrieveActiveMonitorsUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveActiveMonitorsUsingPostRequest` | `src/Verizon/Requests/DeviceDiagnostics/RetrieveActiveMonitorsUsingPostRequest.cs` |
| `RetrieveMonitorsRequest` | `src/Verizon/Models/RetrieveMonitorsRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `RetrieveActiveMonitorsUsingPostError` | `src/Verizon/Errors/RetrieveActiveMonitorsUsingPostError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

