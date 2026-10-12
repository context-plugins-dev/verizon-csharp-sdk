<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsageTriggerManagement — operations

Accessor: `client.UsageTriggerManagement` · Source: `src/Verizon/Api/UsageTriggerManagement.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateNewTrigger

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateNewTrigger(CreateNewTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UsageTriggerResponse`
- **Error**: `ApiException<CreateNewTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateNewTriggerRequest` | `src/Verizon/Requests/UsageTriggerManagement/CreateNewTriggerRequest.cs` |
| `UsageTriggerAddRequest` | `src/Verizon/Models/UsageTriggerAddRequest.cs` |
| `UsageTriggerResponse` | `src/Verizon/Models/UsageTriggerResponse.cs` |
| `CreateNewTriggerError` | `src/Verizon/Errors/CreateNewTriggerError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### DeleteTrigger

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteTrigger(DeleteTriggerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `TriggerId`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `ApiException<DeleteTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTriggerRequest` | `src/Verizon/Requests/UsageTriggerManagement/DeleteTriggerRequest.cs` |
| `DeviceLocationSuccessResult` | `src/Verizon/Models/DeviceLocationSuccessResult.cs` |
| `DeleteTriggerError` | `src/Verizon/Errors/DeleteTriggerError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### UpdateTrigger

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateTrigger(UpdateTriggerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TriggerId`
- **Returns**: `UsageTriggerResponse`
- **Error**: `ApiException<UpdateTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateTriggerOperationRequest` | `src/Verizon/Requests/UsageTriggerManagement/UpdateTriggerOperationRequest.cs` |
| `UsageTriggerUpdateRequest` | `src/Verizon/Models/UsageTriggerUpdateRequest.cs` |
| `UsageTriggerResponse` | `src/Verizon/Models/UsageTriggerResponse.cs` |
| `UpdateTriggerError` | `src/Verizon/Errors/UpdateTriggerError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

