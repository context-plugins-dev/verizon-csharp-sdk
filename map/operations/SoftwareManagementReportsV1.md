<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementReportsV1 — operations

Accessor: `client.SoftwareManagementReportsV1` · Source: `src/Verizon/Api/SoftwareManagementReportsV1.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDeviceFirmwareUpgradeHistory

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceFirmwareUpgradeHistory(GetDeviceFirmwareUpgradeHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceId`
- **Returns**: `IReadOnlyList<DeviceUpgradeHistory>`
- **Error**: `ApiException<GetDeviceFirmwareUpgradeHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceFirmwareUpgradeHistoryRequest` | `src/Verizon/Requests/SoftwareManagementReportsV1/GetDeviceFirmwareUpgradeHistoryRequest.cs` |
| `DeviceUpgradeHistory` | `src/Verizon/Models/DeviceUpgradeHistory.cs` |
| `GetDeviceFirmwareUpgradeHistoryError` | `src/Verizon/Errors/GetDeviceFirmwareUpgradeHistoryError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### ListAccountDevices

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountDevices(ListAccountDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `StartIndex`
- **Returns**: `DeviceListQueryResult`
- **Error**: `ApiException<ListAccountDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountDevicesRequest` | `src/Verizon/Requests/SoftwareManagementReportsV1/ListAccountDevicesRequest.cs` |
| `DeviceListQueryResult` | `src/Verizon/Models/DeviceListQueryResult.cs` |
| `ListAccountDevicesError` | `src/Verizon/Errors/ListAccountDevicesError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### ListUpgradesForSpecifiedStatus

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListUpgradesForSpecifiedStatus(ListUpgradesForSpecifiedStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `UpgradeStatus`, `StartIndex`
- **Returns**: `UpgradeListQueryResult`
- **Error**: `ApiException<ListUpgradesForSpecifiedStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListUpgradesForSpecifiedStatusRequest` | `src/Verizon/Requests/SoftwareManagementReportsV1/ListUpgradesForSpecifiedStatusRequest.cs` |
| `UpgradeStatus` | `src/Verizon/Models/Enums/UpgradeStatus.cs` |
| `UpgradeListQueryResult` | `src/Verizon/Models/UpgradeListQueryResult.cs` |
| `ListUpgradesForSpecifiedStatusError` | `src/Verizon/Errors/ListUpgradesForSpecifiedStatusError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

