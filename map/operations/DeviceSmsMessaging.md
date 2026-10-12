<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceSmsMessaging — operations

Accessor: `client.DeviceSmsMessaging` · Source: `src/Verizon/Api/DeviceSmsMessaging.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetSmsMessages

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetSmsMessages(GetSmsMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Query params (wire ← C#)**: `next` ← `Next`
- **Returns**: `SmsMessagesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetSmsMessagesRequest` | `src/Verizon/Requests/DeviceSmsMessaging/GetSmsMessagesRequest.cs` |
| `SmsMessagesResponse` | `src/Verizon/Models/SmsMessagesResponse.cs` |

### ListSmsMessageHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListSmsMessageHistory(ListSmsMessageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSmsMessageHistoryRequest` | `src/Verizon/Requests/DeviceSmsMessaging/ListSmsMessageHistoryRequest.cs` |
| `SmsEventHistoryRequest` | `src/Verizon/Models/SmsEventHistoryRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### SendAnSmsMessage

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SendAnSmsMessage(SendAnSmsMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SendAnSmsMessageRequest` | `src/Verizon/Requests/DeviceSmsMessaging/SendAnSmsMessageRequest.cs` |
| `GiosmsSendRequest` | `src/Verizon/Models/GiosmsSendRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### StartSmsMessageDelivery

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StartSmsMessageDelivery(StartSmsMessageDeliveryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `SuccessResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StartSmsMessageDeliveryRequest` | `src/Verizon/Requests/DeviceSmsMessaging/StartSmsMessageDeliveryRequest.cs` |
| `SuccessResponse` | `src/Verizon/Models/SuccessResponse.cs` |

