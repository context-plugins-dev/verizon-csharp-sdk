<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsHistory — operations

Accessor: `client.DiagnosticsHistory` · Source: `src/Verizon/Api/DiagnosticsHistory.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDiagnosticsHistory

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDiagnosticsHistory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<History>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `History` | `src/Verizon/Models/History.cs` |

