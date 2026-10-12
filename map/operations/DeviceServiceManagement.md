<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceServiceManagement — operations

Accessor: `client.DeviceServiceManagement` · Source: `src/Verizon/Api/DeviceServiceManagement.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDeviceHyperPreciseStatus

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceHyperPreciseStatus(GetDeviceHyperPreciseStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Imei`, `AccountNumber`
- **Query params (wire ← C#)**: `imei` ← `Imei`, `accountNumber` ← `AccountNumber`
- **Returns**: `BullseyeServiceResult`
- **Error**: `ApiException<GetDeviceHyperPreciseStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceHyperPreciseStatusRequest` | `src/Verizon/Requests/DeviceServiceManagement/GetDeviceHyperPreciseStatusRequest.cs` |
| `BullseyeServiceResult` | `src/Verizon/Models/BullseyeServiceResult.cs` |
| `GetDeviceHyperPreciseStatusError` | `src/Verizon/Errors/GetDeviceHyperPreciseStatusError.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

### UpdateDeviceHyperPreciseStatus

- **Server group**: `HyperPreciseLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDeviceHyperPreciseStatus(UpdateDeviceHyperPreciseStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BullseyeServiceResult`
- **Error**: `ApiException<UpdateDeviceHyperPreciseStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult)` [400, 401, 403, 404, 409, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDeviceHyperPreciseStatusRequest` | `src/Verizon/Requests/DeviceServiceManagement/UpdateDeviceHyperPreciseStatusRequest.cs` |
| `BullseyeServiceRequest` | `src/Verizon/Models/BullseyeServiceRequest.cs` |
| `BullseyeServiceResult` | `src/Verizon/Models/BullseyeServiceResult.cs` |
| `UpdateDeviceHyperPreciseStatusError` | `src/Verizon/Errors/UpdateDeviceHyperPreciseStatusError.cs` |
| `HyperPreciseLocationResult` | `src/Verizon/Models/HyperPreciseLocationResult.cs` |

