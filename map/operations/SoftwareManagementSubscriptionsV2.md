<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementSubscriptionsV2 — operations

Accessor: `client.SoftwareManagementSubscriptionsV2` · Source: `src/Verizon/Api/SoftwareManagementSubscriptionsV2.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountSubscriptionStatus2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountSubscriptionStatus2(GetAccountSubscriptionStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `FotaV2Subscription`
- **Error**: `ApiException<GetAccountSubscriptionStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountSubscriptionStatus2Request` | `src/Verizon/Requests/SoftwareManagementSubscriptionsV2/GetAccountSubscriptionStatus2Request.cs` |
| `FotaV2Subscription` | `src/Verizon/Models/FotaV2Subscription.cs` |
| `GetAccountSubscriptionStatus2Error` | `src/Verizon/Errors/GetAccountSubscriptionStatus2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

