<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsGateways — operations

Accessor: `client.SensorInsightsGateways` · Source: `src/Verizon/Api/SensorInsightsGateways.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsListGatewayDevicesRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListGatewayDevicesRequest(SensorInsightsListGatewayDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<ResourceDevice>`
- **Error**: `ApiException<SensorInsightsListGatewayDevicesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListGatewayDevicesRequest` | `src/Verizon/Requests/SensorInsightsGateways/SensorInsightsListGatewayDevicesRequest.cs` |
| `DtoListDevicesRequest` | `src/Verizon/Models/DtoListDevicesRequest.cs` |
| `ResourceDevice` | `src/Verizon/Models/ResourceDevice.cs` |
| `SensorInsightsListGatewayDevicesRequestError` | `src/Verizon/Errors/SensorInsightsListGatewayDevicesRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

