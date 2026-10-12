<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConnectivityCallbacks — operations

Accessor: `client.ConnectivityCallbacks` · Source: `src/Verizon/Api/ConnectivityCallbacks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeregisterCallback

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeregisterCallback(DeregisterCallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`, `Sname`
- **Returns**: `CallbackActionResult`
- **Error**: `ApiException<DeregisterCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallbackRequest` | `src/Verizon/Requests/ConnectivityCallbacks/DeregisterCallbackRequest.cs` |
| `CallbackActionResult` | `src/Verizon/Models/CallbackActionResult.cs` |
| `DeregisterCallbackError` | `src/Verizon/Errors/DeregisterCallbackError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListRegisteredCallbacks

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListRegisteredCallbacks(ListRegisteredCallbacksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `IReadOnlyList<ConnectivityManagementCallback>`
- **Error**: `ApiException<ListRegisteredCallbacksError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRegisteredCallbacksRequest` | `src/Verizon/Requests/ConnectivityCallbacks/ListRegisteredCallbacksRequest.cs` |
| `ConnectivityManagementCallback` | `src/Verizon/Models/ConnectivityManagementCallback.cs` |
| `ListRegisteredCallbacksError` | `src/Verizon/Errors/ListRegisteredCallbacksError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### RegisterCallback

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterCallback(RegisterCallbackOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`, `Body`
- **Returns**: `CallbackActionResult`
- **Error**: `ApiException<RegisterCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallbackOperationRequest` | `src/Verizon/Requests/ConnectivityCallbacks/RegisterCallbackOperationRequest.cs` |
| `RegisterCallbackRequest` | `src/Verizon/Models/RegisterCallbackRequest.cs` |
| `CallbackActionResult` | `src/Verizon/Models/CallbackActionResult.cs` |
| `RegisterCallbackError` | `src/Verizon/Errors/RegisterCallbackError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

