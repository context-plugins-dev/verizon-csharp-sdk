<!-- Generated file — do not edit; regenerated with the SDK. -->

# AnomalyTriggersV2 — operations

Accessor: `client.AnomalyTriggersV2` · Source: `src/Verizon/Api/AnomalyTriggersV2.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAnomalyDetectionTriggerV2

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateAnomalyDetectionTriggerV2(CreateAnomalyDetectionTriggerV2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateAnomalyDetectionTriggerV2Request` | `src/Verizon/Requests/AnomalyTriggersV2/CreateAnomalyDetectionTriggerV2Request.cs` |
| `CreateTriggerRequestOptions` | `src/Verizon/Models/AnyOf/CreateTriggerRequestOptions.cs` |
| `AnomalyDetectionTrigger` | `src/Verizon/Models/AnomalyDetectionTrigger.cs` |

### ListAnomalyDetectionTriggerSettingsV2

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAnomalyDetectionTriggerSettingsV2(ListAnomalyDetectionTriggerSettingsV2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`
- **Returns**: `AnomalyTriggerResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListAnomalyDetectionTriggerSettingsV2Request` | `src/Verizon/Requests/AnomalyTriggersV2/ListAnomalyDetectionTriggerSettingsV2Request.cs` |
| `AnomalyTriggerResult` | `src/Verizon/Models/AnomalyTriggerResult.cs` |

### UpdateAnomalyDetectionTriggerV2

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateAnomalyDetectionTriggerV2(UpdateAnomalyDetectionTriggerV2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IntelligenceSuccessResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateAnomalyDetectionTriggerV2Request` | `src/Verizon/Requests/AnomalyTriggersV2/UpdateAnomalyDetectionTriggerV2Request.cs` |
| `UpdateTriggerRequestOptions` | `src/Verizon/Models/AnyOf/UpdateTriggerRequestOptions.cs` |
| `IntelligenceSuccessResult` | `src/Verizon/Models/IntelligenceSuccessResult.cs` |

