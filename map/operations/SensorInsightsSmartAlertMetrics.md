<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsSmartAlertMetrics — operations

Accessor: `client.SensorInsightsSmartAlertMetrics` · Source: `src/Verizon/Api/SensorInsightsSmartAlertMetrics.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Sensorinsightsmetricsquery

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `Sensorinsightsmetricsquery(SensorinsightsmetricsqueryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoQueryMetricsResponse`
- **Error**: `ApiException<SensorinsightsmetricsqueryError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorinsightsmetricsqueryRequest` | `src/Verizon/Requests/SensorInsightsSmartAlertMetrics/SensorinsightsmetricsqueryRequest.cs` |
| `DtoQueryMetrics` | `src/Verizon/Models/DtoQueryMetrics.cs` |
| `DtoQueryMetricsResponse` | `src/Verizon/Models/DtoQueryMetricsResponse.cs` |
| `SensorinsightsmetricsqueryError` | `src/Verizon/Errors/SensorinsightsmetricsqueryError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

