<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementReportsV2 — operations

Accessor: `client.SoftwareManagementReportsV2` · Source: `src/Verizon/Api/SoftwareManagementReportsV2.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCampaignDeviceStatus

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCampaignDeviceStatus(GetCampaignDeviceStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `CampaignId`
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `LastSeenDeviceId`
- **Returns**: `V2CampaignDevice`
- **Error**: `ApiException<GetCampaignDeviceStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCampaignDeviceStatusRequest` | `src/Verizon/Requests/SoftwareManagementReportsV2/GetCampaignDeviceStatusRequest.cs` |
| `V2CampaignDevice` | `src/Verizon/Models/V2CampaignDevice.cs` |
| `GetCampaignDeviceStatusError` | `src/Verizon/Errors/GetCampaignDeviceStatusError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### GetCampaignHistoryByStatus

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCampaignHistoryByStatus(GetCampaignHistoryByStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `CampaignStatus`
- **Query params (wire ← C#)**: `campaignStatus` ← `CampaignStatus`, `lastSeenCampaignId` ← `LastSeenCampaignId`
- **Returns**: `V2CampaignHistory`
- **Error**: `ApiException<GetCampaignHistoryByStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCampaignHistoryByStatusRequest` | `src/Verizon/Requests/SoftwareManagementReportsV2/GetCampaignHistoryByStatusRequest.cs` |
| `V2CampaignHistory` | `src/Verizon/Models/V2CampaignHistory.cs` |
| `GetCampaignHistoryByStatusError` | `src/Verizon/Errors/GetCampaignHistoryByStatusError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### GetDeviceFirmwareUpgradeHistory2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceFirmwareUpgradeHistory2(GetDeviceFirmwareUpgradeHistory2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceId`
- **Returns**: `IReadOnlyList<DeviceSoftwareUpgrade>`
- **Error**: `ApiException<GetDeviceFirmwareUpgradeHistory2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceFirmwareUpgradeHistory2Request` | `src/Verizon/Requests/SoftwareManagementReportsV2/GetDeviceFirmwareUpgradeHistory2Request.cs` |
| `DeviceSoftwareUpgrade` | `src/Verizon/Models/DeviceSoftwareUpgrade.cs` |
| `GetDeviceFirmwareUpgradeHistory2Error` | `src/Verizon/Errors/GetDeviceFirmwareUpgradeHistory2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ListAccountDevices2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountDevices2(ListAccountDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `LastSeenDeviceId`, `distributionType` ← `DistributionType`
- **Returns**: `V2AccountDeviceList`
- **Error**: `ApiException<ListAccountDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountDevices2Request` | `src/Verizon/Requests/SoftwareManagementReportsV2/ListAccountDevices2Request.cs` |
| `V2AccountDeviceList` | `src/Verizon/Models/V2AccountDeviceList.cs` |
| `ListAccountDevices2Error` | `src/Verizon/Errors/ListAccountDevices2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ListAvailableSoftware

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAvailableSoftware(ListAvailableSoftwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Query params (wire ← C#)**: `distributionType` ← `DistributionType`
- **Returns**: `IReadOnlyList<SoftwarePackage>`
- **Error**: `ApiException<ListAvailableSoftwareError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAvailableSoftwareRequest` | `src/Verizon/Requests/SoftwareManagementReportsV2/ListAvailableSoftwareRequest.cs` |
| `SoftwarePackage` | `src/Verizon/Models/SoftwarePackage.cs` |
| `ListAvailableSoftwareError` | `src/Verizon/Errors/ListAvailableSoftwareError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

