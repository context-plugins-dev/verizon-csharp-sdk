<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementReportsV3 — operations

Accessor: `client.SoftwareManagementReportsV3` · Source: `src/Verizon/Api/SoftwareManagementReportsV3.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCampaignDeviceStatus2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCampaignDeviceStatus2(GetCampaignDeviceStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `CampaignId`
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `LastSeenDeviceId`
- **Returns**: `V3CampaignDevice`
- **Error**: `ApiException<GetCampaignDeviceStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCampaignDeviceStatus2Request` | `src/Verizon/Requests/SoftwareManagementReportsV3/GetCampaignDeviceStatus2Request.cs` |
| `V3CampaignDevice` | `src/Verizon/Models/V3CampaignDevice.cs` |
| `GetCampaignDeviceStatus2Error` | `src/Verizon/Errors/GetCampaignDeviceStatus2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### GetCampaignHistoryByStatus2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCampaignHistoryByStatus2(GetCampaignHistoryByStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `CampaignStatus`
- **Query params (wire ← C#)**: `campaignStatus` ← `CampaignStatus`, `lastSeenCampaignId` ← `LastSeenCampaignId`
- **Returns**: `V3CampaignHistory`
- **Error**: `ApiException<GetCampaignHistoryByStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCampaignHistoryByStatus2Request` | `src/Verizon/Requests/SoftwareManagementReportsV3/GetCampaignHistoryByStatus2Request.cs` |
| `CampaignStatus` | `src/Verizon/Models/Enums/CampaignStatus.cs` |
| `V3CampaignHistory` | `src/Verizon/Models/V3CampaignHistory.cs` |
| `GetCampaignHistoryByStatus2Error` | `src/Verizon/Errors/GetCampaignHistoryByStatus2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### GetDeviceFirmwareUpgradeHistory3

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceFirmwareUpgradeHistory3(GetDeviceFirmwareUpgradeHistory3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `DeviceId`
- **Returns**: `IReadOnlyList<DeviceFirmwareUpgrade>`
- **Error**: `ApiException<GetDeviceFirmwareUpgradeHistory3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceFirmwareUpgradeHistory3Request` | `src/Verizon/Requests/SoftwareManagementReportsV3/GetDeviceFirmwareUpgradeHistory3Request.cs` |
| `DeviceFirmwareUpgrade` | `src/Verizon/Models/DeviceFirmwareUpgrade.cs` |
| `GetDeviceFirmwareUpgradeHistory3Error` | `src/Verizon/Errors/GetDeviceFirmwareUpgradeHistory3Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

