<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceLocationCallbacks — operations

Accessor: `client.DeviceLocationCallbacks` · Source: `src/Verizon/Api/DeviceLocationCallbacks.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAsyncReport

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CancelAsyncReport(CancelAsyncReportRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Txid`, `AccountName`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`
- **Returns**: `TransactionId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelAsyncReportRequest` | `src/Verizon/Requests/DeviceLocationCallbacks/CancelAsyncReportRequest.cs` |
| `TransactionId` | `src/Verizon/Models/TransactionId.cs` |

### DeregisterCallback2

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeregisterCallback2(DeregisterCallback2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `Service`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `ApiException<DeregisterCallback2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeregisterCallback2Request` | `src/Verizon/Requests/DeviceLocationCallbacks/DeregisterCallback2Request.cs` |
| `CallbackServiceName` | `src/Verizon/Models/Enums/CallbackServiceName.cs` |
| `DeviceLocationSuccessResult` | `src/Verizon/Models/DeviceLocationSuccessResult.cs` |
| `DeregisterCallback2Error` | `src/Verizon/Errors/DeregisterCallback2Error.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### ListRegisteredCallbacks2

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListRegisteredCallbacks2(ListRegisteredCallbacks2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `IReadOnlyList<DeviceLocationCallback>`
- **Error**: `ApiException<ListRegisteredCallbacks2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListRegisteredCallbacks2Request` | `src/Verizon/Requests/DeviceLocationCallbacks/ListRegisteredCallbacks2Request.cs` |
| `DeviceLocationCallback` | `src/Verizon/Models/DeviceLocationCallback.cs` |
| `ListRegisteredCallbacks2Error` | `src/Verizon/Errors/ListRegisteredCallbacks2Error.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### RegisterCallback2

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RegisterCallback2(RegisterCallback2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `CallbackRegistrationResult`
- **Error**: `ApiException<RegisterCallback2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterCallback2Request` | `src/Verizon/Requests/DeviceLocationCallbacks/RegisterCallback2Request.cs` |
| `CallbackRegistrationResult` | `src/Verizon/Models/CallbackRegistrationResult.cs` |
| `RegisterCallback2Error` | `src/Verizon/Errors/RegisterCallback2Error.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

