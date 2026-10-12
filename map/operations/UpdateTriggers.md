<!-- Generated file — do not edit; regenerated with the SDK. -->

# UpdateTriggers — operations

Accessor: `client.UpdateTriggers` · Source: `src/Verizon/Api/UpdateTriggers.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UpdateAllAvailableTriggers

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateAllAvailableTriggers(UpdateAllAvailableTriggersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Success`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateAllAvailableTriggersRequest` | `src/Verizon/Requests/UpdateTriggers/UpdateAllAvailableTriggersRequest.cs` |
| `RequestTrigger` | `src/Verizon/Models/RequestTrigger.cs` |
| `Success` | `src/Verizon/Models/Success.cs` |

