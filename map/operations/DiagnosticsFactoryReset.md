<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsFactoryReset — operations

Accessor: `client.DiagnosticsFactoryReset` · Source: `src/Verizon/Api/DiagnosticsFactoryReset.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DecivesRestart

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DecivesRestart(DecivesRestartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DiagnosticsObservationResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DecivesRestartRequest` | `src/Verizon/Requests/DiagnosticsFactoryReset/DecivesRestartRequest.cs` |
| `DeviceResetRequest` | `src/Verizon/Models/DeviceResetRequest.cs` |
| `DiagnosticsObservationResult` | `src/Verizon/Models/DiagnosticsObservationResult.cs` |

