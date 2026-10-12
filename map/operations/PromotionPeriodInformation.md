<!-- Generated file — do not edit; regenerated with the SDK. -->

# PromotionPeriodInformation — operations

Accessor: `client.PromotionPeriodInformation` · Source: `src/Verizon/Api/PromotionPeriodInformation.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPromoDeviceAggregateUsageHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetPromoDeviceAggregateUsageHistory(GetPromoDeviceAggregateUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UsageRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPromoDeviceAggregateUsageHistoryRequest` | `src/Verizon/Requests/PromotionPeriodInformation/GetPromoDeviceAggregateUsageHistoryRequest.cs` |
| `RequestBodyForUsage` | `src/Verizon/Models/RequestBodyForUsage.cs` |
| `UsageRequestResponse` | `src/Verizon/Models/UsageRequestResponse.cs` |

### GetPromoDeviceUsageHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetPromoDeviceUsageHistory(GetPromoDeviceUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ResponseToUsageQuery`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPromoDeviceUsageHistoryRequest` | `src/Verizon/Requests/PromotionPeriodInformation/GetPromoDeviceUsageHistoryRequest.cs` |
| `ARequestBodyForUsage` | `src/Verizon/Models/ARequestBodyForUsage.cs` |
| `ResponseToUsageQuery` | `src/Verizon/Models/ResponseToUsageQuery.cs` |

