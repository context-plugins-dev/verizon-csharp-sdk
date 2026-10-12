<!-- Generated file — do not edit; regenerated with the SDK. -->

# HyperPreciseLocationCallbacks — operations

Accessor: `client.HyperPreciseLocationCallbacks` · Source: `src/Verizon/Api/HyperPreciseLocationCallbacks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback6

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeregisterCallback6(DeregisterCallback6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountNumber`, `Service`
- **Query params (wire ← C#)**: `accountNumber` ← `AccountNumber`, `service` ← `Service`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeregisterCallback6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallback6Request` | `src/Verizon/Requests/HyperPreciseLocationCallbacks/DeregisterCallback6Request.cs` |
| `DeregisterCallback6Error` | `src/Verizon/Errors/DeregisterCallback6Error.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

### ListRegisteredCallbacks6

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListRegisteredCallbacks6(ListRegisteredCallbacks6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountNumber`
- **Query params (wire ← C#)**: `accountNumber` ← `AccountNumber`
- **Returns**: `IReadOnlyList<CallbackCreated>`
- **Error**: `ApiException<ListRegisteredCallbacks6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRegisteredCallbacks6Request` | `src/Verizon/Requests/HyperPreciseLocationCallbacks/ListRegisteredCallbacks6Request.cs` |
| `CallbackCreated` | `src/Verizon/Models/CallbackCreated.cs` |
| `ListRegisteredCallbacks6Error` | `src/Verizon/Errors/ListRegisteredCallbacks6Error.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

### RegisterCallback6

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterCallback6(RegisterCallback6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountNumber`, `Body`
- **Query params (wire ← C#)**: `accountNumber` ← `AccountNumber`
- **Returns**: `CallbackRegistered`
- **Error**: `ApiException<RegisterCallback6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallback6Request` | `src/Verizon/Requests/HyperPreciseLocationCallbacks/RegisterCallback6Request.cs` |
| `HyperPreciseLocationCallback` | `src/Verizon/Models/HyperPreciseLocationCallback.cs` |
| `CallbackRegistered` | `src/Verizon/Models/CallbackRegistered.cs` |
| `RegisterCallback6Error` | `src/Verizon/Errors/RegisterCallback6Error.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

