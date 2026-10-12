<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsSubscriptions — operations

Accessor: `client.DiagnosticsSubscriptions` · Source: `src/Verizon/Api/DiagnosticsSubscriptions.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDiagnosticsSubscription

- **Server group**: `DeviceDiagnostics`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDiagnosticsSubscription(GetDiagnosticsSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`
- **Returns**: `DiagnosticsSubscription`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetDiagnosticsSubscriptionRequest` | `src/Verizon/Requests/DiagnosticsSubscriptions/GetDiagnosticsSubscriptionRequest.cs` |
| `DiagnosticsSubscription` | `src/Verizon/Models/DiagnosticsSubscription.cs` |

