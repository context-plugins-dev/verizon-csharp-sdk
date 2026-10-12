<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsCallbacks — operations

Accessor: `client.DiagnosticsCallbacks` · Source: `src/Verizon/Api/DiagnosticsCallbacks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDiagnosticsSubscriptionCallbackInfo

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDiagnosticsSubscriptionCallbackInfo(GetDiagnosticsSubscriptionCallbackInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`
- **Returns**: `IReadOnlyList<DeviceDiagnosticsCallback>`
- **Error**: `ApiException<GetDiagnosticsSubscriptionCallbackInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDiagnosticsSubscriptionCallbackInfoRequest` | `src/Verizon/Requests/DiagnosticsCallbacks/GetDiagnosticsSubscriptionCallbackInfoRequest.cs` |
| `DeviceDiagnosticsCallback` | `src/Verizon/Models/DeviceDiagnosticsCallback.cs` |
| `GetDiagnosticsSubscriptionCallbackInfoError` | `src/Verizon/Errors/GetDiagnosticsSubscriptionCallbackInfoError.cs` |
| `DeviceDiagnosticsResult` | `src/Verizon/Models/DeviceDiagnosticsResult.cs` |

### RegisterDiagnosticsCallbackUrl

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterDiagnosticsCallbackUrl(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DeviceDiagnosticsCallback`
- **Error**: `ApiException<RegisterDiagnosticsCallbackUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceDiagnosticsCallback` | `src/Verizon/Models/DeviceDiagnosticsCallback.cs` |
| `RegisterDiagnosticsCallbackUrlError` | `src/Verizon/Errors/RegisterDiagnosticsCallbackUrlError.cs` |
| `DeviceDiagnosticsResult` | `src/Verizon/Models/DeviceDiagnosticsResult.cs` |

### UnregisterDiagnosticsCallback

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UnregisterDiagnosticsCallback(UnregisterDiagnosticsCallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `ServiceName`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`, `serviceName` ← `ServiceName`
- **Returns**: `DeviceDiagnosticsCallback`
- **Error**: `ApiException<UnregisterDiagnosticsCallbackError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnregisterDiagnosticsCallbackRequest` | `src/Verizon/Requests/DiagnosticsCallbacks/UnregisterDiagnosticsCallbackRequest.cs` |
| `DeviceDiagnosticsCallback` | `src/Verizon/Models/DeviceDiagnosticsCallback.cs` |
| `UnregisterDiagnosticsCallbackError` | `src/Verizon/Errors/UnregisterDiagnosticsCallbackError.cs` |
| `DeviceDiagnosticsResult` | `src/Verizon/Models/DeviceDiagnosticsResult.cs` |

