<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementSubscriptionsV3 — operations

Accessor: `client.SoftwareManagementSubscriptionsV3` · Source: `src/Verizon/Api/SoftwareManagementSubscriptionsV3.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountSubscriptionStatus3

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountSubscriptionStatus3(GetAccountSubscriptionStatus3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Returns**: `FotaV3Subscription`
- **Error**: `ApiException<GetAccountSubscriptionStatus3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountSubscriptionStatus3Request` | `src/Verizon/Requests/SoftwareManagementSubscriptionsV3/GetAccountSubscriptionStatus3Request.cs` |
| `FotaV3Subscription` | `src/Verizon/Models/FotaV3Subscription.cs` |
| `GetAccountSubscriptionStatus3Error` | `src/Verizon/Errors/GetAccountSubscriptionStatus3Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

