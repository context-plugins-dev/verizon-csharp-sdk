<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsSmartAlerts — operations

Accessor: `client.SensorInsightsSmartAlerts` · Source: `src/Verizon/Api/SensorInsightsSmartAlerts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsBulkUpdate

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsBulkUpdate(SensorInsightsBulkUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserSmartAlert`
- **Error**: `ApiException<SensorInsightsBulkUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsBulkUpdateRequest` | `src/Verizon/Requests/SensorInsightsSmartAlerts/SensorInsightsBulkUpdateRequest.cs` |
| `DtoBulkUpdate` | `src/Verizon/Models/DtoBulkUpdate.cs` |
| `UserSmartAlert` | `src/Verizon/Models/UserSmartAlert.cs` |
| `SensorInsightsBulkUpdateError` | `src/Verizon/Errors/SensorInsightsBulkUpdateError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsListSmartAlertsRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListSmartAlertsRequest(SensorInsightsListSmartAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<UserSmartAlert>`
- **Error**: `ApiException<SensorInsightsListSmartAlertsRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListSmartAlertsRequest` | `src/Verizon/Requests/SensorInsightsSmartAlerts/SensorInsightsListSmartAlertsRequest.cs` |
| `DtoListSmartAlertsRequest` | `src/Verizon/Models/DtoListSmartAlertsRequest.cs` |
| `UserSmartAlert` | `src/Verizon/Models/UserSmartAlert.cs` |
| `SensorInsightsListSmartAlertsRequestError` | `src/Verizon/Errors/SensorInsightsListSmartAlertsRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsPatchSmartAlertRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsPatchSmartAlertRequest(SensorInsightsPatchSmartAlertRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserSmartAlert`
- **Error**: `ApiException<SensorInsightsPatchSmartAlertRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsPatchSmartAlertRequest` | `src/Verizon/Requests/SensorInsightsSmartAlerts/SensorInsightsPatchSmartAlertRequest.cs` |
| `DtoPatchSmartAlertRequest` | `src/Verizon/Models/DtoPatchSmartAlertRequest.cs` |
| `UserSmartAlert` | `src/Verizon/Models/UserSmartAlert.cs` |
| `SensorInsightsPatchSmartAlertRequestError` | `src/Verizon/Errors/SensorInsightsPatchSmartAlertRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

