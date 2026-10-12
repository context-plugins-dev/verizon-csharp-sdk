<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsHealthScore — operations

Accessor: `client.SensorInsightsHealthScore` · Source: `src/Verizon/Api/SensorInsightsHealthScore.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsGetNetworkHealthScoreResponse

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsGetNetworkHealthScoreResponse(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DtoGetNetworkHealthScoreResponse`
- **Error**: `ApiException<SensorInsightsGetNetworkHealthScoreResponseError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoGetNetworkHealthScoreResponse` | `src/Verizon/Models/DtoGetNetworkHealthScoreResponse.cs` |
| `SensorInsightsGetNetworkHealthScoreResponseError` | `src/Verizon/Errors/SensorInsightsGetNetworkHealthScoreResponseError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsHealthScoreSummary

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsHealthScoreSummary(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DtoHealthScoreSummary`
- **Error**: `ApiException<SensorInsightsHealthScoreSummaryError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoHealthScoreSummary` | `src/Verizon/Models/DtoHealthScoreSummary.cs` |
| `SensorInsightsHealthScoreSummaryError` | `src/Verizon/Errors/SensorInsightsHealthScoreSummaryError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

