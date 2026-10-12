<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementSubscriptionsV1 — operations

Accessor: `client.SoftwareManagementSubscriptionsV1` · Source: `src/Verizon/Api/SoftwareManagementSubscriptionsV1.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountLicenseStatus

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountLicenseStatus(GetAccountLicenseStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `StartIndex`
- **Returns**: `AccountLicenseInfo`
- **Error**: `ApiException<GetAccountLicenseStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountLicenseStatusRequest` | `src/Verizon/Requests/SoftwareManagementSubscriptionsV1/GetAccountLicenseStatusRequest.cs` |
| `AccountLicenseInfo` | `src/Verizon/Models/AccountLicenseInfo.cs` |
| `GetAccountLicenseStatusError` | `src/Verizon/Errors/GetAccountLicenseStatusError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### GetAccountSubscriptionStatus

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountSubscriptionStatus(GetAccountSubscriptionStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `V1AccountSubscription`
- **Error**: `ApiException<GetAccountSubscriptionStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountSubscriptionStatusRequest` | `src/Verizon/Requests/SoftwareManagementSubscriptionsV1/GetAccountSubscriptionStatusRequest.cs` |
| `V1AccountSubscription` | `src/Verizon/Models/V1AccountSubscription.cs` |
| `GetAccountSubscriptionStatusError` | `src/Verizon/Errors/GetAccountSubscriptionStatusError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

