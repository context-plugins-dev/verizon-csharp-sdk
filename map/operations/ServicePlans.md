<!-- Generated file — do not edit; regenerated with the SDK. -->

# ServicePlans — operations

Accessor: `client.ServicePlans` · Source: `src/Verizon/Api/ServicePlans.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListAccountServicePlans

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountServicePlans(ListAccountServicePlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `IReadOnlyList<ServicePlan>`
- **Error**: `ApiException<ListAccountServicePlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountServicePlansRequest` | `src/Verizon/Requests/ServicePlans/ListAccountServicePlansRequest.cs` |
| `ServicePlan` | `src/Verizon/Models/ServicePlan.cs` |
| `ListAccountServicePlansError` | `src/Verizon/Errors/ListAccountServicePlansError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

