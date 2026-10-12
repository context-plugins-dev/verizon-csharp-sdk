<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsObservations — operations

Accessor: `client.DiagnosticsObservations` · Source: `src/Verizon/Api/DiagnosticsObservations.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### StartDiagnosticsObservation

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StartDiagnosticsObservation(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DiagnosticsObservationResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DiagnosticsObservationResult` | `src/Verizon/Models/DiagnosticsObservationResult.cs` |

### StopDiagnosticsObservation

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StopDiagnosticsObservation(StopDiagnosticsObservationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionId`, `AccountName`
- **Query params (wire ← C#)**: `transactionId` ← `TransactionId`, `accountName` ← `AccountName`
- **Returns**: `DiagnosticsObservationResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StopDiagnosticsObservationRequest` | `src/Verizon/Requests/DiagnosticsObservations/StopDiagnosticsObservationRequest.cs` |
| `DiagnosticsObservationResult` | `src/Verizon/Models/DiagnosticsObservationResult.cs` |

