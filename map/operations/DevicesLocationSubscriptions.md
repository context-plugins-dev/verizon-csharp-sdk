<!-- Generated file — do not edit; regenerated with the SDK. -->

# DevicesLocationSubscriptions — operations

Accessor: `client.DevicesLocationSubscriptions` · Source: `src/Verizon/Api/DevicesLocationSubscriptions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLocationServiceSubscriptionStatus

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetLocationServiceSubscriptionStatus(GetLocationServiceSubscriptionStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `DeviceLocationSubscription`
- **Error**: `ApiException<GetLocationServiceSubscriptionStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLocationServiceSubscriptionStatusRequest` | `src/Verizon/Requests/DevicesLocationSubscriptions/GetLocationServiceSubscriptionStatusRequest.cs` |
| `DeviceLocationSubscription` | `src/Verizon/Models/DeviceLocationSubscription.cs` |
| `GetLocationServiceSubscriptionStatusError` | `src/Verizon/Errors/GetLocationServiceSubscriptionStatusError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### GetLocationServiceUsage

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetLocationServiceUsage(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `object`
- **Error**: `ApiException<GetLocationServiceUsageError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLocationServiceUsageError` | `src/Verizon/Errors/GetLocationServiceUsageError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

