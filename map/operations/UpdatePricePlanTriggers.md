<!-- Generated file — do not edit; regenerated with the SDK. -->

# UpdatePricePlanTriggers — operations

Accessor: `client.UpdatePricePlanTriggers` · Source: `src/Verizon/Api/UpdatePricePlanTriggers.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UpdateTriggerRules

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth1` OR `options.VzM2MToken`
- **Signature**: `UpdateTriggerRules(UpdateTriggerRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TriggerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTriggerRulesRequest` | `src/Verizon/Requests/UpdatePricePlanTriggers/UpdateTriggerRulesRequest.cs` |
| `V2TriggersRequest1` | `src/Verizon/Models/AnyOf/V2TriggersRequest1.cs` |
| `TriggerResponse` | `src/Verizon/Models/TriggerResponse.cs` |

