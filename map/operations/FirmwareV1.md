<!-- Generated file — do not edit; regenerated with the SDK. -->

# FirmwareV1 — operations

Accessor: `client.FirmwareV1` · Source: `src/Verizon/Api/FirmwareV1.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelScheduledFirmwareUpgrade

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CancelScheduledFirmwareUpgrade(CancelScheduledFirmwareUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `UpgradeId`
- **Returns**: `FotaV1SuccessResult`
- **Error**: `ApiException<CancelScheduledFirmwareUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelScheduledFirmwareUpgradeRequest` | `src/Verizon/Requests/FirmwareV1/CancelScheduledFirmwareUpgradeRequest.cs` |
| `FotaV1SuccessResult` | `src/Verizon/Models/FotaV1SuccessResult.cs` |
| `CancelScheduledFirmwareUpgradeError` | `src/Verizon/Errors/CancelScheduledFirmwareUpgradeError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### ListAvailableFirmware

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAvailableFirmware(ListAvailableFirmwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `IReadOnlyList<Firmware>`
- **Error**: `ApiException<ListAvailableFirmwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAvailableFirmwareRequest` | `src/Verizon/Requests/FirmwareV1/ListAvailableFirmwareRequest.cs` |
| `Firmware` | `src/Verizon/Models/Firmware.cs` |
| `ListAvailableFirmwareError` | `src/Verizon/Errors/ListAvailableFirmwareError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### ListFirmwareUpgradeDetails

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListFirmwareUpgradeDetails(ListFirmwareUpgradeDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `UpgradeId`
- **Returns**: `FirmwareUpgrade`
- **Error**: `ApiException<ListFirmwareUpgradeDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListFirmwareUpgradeDetailsRequest` | `src/Verizon/Requests/FirmwareV1/ListFirmwareUpgradeDetailsRequest.cs` |
| `FirmwareUpgrade` | `src/Verizon/Models/FirmwareUpgrade.cs` |
| `ListFirmwareUpgradeDetailsError` | `src/Verizon/Errors/ListFirmwareUpgradeDetailsError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### ScheduleFirmwareUpgrade

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ScheduleFirmwareUpgrade(ScheduleFirmwareUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FirmwareUpgrade`
- **Error**: `ApiException<ScheduleFirmwareUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleFirmwareUpgradeRequest` | `src/Verizon/Requests/FirmwareV1/ScheduleFirmwareUpgradeRequest.cs` |
| `FirmwareUpgradeRequest` | `src/Verizon/Models/FirmwareUpgradeRequest.cs` |
| `FirmwareUpgrade` | `src/Verizon/Models/FirmwareUpgrade.cs` |
| `ScheduleFirmwareUpgradeError` | `src/Verizon/Errors/ScheduleFirmwareUpgradeError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### UpdateFirmwareUpgradeDevices

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateFirmwareUpgradeDevices(UpdateFirmwareUpgradeDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `UpgradeId`
- **Returns**: `FirmwareUpgradeChangeResult`
- **Error**: `ApiException<UpdateFirmwareUpgradeDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateFirmwareUpgradeDevicesRequest` | `src/Verizon/Requests/FirmwareV1/UpdateFirmwareUpgradeDevicesRequest.cs` |
| `FirmwareUpgradeChangeResult` | `src/Verizon/Models/FirmwareUpgradeChangeResult.cs` |
| `UpdateFirmwareUpgradeDevicesError` | `src/Verizon/Errors/UpdateFirmwareUpgradeDevicesError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

