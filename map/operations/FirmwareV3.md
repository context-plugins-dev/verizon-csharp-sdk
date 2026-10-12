<!-- Generated file — do not edit; regenerated with the SDK. -->

# FirmwareV3 — operations

Accessor: `client.FirmwareV3` · Source: `src/Verizon/Api/FirmwareV3.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListAvailableFirmware2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAvailableFirmware2(ListAvailableFirmware2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Query params (wire ← C#)**: `protocol` ← `Protocol`
- **Returns**: `IReadOnlyList<FirmwarePackage>`
- **Error**: `ApiException<ListAvailableFirmware2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAvailableFirmware2Request` | `src/Verizon/Requests/FirmwareV3/ListAvailableFirmware2Request.cs` |
| `FirmwareProtocol` | `src/Verizon/Models/Enums/FirmwareProtocol.cs` |
| `FirmwarePackage` | `src/Verizon/Models/FirmwarePackage.cs` |
| `ListAvailableFirmware2Error` | `src/Verizon/Errors/ListAvailableFirmware2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### ReportDeviceFirmware

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ReportDeviceFirmware(ReportDeviceFirmwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `DeviceId`
- **Returns**: `DeviceFirmwareVersionUpdateResult`
- **Error**: `ApiException<ReportDeviceFirmwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReportDeviceFirmwareRequest` | `src/Verizon/Requests/FirmwareV3/ReportDeviceFirmwareRequest.cs` |
| `DeviceFirmwareVersionUpdateResult` | `src/Verizon/Models/DeviceFirmwareVersionUpdateResult.cs` |
| `ReportDeviceFirmwareError` | `src/Verizon/Errors/ReportDeviceFirmwareError.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### SynchronizeDeviceFirmware

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SynchronizeDeviceFirmware(SynchronizeDeviceFirmwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `DeviceFirmwareList`
- **Error**: `ApiException<SynchronizeDeviceFirmwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SynchronizeDeviceFirmwareRequest` | `src/Verizon/Requests/FirmwareV3/SynchronizeDeviceFirmwareRequest.cs` |
| `FirmwareImei` | `src/Verizon/Models/FirmwareImei.cs` |
| `DeviceFirmwareList` | `src/Verizon/Models/DeviceFirmwareList.cs` |
| `SynchronizeDeviceFirmwareError` | `src/Verizon/Errors/SynchronizeDeviceFirmwareError.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

