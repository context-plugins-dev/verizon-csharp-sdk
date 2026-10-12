<!-- Generated file — do not edit; regenerated with the SDK. -->

# CampaignsV3 — operations

Accessor: `client.CampaignsV3` · Source: `src/Verizon/Api/CampaignsV3.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelCampaign2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CancelCampaign2(CancelCampaign2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `CampaignId`
- **Returns**: `FotaV3SuccessResult`
- **Error**: `ApiException<CancelCampaign2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelCampaign2Request` | `src/Verizon/Requests/CampaignsV3/CancelCampaign2Request.cs` |
| `FotaV3SuccessResult` | `src/Verizon/Models/FotaV3SuccessResult.cs` |
| `CancelCampaign2Error` | `src/Verizon/Errors/CancelCampaign2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### GetCampaignInformation2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCampaignInformation2(GetCampaignInformation2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `CampaignId`
- **Returns**: `Campaign`
- **Error**: `ApiException<GetCampaignInformation2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCampaignInformation2Request` | `src/Verizon/Requests/CampaignsV3/GetCampaignInformation2Request.cs` |
| `Campaign` | `src/Verizon/Models/Campaign.cs` |
| `GetCampaignInformation2Error` | `src/Verizon/Errors/GetCampaignInformation2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### ScheduleCampaignFirmwareUpgrade2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ScheduleCampaignFirmwareUpgrade2(ScheduleCampaignFirmwareUpgrade2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `Body`
- **Returns**: `FirmwareCampaign`
- **Error**: `ApiException<ScheduleCampaignFirmwareUpgrade2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleCampaignFirmwareUpgrade2Request` | `src/Verizon/Requests/CampaignsV3/ScheduleCampaignFirmwareUpgrade2Request.cs` |
| `CampaignFirmwareUpgrade` | `src/Verizon/Models/CampaignFirmwareUpgrade.cs` |
| `FirmwareCampaign` | `src/Verizon/Models/FirmwareCampaign.cs` |
| `ScheduleCampaignFirmwareUpgrade2Error` | `src/Verizon/Errors/ScheduleCampaignFirmwareUpgrade2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### UpdateCampaignDates2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateCampaignDates2(UpdateCampaignDates2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `CampaignId`, `Body`
- **Returns**: `FirmwareCampaign`
- **Error**: `ApiException<UpdateCampaignDates2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCampaignDates2Request` | `src/Verizon/Requests/CampaignsV3/UpdateCampaignDates2Request.cs` |
| `V3ChangeCampaignDatesRequest` | `src/Verizon/Models/V3ChangeCampaignDatesRequest.cs` |
| `FirmwareCampaign` | `src/Verizon/Models/FirmwareCampaign.cs` |
| `UpdateCampaignDates2Error` | `src/Verizon/Errors/UpdateCampaignDates2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### UpdateCampaignFirmwareDevices2

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateCampaignFirmwareDevices2(UpdateCampaignFirmwareDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `CampaignId`, `Body`
- **Returns**: `V3AddOrRemoveDeviceResult`
- **Error**: `ApiException<UpdateCampaignFirmwareDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCampaignFirmwareDevices2Request` | `src/Verizon/Requests/CampaignsV3/UpdateCampaignFirmwareDevices2Request.cs` |
| `V3AddOrRemoveDeviceRequest` | `src/Verizon/Models/V3AddOrRemoveDeviceRequest.cs` |
| `V3AddOrRemoveDeviceResult` | `src/Verizon/Models/V3AddOrRemoveDeviceResult.cs` |
| `UpdateCampaignFirmwareDevices2Error` | `src/Verizon/Errors/UpdateCampaignFirmwareDevices2Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

