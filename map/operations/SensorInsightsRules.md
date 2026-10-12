<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsRules — operations

Accessor: `client.SensorInsightsRules` · Source: `src/Verizon/Api/SensorInsightsRules.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsListRulesRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListRulesRequest(SensorInsightsListRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<ResourceRule>`
- **Error**: `ApiException<SensorInsightsListRulesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListRulesRequest` | `src/Verizon/Requests/SensorInsightsRules/SensorInsightsListRulesRequest.cs` |
| `DtoListRulesRequest` | `src/Verizon/Models/DtoListRulesRequest.cs` |
| `ResourceRule` | `src/Verizon/Models/ResourceRule.cs` |
| `SensorInsightsListRulesRequestError` | `src/Verizon/Errors/SensorInsightsListRulesRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsOverwriteRuleRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsOverwriteRuleRequest(SensorInsightsOverwriteRuleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ResourceRule`
- **Error**: `ApiException<SensorInsightsOverwriteRuleRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsOverwriteRuleRequest` | `src/Verizon/Requests/SensorInsightsRules/SensorInsightsOverwriteRuleRequest.cs` |
| `DtoOverwriteRuleRequest` | `src/Verizon/Models/DtoOverwriteRuleRequest.cs` |
| `ResourceRule` | `src/Verizon/Models/ResourceRule.cs` |
| `SensorInsightsOverwriteRuleRequestError` | `src/Verizon/Errors/SensorInsightsOverwriteRuleRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

