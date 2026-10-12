<!-- Generated file — do not edit; regenerated with the SDK. -->

# RetrieveRatePlanList — operations

Accessor: `client.RetrieveRatePlanList` · Source: `src/Verizon/Api/RetrieveRatePlanList.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetRatePlanList

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth1` OR `options.VzM2MToken`
- **Signature**: `GetRatePlanList(GetRatePlanListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EcpdId`
- **Returns**: `Rateplan`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetRatePlanListRequest` | `src/Verizon/Requests/RetrieveRatePlanList/GetRatePlanListRequest.cs` |
| `Rateplan` | `src/Verizon/Models/Rateplan.cs` |

