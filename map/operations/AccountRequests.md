<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountRequests — operations

Accessor: `client.AccountRequests` · Source: `src/Verizon/Api/AccountRequests.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCurrentAsynchronousRequestStatus

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCurrentAsynchronousRequestStatus(GetCurrentAsynchronousRequestStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`, `RequestId`
- **Returns**: `AsynchronousRequestResult`
- **Error**: `ApiException<GetCurrentAsynchronousRequestStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCurrentAsynchronousRequestStatusRequest` | `src/Verizon/Requests/AccountRequests/GetCurrentAsynchronousRequestStatusRequest.cs` |
| `AsynchronousRequestResult` | `src/Verizon/Models/AsynchronousRequestResult.cs` |
| `GetCurrentAsynchronousRequestStatusError` | `src/Verizon/Errors/GetCurrentAsynchronousRequestStatusError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

