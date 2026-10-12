<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsSensors — operations

Accessor: `client.SensorInsightsSensors` · Source: `src/Verizon/Api/SensorInsightsSensors.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsListSensorDevicesRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListSensorDevicesRequest(SensorInsightsListSensorDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<ResourceDevice>`
- **Error**: `ApiException<SensorInsightsListSensorDevicesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListSensorDevicesRequest` | `src/Verizon/Requests/SensorInsightsSensors/SensorInsightsListSensorDevicesRequest.cs` |
| `DtoListSensorDevicesRequest` | `src/Verizon/Models/DtoListSensorDevicesRequest.cs` |
| `ResourceDevice` | `src/Verizon/Models/ResourceDevice.cs` |
| `SensorInsightsListSensorDevicesRequestError` | `src/Verizon/Errors/SensorInsightsListSensorDevicesRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsOffBoardSensorRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsOffBoardSensorRequest(SensorInsightsOffBoardSensorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SensorInsightsOffBoardSensorRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsOffBoardSensorRequest` | `src/Verizon/Requests/SensorInsightsSensors/SensorInsightsOffBoardSensorRequest.cs` |
| `DtoOffBoardSensorRequest` | `src/Verizon/Models/DtoOffBoardSensorRequest.cs` |
| `SensorInsightsOffBoardSensorRequestError` | `src/Verizon/Errors/SensorInsightsOffBoardSensorRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |

### SensorInsightsOnBoardSensorRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsOnBoardSensorRequest(SensorInsightsOnBoardSensorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SensorInsightsOnBoardSensorRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsOnBoardSensorRequest` | `src/Verizon/Requests/SensorInsightsSensors/SensorInsightsOnBoardSensorRequest.cs` |
| `DtoOnBoardSensorRequest` | `src/Verizon/Models/DtoOnBoardSensorRequest.cs` |
| `SensorInsightsOnBoardSensorRequestError` | `src/Verizon/Errors/SensorInsightsOnBoardSensorRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsSensorOffBoardingStatusRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsSensorOffBoardingStatusRequest(SensorInsightsSensorOffBoardingStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoSensorOffBoardingStatusResponse`
- **Error**: `ApiException<SensorInsightsSensorOffBoardingStatusRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsSensorOffBoardingStatusRequest` | `src/Verizon/Requests/SensorInsightsSensors/SensorInsightsSensorOffBoardingStatusRequest.cs` |
| `DtoSensorOffBoardStatusRequest` | `src/Verizon/Models/DtoSensorOffBoardStatusRequest.cs` |
| `DtoSensorOffBoardingStatusResponse` | `src/Verizon/Models/DtoSensorOffBoardingStatusResponse.cs` |
| `SensorInsightsSensorOffBoardingStatusRequestError` | `src/Verizon/Errors/SensorInsightsSensorOffBoardingStatusRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsSensorOnBoardStatusRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsSensorOnBoardStatusRequest(SensorInsightsSensorOnBoardStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoSensorOnBoardingStatusResponse`
- **Error**: `ApiException<SensorInsightsSensorOnBoardStatusRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsSensorOnBoardStatusRequest` | `src/Verizon/Requests/SensorInsightsSensors/SensorInsightsSensorOnBoardStatusRequest.cs` |
| `DtoSensorOnBoardStatusRequest` | `src/Verizon/Models/DtoSensorOnBoardStatusRequest.cs` |
| `DtoSensorOnBoardingStatusResponse` | `src/Verizon/Models/DtoSensorOnBoardingStatusResponse.cs` |
| `SensorInsightsSensorOnBoardStatusRequestError` | `src/Verizon/Errors/SensorInsightsSensorOnBoardStatusRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

