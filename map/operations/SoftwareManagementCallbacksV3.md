<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementCallbacksV3 — operations

Accessor: `client.SoftwareManagementCallbacksV3` · Source: `src/Verizon/Api/SoftwareManagementCallbacksV3.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback5

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeregisterCallback5(DeregisterCallback5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Returns**: `FotaV3SuccessResult`
- **Error**: `ApiException<DeregisterCallback5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallback5Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV3/DeregisterCallback5Request.cs` |
| `FotaV3SuccessResult` | `src/Verizon/Models/FotaV3SuccessResult.cs` |
| `DeregisterCallback5Error` | `src/Verizon/Errors/DeregisterCallback5Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### ListRegisteredCallbacks5

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListRegisteredCallbacks5(ListRegisteredCallbacks5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Returns**: `FotaV3CallbackSummary`
- **Error**: `ApiException<ListRegisteredCallbacks5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRegisteredCallbacks5Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV3/ListRegisteredCallbacks5Request.cs` |
| `FotaV3CallbackSummary` | `src/Verizon/Models/FotaV3CallbackSummary.cs` |
| `ListRegisteredCallbacks5Error` | `src/Verizon/Errors/ListRegisteredCallbacks5Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### RegisterCallback5

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterCallback5(RegisterCallback5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `FotaV3CallbackRegistrationResult`
- **Error**: `ApiException<RegisterCallback5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallback5Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV3/RegisterCallback5Request.cs` |
| `FotaV3CallbackRegistrationRequest` | `src/Verizon/Models/FotaV3CallbackRegistrationRequest.cs` |
| `FotaV3CallbackRegistrationResult` | `src/Verizon/Models/FotaV3CallbackRegistrationResult.cs` |
| `RegisterCallback5Error` | `src/Verizon/Errors/RegisterCallback5Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### UpdateCallback2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateCallback2(UpdateCallback2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `FotaV3CallbackRegistrationResult`
- **Error**: `ApiException<UpdateCallback2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCallback2Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV3/UpdateCallback2Request.cs` |
| `FotaV3CallbackRegistrationRequest` | `src/Verizon/Models/FotaV3CallbackRegistrationRequest.cs` |
| `FotaV3CallbackRegistrationResult` | `src/Verizon/Models/FotaV3CallbackRegistrationResult.cs` |
| `UpdateCallback2Error` | `src/Verizon/Errors/UpdateCallback2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

