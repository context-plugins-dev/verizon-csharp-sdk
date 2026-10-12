<!-- Generated file — do not edit; regenerated with the SDK. -->

# Sms — operations

Accessor: `client.Sms` · Source: `src/Verizon/Api/Sms.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListDevicesSmsMessages

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesSmsMessages(ListDevicesSmsMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Query params (wire ← C#)**: `next` ← `Next`
- **Returns**: `SmsMessagesQueryResult`
- **Error**: `ApiException<ListDevicesSmsMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDevicesSmsMessagesRequest` | `src/Verizon/Requests/Sms/ListDevicesSmsMessagesRequest.cs` |
| `SmsMessagesQueryResult` | `src/Verizon/Models/SmsMessagesQueryResult.cs` |
| `ListDevicesSmsMessagesError` | `src/Verizon/Errors/ListDevicesSmsMessagesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### SendSmsToDevice

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SendSmsToDevice(SendSmsToDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<SendSmsToDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SendSmsToDeviceRequest` | `src/Verizon/Requests/Sms/SendSmsToDeviceRequest.cs` |
| `SmsSendRequest` | `src/Verizon/Models/SmsSendRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `SendSmsToDeviceError` | `src/Verizon/Errors/SendSmsToDeviceError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### StartQueuedSmsDelivery

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StartQueuedSmsDelivery(StartQueuedSmsDeliveryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `ApiException<StartQueuedSmsDeliveryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `StartQueuedSmsDeliveryRequest` | `src/Verizon/Requests/Sms/StartQueuedSmsDeliveryRequest.cs` |
| `ConnectivityManagementSuccessResult` | `src/Verizon/Models/ConnectivityManagementSuccessResult.cs` |
| `StartQueuedSmsDeliveryError` | `src/Verizon/Errors/StartQueuedSmsDeliveryError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

