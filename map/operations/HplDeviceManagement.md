<!-- Generated file — do not edit; regenerated with the SDK. -->

# HplDeviceManagement — operations

Accessor: `client.HplDeviceManagement` · Source: `src/Verizon/Api/HplDeviceManagement.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddDevicesHyperPrecise

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AddDevicesHyperPrecise(AddDevicesHyperPreciseRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<HplAddDevicesRequest>`
- **Error**: `ApiException<AddDevicesHyperPreciseError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 405, 406, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddDevicesHyperPreciseRequest` | `src/Verizon/Requests/HplDeviceManagement/AddDevicesHyperPreciseRequest.cs` |
| `HplAddDevicesRequest` | `src/Verizon/Models/HplAddDevicesRequest.cs` |
| `AddDevicesHyperPreciseError` | `src/Verizon/Errors/AddDevicesHyperPreciseError.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

