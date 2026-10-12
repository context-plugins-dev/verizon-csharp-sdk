<!-- Generated file — do not edit; regenerated with the SDK. -->

# AnomalySettings — operations

Accessor: `client.AnomalySettings` · Source: `src/Verizon/Api/AnomalySettings.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateAnomalyDetection

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ActivateAnomalyDetection(ActivateAnomalyDetectionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IntelligenceSuccessResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActivateAnomalyDetectionRequest` | `src/Verizon/Requests/AnomalySettings/ActivateAnomalyDetectionRequest.cs` |
| `AnomalyDetectionRequest` | `src/Verizon/Models/AnomalyDetectionRequest.cs` |
| `IntelligenceSuccessResult` | `src/Verizon/Models/IntelligenceSuccessResult.cs` |

### ListAnomalyDetectionSettings

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAnomalyDetectionSettings(ListAnomalyDetectionSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `AnomalyDetectionSettings`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListAnomalyDetectionSettingsRequest` | `src/Verizon/Requests/AnomalySettings/ListAnomalyDetectionSettingsRequest.cs` |
| `AnomalyDetectionSettings` | `src/Verizon/Models/AnomalyDetectionSettings.cs` |

### ResetAnomalyDetectionParameters

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ResetAnomalyDetectionParameters(ResetAnomalyDetectionParametersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `IntelligenceSuccessResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ResetAnomalyDetectionParametersRequest` | `src/Verizon/Requests/AnomalySettings/ResetAnomalyDetectionParametersRequest.cs` |
| `IntelligenceSuccessResult` | `src/Verizon/Models/IntelligenceSuccessResult.cs` |

