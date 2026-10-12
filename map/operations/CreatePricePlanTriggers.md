<!-- Generated file — do not edit; regenerated with the SDK. -->

# CreatePricePlanTriggers — operations

Accessor: `client.CreatePricePlanTriggers` · Source: `src/Verizon/Api/CreatePricePlanTriggers.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateTriggerRules

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth1` OR `options.VzM2MToken`
- **Signature**: `CreateTriggerRules(CreateTriggerRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TriggerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTriggerRulesRequest` | `src/Verizon/Requests/CreatePricePlanTriggers/CreateTriggerRulesRequest.cs` |
| `V2TriggersRequest` | `src/Verizon/Models/AnyOf/V2TriggersRequest.cs` |
| `TriggerResponse` | `src/Verizon/Models/TriggerResponse.cs` |

