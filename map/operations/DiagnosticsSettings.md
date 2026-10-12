<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsSettings — operations

Accessor: `client.DiagnosticsSettings` · Source: `src/Verizon/Api/DiagnosticsSettings.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListDiagnosticsSettings

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDiagnosticsSettings(ListDiagnosticsSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `Devices`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`, `devices` ← `Devices`
- **Returns**: `IReadOnlyList<DiagnosticObservationSetting>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDiagnosticsSettingsRequest` | `src/Verizon/Requests/DiagnosticsSettings/ListDiagnosticsSettingsRequest.cs` |
| `DiagnosticObservationSetting` | `src/Verizon/Models/DiagnosticObservationSetting.cs` |

