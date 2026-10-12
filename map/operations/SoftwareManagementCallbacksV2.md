<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementCallbacksV2 — operations

Accessor: `client.SoftwareManagementCallbacksV2` · Source: `src/Verizon/Api/SoftwareManagementCallbacksV2.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback4

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeregisterCallback4(DeregisterCallback4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `FotaV2SuccessResult`
- **Error**: `ApiException<DeregisterCallback4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallback4Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV2/DeregisterCallback4Request.cs` |
| `FotaV2SuccessResult` | `src/Verizon/Models/FotaV2SuccessResult.cs` |
| `DeregisterCallback4Error` | `src/Verizon/Errors/DeregisterCallback4Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ListRegisteredCallbacks4

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListRegisteredCallbacks4(ListRegisteredCallbacks4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `CallbackSummary`
- **Error**: `ApiException<ListRegisteredCallbacks4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRegisteredCallbacks4Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV2/ListRegisteredCallbacks4Request.cs` |
| `CallbackSummary` | `src/Verizon/Models/CallbackSummary.cs` |
| `ListRegisteredCallbacks4Error` | `src/Verizon/Errors/ListRegisteredCallbacks4Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### RegisterCallback4

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterCallback4(RegisterCallback4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `FotaV2CallbackRegistrationResult`
- **Error**: `ApiException<RegisterCallback4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallback4Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV2/RegisterCallback4Request.cs` |
| `FotaV2CallbackRegistrationResult` | `src/Verizon/Models/FotaV2CallbackRegistrationResult.cs` |
| `RegisterCallback4Error` | `src/Verizon/Errors/RegisterCallback4Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### UpdateCallback

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateCallback(UpdateCallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `FotaV2CallbackRegistrationResult`
- **Error**: `ApiException<UpdateCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCallbackRequest` | `src/Verizon/Requests/SoftwareManagementCallbacksV2/UpdateCallbackRequest.cs` |
| `FotaV2CallbackRegistrationResult` | `src/Verizon/Models/FotaV2CallbackRegistrationResult.cs` |
| `UpdateCallbackError` | `src/Verizon/Errors/UpdateCallbackError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

