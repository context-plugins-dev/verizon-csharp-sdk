<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountSubscriptions — operations

Accessor: `client.AccountSubscriptions` · Source: `src/Verizon/Api/AccountSubscriptions.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListAccountSubscriptions

- **Server group**: `M2M`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountSubscriptions(ListAccountSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SecuritySubscriptionResult`
- **Error**: `ApiException<ListAccountSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSecurityResult(out SecurityResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountSubscriptionsRequest` | `src/Verizon/Requests/AccountSubscriptions/ListAccountSubscriptionsRequest.cs` |
| `SecuritySubscriptionRequest` | `src/Verizon/Models/SecuritySubscriptionRequest.cs` |
| `SecuritySubscriptionResult` | `src/Verizon/Models/SecuritySubscriptionResult.cs` |
| `ListAccountSubscriptionsError` | `src/Verizon/Errors/ListAccountSubscriptionsError.cs` |
| `SecurityResult` | `src/Verizon/Models/SecurityResult.cs` |

