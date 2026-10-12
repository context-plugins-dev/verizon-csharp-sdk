<!-- Generated file — do not edit; regenerated with the SDK. -->

# RetrieveTheTriggers — operations

Accessor: `client.RetrieveTheTriggers` · Source: `src/Verizon/Api/RetrieveTheTriggers.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAllAvailableTriggers

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAllAvailableTriggers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TriggerValueResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TriggerValueResponse` | `src/Verizon/Models/TriggerValueResponse.cs` |

### GetAllTriggersByAccountName

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAllTriggersByAccountName(GetAllTriggersByAccountNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `TriggerValueResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAllTriggersByAccountNameRequest` | `src/Verizon/Requests/RetrieveTheTriggers/GetAllTriggersByAccountNameRequest.cs` |
| `TriggerValueResponse` | `src/Verizon/Models/TriggerValueResponse.cs` |

### GetAllTriggersByTriggerCategory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAllTriggersByTriggerCategory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TriggerValueResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TriggerValueResponse2` | `src/Verizon/Models/TriggerValueResponse2.cs` |

### GetTriggersById

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetTriggersById(GetTriggersByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`
- **Returns**: `TriggerValueResponse2`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTriggersByIdRequest` | `src/Verizon/Requests/RetrieveTheTriggers/GetTriggersByIdRequest.cs` |
| `TriggerValueResponse2` | `src/Verizon/Models/TriggerValueResponse2.cs` |

