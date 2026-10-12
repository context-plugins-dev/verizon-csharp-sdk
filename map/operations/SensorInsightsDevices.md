<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsDevices — operations

Accessor: `client.SensorInsightsDevices` · Source: `src/Verizon/Api/SensorInsightsDevices.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsDeviceActionSetRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsDeviceActionSetRequest(SensorInsightsDeviceActionSetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoDeviceActionSetResponse`
- **Error**: `ApiException<SensorInsightsDeviceActionSetRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsDeviceActionSetRequest` | `src/Verizon/Requests/SensorInsightsDevices/SensorInsightsDeviceActionSetRequest.cs` |
| `DmV1DevicesActionsSetRequest` | `src/Verizon/Models/AnyOf/DmV1DevicesActionsSetRequest.cs` |
| `DtoDeviceActionSetResponse` | `src/Verizon/Models/DtoDeviceActionSetResponse.cs` |
| `SensorInsightsDeviceActionSetRequestError` | `src/Verizon/Errors/SensorInsightsDeviceActionSetRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |

### SensorInsightsLastReportedTimeRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsLastReportedTimeRequest(SensorInsightsLastReportedTimeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoLastReportedTimeResponse`
- **Error**: `ApiException<SensorInsightsLastReportedTimeRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsLastReportedTimeRequest` | `src/Verizon/Requests/SensorInsightsDevices/SensorInsightsLastReportedTimeRequest.cs` |
| `DtoLastReportedTimeRequest` | `src/Verizon/Models/DtoLastReportedTimeRequest.cs` |
| `DtoLastReportedTimeResponse` | `src/Verizon/Models/DtoLastReportedTimeResponse.cs` |
| `SensorInsightsLastReportedTimeRequestError` | `src/Verizon/Errors/SensorInsightsLastReportedTimeRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |

### SensorInsightsListDeviceExperienceHistoryRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListDeviceExperienceHistoryRequest(SensorInsightsListDeviceExperienceHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<UserDeviceExperienceHistory>`
- **Error**: `ApiException<SensorInsightsListDeviceExperienceHistoryRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListDeviceExperienceHistoryRequest` | `src/Verizon/Requests/SensorInsightsDevices/SensorInsightsListDeviceExperienceHistoryRequest.cs` |
| `DtoListDeviceExperienceHistoryRequest` | `src/Verizon/Models/DtoListDeviceExperienceHistoryRequest.cs` |
| `UserDeviceExperienceHistory` | `src/Verizon/Models/UserDeviceExperienceHistory.cs` |
| `SensorInsightsListDeviceExperienceHistoryRequestError` | `src/Verizon/Errors/SensorInsightsListDeviceExperienceHistoryRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsListDevicesRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListDevicesRequest(SensorInsightsListDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DtoExpandedDeviceResponse>`
- **Error**: `ApiException<SensorInsightsListDevicesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError(out ManagementError)` [400, 401, 403, 404, 406, 415, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListDevicesRequest` | `src/Verizon/Requests/SensorInsightsDevices/SensorInsightsListDevicesRequest.cs` |
| `DtoListDevicesRequest` | `src/Verizon/Models/DtoListDevicesRequest.cs` |
| `DtoExpandedDeviceResponse` | `src/Verizon/Models/DtoExpandedDeviceResponse.cs` |
| `SensorInsightsListDevicesRequestError` | `src/Verizon/Errors/SensorInsightsListDevicesRequestError.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |

### SensorInsightsListNetworkExperienceHistoryRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListNetworkExperienceHistoryRequest(SensorInsightsListNetworkExperienceHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<UserNetworkExperienceHistory>`
- **Error**: `ApiException<SensorInsightsListNetworkExperienceHistoryRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListNetworkExperienceHistoryRequest` | `src/Verizon/Requests/SensorInsightsDevices/SensorInsightsListNetworkExperienceHistoryRequest.cs` |
| `DtoListNetworkExperienceHistoryRequest` | `src/Verizon/Models/DtoListNetworkExperienceHistoryRequest.cs` |
| `UserNetworkExperienceHistory` | `src/Verizon/Models/UserNetworkExperienceHistory.cs` |
| `SensorInsightsListNetworkExperienceHistoryRequestError` | `src/Verizon/Errors/SensorInsightsListNetworkExperienceHistoryRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsPatchDeviceRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsPatchDeviceRequest(SensorInsightsPatchDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ResourceDevice`
- **Error**: `ApiException<SensorInsightsPatchDeviceRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsPatchDeviceRequest` | `src/Verizon/Requests/SensorInsightsDevices/SensorInsightsPatchDeviceRequest.cs` |
| `DtoPatchDeviceRequest` | `src/Verizon/Models/DtoPatchDeviceRequest.cs` |
| `ResourceDevice` | `src/Verizon/Models/ResourceDevice.cs` |
| `SensorInsightsPatchDeviceRequestError` | `src/Verizon/Errors/SensorInsightsPatchDeviceRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

