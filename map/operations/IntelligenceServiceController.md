<!-- Generated file — do not edit; regenerated with the SDK. -->

# IntelligenceServiceController — operations

Accessor: `client.IntelligenceServiceController` · Source: `src/Verizon/Api/IntelligenceServiceController.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SetConnectionPlanner

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SetConnectionPlanner(SetConnectionPlannerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AsynchronousRequestResultforplanner`
- **Error**: `ApiException<SetConnectionPlannerError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner)` [400, 403, 404, 406, 429] · `TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetConnectionPlannerRequest` | `src/Verizon/Requests/IntelligenceServiceController/SetConnectionPlannerRequest.cs` |
| `GetDevicesWindowsRequestforplanner` | `src/Verizon/Models/GetDevicesWindowsRequestforplanner.cs` |
| `AsynchronousRequestResultforplanner` | `src/Verizon/Models/AsynchronousRequestResultforplanner.cs` |
| `SetConnectionPlannerError` | `src/Verizon/Errors/SetConnectionPlannerError.cs` |
| `RestErrorResponseforplanner` | `src/Verizon/Models/RestErrorResponseforplanner.cs` |
| `AuthRestErrorResponseforplanner` | `src/Verizon/Models/AuthRestErrorResponseforplanner.cs` |

### StatusConnectionPlanner

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StatusConnectionPlanner(StatusConnectionPlannerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetDeviceStatusesResponseforplanner`
- **Error**: `ApiException<StatusConnectionPlannerError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner)` [400, 403, 404, 406, 429] · `TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `StatusConnectionPlannerRequest` | `src/Verizon/Requests/IntelligenceServiceController/StatusConnectionPlannerRequest.cs` |
| `GetDeviceStatusesRequestforplanner` | `src/Verizon/Models/GetDeviceStatusesRequestforplanner.cs` |
| `GetDeviceStatusesResponseforplanner` | `src/Verizon/Models/GetDeviceStatusesResponseforplanner.cs` |
| `StatusConnectionPlannerError` | `src/Verizon/Errors/StatusConnectionPlannerError.cs` |
| `RestErrorResponseforplanner` | `src/Verizon/Models/RestErrorResponseforplanner.cs` |
| `AuthRestErrorResponseforplanner` | `src/Verizon/Models/AuthRestErrorResponseforplanner.cs` |

