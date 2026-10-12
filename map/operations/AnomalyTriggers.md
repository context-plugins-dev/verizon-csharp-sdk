<!-- Generated file — do not edit; regenerated with the SDK. -->

# AnomalyTriggers — operations

Accessor: `client.AnomalyTriggers` · Source: `src/Verizon/Api/AnomalyTriggers.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAnomalyDetectionTrigger

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateAnomalyDetectionTrigger(CreateAnomalyDetectionTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `ApiException<CreateAnomalyDetectionTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAnomalyDetectionTriggerRequest` | `src/Verizon/Requests/AnomalyTriggers/CreateAnomalyDetectionTriggerRequest.cs` |
| `CreateTriggerRequest` | `src/Verizon/Models/CreateTriggerRequest.cs` |
| `AnomalyDetectionTrigger` | `src/Verizon/Models/AnomalyDetectionTrigger.cs` |
| `CreateAnomalyDetectionTriggerError` | `src/Verizon/Errors/CreateAnomalyDetectionTriggerError.cs` |
| `IntelligenceResult` | `src/Verizon/Models/IntelligenceResult.cs` |

### DeleteAnomalyDetectionTrigger

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteAnomalyDetectionTrigger(DeleteAnomalyDetectionTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteAnomalyDetectionTriggerRequest` | `src/Verizon/Requests/AnomalyTriggers/DeleteAnomalyDetectionTriggerRequest.cs` |
| `AnomalyDetectionTrigger` | `src/Verizon/Models/AnomalyDetectionTrigger.cs` |

### ListAnomalyDetectionTriggerSettings

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAnomalyDetectionTriggerSettings(ListAnomalyDetectionTriggerSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`
- **Returns**: `IReadOnlyList<GetTriggerResponseList>`
- **Error**: `ApiException<ListAnomalyDetectionTriggerSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAnomalyDetectionTriggerSettingsRequest` | `src/Verizon/Requests/AnomalyTriggers/ListAnomalyDetectionTriggerSettingsRequest.cs` |
| `GetTriggerResponseList` | `src/Verizon/Models/GetTriggerResponseList.cs` |
| `ListAnomalyDetectionTriggerSettingsError` | `src/Verizon/Errors/ListAnomalyDetectionTriggerSettingsError.cs` |
| `IntelligenceResult` | `src/Verizon/Models/IntelligenceResult.cs` |

### ListAnomalyDetectionTriggers

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAnomalyDetectionTriggers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<GetTriggerResponseList>`
- **Error**: `ApiException<ListAnomalyDetectionTriggersError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTriggerResponseList` | `src/Verizon/Models/GetTriggerResponseList.cs` |
| `ListAnomalyDetectionTriggersError` | `src/Verizon/Errors/ListAnomalyDetectionTriggersError.cs` |
| `IntelligenceResult` | `src/Verizon/Models/IntelligenceResult.cs` |

### UpdateAnomalyDetectionTrigger

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateAnomalyDetectionTrigger(UpdateAnomalyDetectionTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `ApiException<UpdateAnomalyDetectionTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAnomalyDetectionTriggerRequest` | `src/Verizon/Requests/AnomalyTriggers/UpdateAnomalyDetectionTriggerRequest.cs` |
| `UpdateTriggerRequest` | `src/Verizon/Models/UpdateTriggerRequest.cs` |
| `AnomalyDetectionTrigger` | `src/Verizon/Models/AnomalyDetectionTrigger.cs` |
| `UpdateAnomalyDetectionTriggerError` | `src/Verizon/Errors/UpdateAnomalyDetectionTriggerError.cs` |
| `IntelligenceResult` | `src/Verizon/Models/IntelligenceResult.cs` |

