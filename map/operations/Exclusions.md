<!-- Generated file — do not edit; regenerated with the SDK. -->

# Exclusions — operations

Accessor: `client.Exclusions` · Source: `src/Verizon/Api/Exclusions.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DevicesLocationGetConsentAsync

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DevicesLocationGetConsentAsync(DevicesLocationGetConsentAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`, `deviceId` ← `DeviceId`
- **Returns**: `GetAccountDeviceConsent`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DevicesLocationGetConsentAsyncRequest` | `src/Verizon/Requests/Exclusions/DevicesLocationGetConsentAsyncRequest.cs` |
| `GetAccountDeviceConsent` | `src/Verizon/Models/GetAccountDeviceConsent.cs` |

### DevicesLocationGiveConsentAsync

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DevicesLocationGiveConsentAsync(DevicesLocationGiveConsentAsyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ConsentTransactionId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DevicesLocationGiveConsentAsyncRequest` | `src/Verizon/Requests/Exclusions/DevicesLocationGiveConsentAsyncRequest.cs` |
| `AccountConsentCreate` | `src/Verizon/Models/AccountConsentCreate.cs` |
| `ConsentTransactionId` | `src/Verizon/Models/ConsentTransactionId.cs` |

### DevicesLocationUpdateConsent

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DevicesLocationUpdateConsent(DevicesLocationUpdateConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ConsentTransactionId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DevicesLocationUpdateConsentRequest` | `src/Verizon/Requests/Exclusions/DevicesLocationUpdateConsentRequest.cs` |
| `AccountConsentUpdate` | `src/Verizon/Models/AccountConsentUpdate.cs` |
| `ConsentTransactionId` | `src/Verizon/Models/ConsentTransactionId.cs` |

### ExcludeDevices

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ExcludeDevices(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `ApiException<ExcludeDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceLocationSuccessResult` | `src/Verizon/Models/DeviceLocationSuccessResult.cs` |
| `ExcludeDevicesError` | `src/Verizon/Errors/ExcludeDevicesError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### ListExcludedDevices

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListExcludedDevices(ListExcludedDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `StartIndex`
- **Returns**: `DevicesConsentResult`
- **Error**: `ApiException<ListExcludedDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListExcludedDevicesRequest` | `src/Verizon/Requests/Exclusions/ListExcludedDevicesRequest.cs` |
| `DevicesConsentResult` | `src/Verizon/Models/DevicesConsentResult.cs` |
| `ListExcludedDevicesError` | `src/Verizon/Errors/ListExcludedDevicesError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### RemoveDevicesFromExclusionList

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RemoveDevicesFromExclusionList(RemoveDevicesFromExclusionListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `DeviceList`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`, `deviceList` ← `DeviceList`
- **Returns**: `DeviceLocationSuccessResult`
- **Error**: `ApiException<RemoveDevicesFromExclusionListError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveDevicesFromExclusionListRequest` | `src/Verizon/Requests/Exclusions/RemoveDevicesFromExclusionListRequest.cs` |
| `DeviceLocationSuccessResult` | `src/Verizon/Models/DeviceLocationSuccessResult.cs` |
| `RemoveDevicesFromExclusionListError` | `src/Verizon/Errors/RemoveDevicesFromExclusionListError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

