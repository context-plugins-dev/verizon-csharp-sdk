<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceMonitoring — operations

Accessor: `client.DeviceMonitoring` · Source: `src/Verizon/Api/DeviceMonitoring.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceReachability

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceReachability(DeviceReachabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<DeviceReachabilityError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceReachabilityRequest` | `src/Verizon/Requests/DeviceMonitoring/DeviceReachabilityRequest.cs` |
| `NotificationReportRequest` | `src/Verizon/Models/NotificationReportRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `DeviceReachabilityError` | `src/Verizon/Errors/DeviceReachabilityError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### StopDeviceReachability

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StopDeviceReachability(StopDeviceReachabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Stopreachabilitypayload`
- **Query params (wire ← C#)**: `stopreachabilitypayload` ← `Stopreachabilitypayload`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<StopDeviceReachabilityError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `StopDeviceReachabilityRequest` | `src/Verizon/Requests/DeviceMonitoring/StopDeviceReachabilityRequest.cs` |
| `StopMonitorRequest` | `src/Verizon/Models/StopMonitorRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `StopDeviceReachabilityError` | `src/Verizon/Errors/StopDeviceReachabilityError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

