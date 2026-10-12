<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceReports — operations

Accessor: `client.DeviceReports` · Source: `src/Verizon/Api/DeviceReports.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CalculateAggregatedReportAsynchronous

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CalculateAggregatedReportAsynchronous(CalculateAggregatedReportAsynchronousRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AggregatedReportCallbackResult`
- **Error**: `ApiException<CalculateAggregatedReportAsynchronousError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CalculateAggregatedReportAsynchronousRequest` | `src/Verizon/Requests/DeviceReports/CalculateAggregatedReportAsynchronousRequest.cs` |
| `AggregateSessionReportRequest` | `src/Verizon/Models/AggregateSessionReportRequest.cs` |
| `AggregatedReportCallbackResult` | `src/Verizon/Models/AggregatedReportCallbackResult.cs` |
| `CalculateAggregatedReportAsynchronousError` | `src/Verizon/Errors/CalculateAggregatedReportAsynchronousError.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

### CalculateAggregatedReportSynchronous

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CalculateAggregatedReportSynchronous(CalculateAggregatedReportSynchronousRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AggregateSessionReport`
- **Error**: `ApiException<CalculateAggregatedReportSynchronousError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CalculateAggregatedReportSynchronousRequest` | `src/Verizon/Requests/DeviceReports/CalculateAggregatedReportSynchronousRequest.cs` |
| `AggregateSessionReportRequest` | `src/Verizon/Models/AggregateSessionReportRequest.cs` |
| `AggregateSessionReport` | `src/Verizon/Models/AggregateSessionReport.cs` |
| `CalculateAggregatedReportSynchronousError` | `src/Verizon/Errors/CalculateAggregatedReportSynchronousError.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

### GetSessionsReport

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetSessionsReport(GetSessionsReportRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SessionReport`
- **Error**: `ApiException<GetSessionsReportError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSessionsReportRequest` | `src/Verizon/Requests/DeviceReports/GetSessionsReportRequest.cs` |
| `SessionReportRequest` | `src/Verizon/Models/SessionReportRequest.cs` |
| `SessionReport` | `src/Verizon/Models/SessionReport.cs` |
| `GetSessionsReportError` | `src/Verizon/Errors/GetSessionsReportError.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

