<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementCallbacksV1 — operations

Accessor: `client.SoftwareManagementCallbacksV1` · Source: `src/Verizon/Api/SoftwareManagementCallbacksV1.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback3

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeregisterCallback3(DeregisterCallback3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `Service`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeregisterCallback3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallback3Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV1/DeregisterCallback3Request.cs` |
| `CallbackService` | `src/Verizon/Models/Enums/CallbackService.cs` |
| `DeregisterCallback3Error` | `src/Verizon/Errors/DeregisterCallback3Error.cs` |

### ListRegisteredCallbacks3

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListRegisteredCallbacks3(ListRegisteredCallbacks3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `IReadOnlyList<RegisteredCallbacks>`
- **Error**: `ApiException<ListRegisteredCallbacks3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRegisteredCallbacks3Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV1/ListRegisteredCallbacks3Request.cs` |
| `RegisteredCallbacks` | `src/Verizon/Models/RegisteredCallbacks.cs` |
| `ListRegisteredCallbacks3Error` | `src/Verizon/Errors/ListRegisteredCallbacks3Error.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### RegisterCallback3

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterCallback3(RegisterCallback3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `Body`
- **Returns**: `FotaV1CallbackRegistrationResult`
- **Error**: `ApiException<RegisterCallback3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallback3Request` | `src/Verizon/Requests/SoftwareManagementCallbacksV1/RegisterCallback3Request.cs` |
| `FotaV1CallbackRegistrationRequest` | `src/Verizon/Models/FotaV1CallbackRegistrationRequest.cs` |
| `FotaV1CallbackRegistrationResult` | `src/Verizon/Models/FotaV1CallbackRegistrationResult.cs` |
| `RegisterCallback3Error` | `src/Verizon/Errors/RegisterCallback3Error.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

