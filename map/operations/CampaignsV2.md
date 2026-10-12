<!-- Generated file — do not edit; regenerated with the SDK. -->

# CampaignsV2 — operations

Accessor: `client.CampaignsV2` · Source: `src/Verizon/Api/CampaignsV2.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelCampaign

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CancelCampaign(CancelCampaignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `CampaignId`
- **Returns**: `FotaV2SuccessResult`
- **Error**: `ApiException<CancelCampaignError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelCampaignRequest` | `src/Verizon/Requests/CampaignsV2/CancelCampaignRequest.cs` |
| `FotaV2SuccessResult` | `src/Verizon/Models/FotaV2SuccessResult.cs` |
| `CancelCampaignError` | `src/Verizon/Errors/CancelCampaignError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### GetCampaignInformation

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetCampaignInformation(GetCampaignInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `CampaignId`
- **Returns**: `CampaignSoftware`
- **Error**: `ApiException<GetCampaignInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCampaignInformationRequest` | `src/Verizon/Requests/CampaignsV2/GetCampaignInformationRequest.cs` |
| `CampaignSoftware` | `src/Verizon/Models/CampaignSoftware.cs` |
| `GetCampaignInformationError` | `src/Verizon/Errors/GetCampaignInformationError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ScheduleCampaignFirmwareUpgrade

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ScheduleCampaignFirmwareUpgrade(ScheduleCampaignFirmwareUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `CampaignSoftware`
- **Error**: `ApiException<ScheduleCampaignFirmwareUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleCampaignFirmwareUpgradeRequest` | `src/Verizon/Requests/CampaignsV2/ScheduleCampaignFirmwareUpgradeRequest.cs` |
| `CampaignSoftware` | `src/Verizon/Models/CampaignSoftware.cs` |
| `ScheduleCampaignFirmwareUpgradeError` | `src/Verizon/Errors/ScheduleCampaignFirmwareUpgradeError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ScheduleFileUpgrade

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ScheduleFileUpgrade(ScheduleFileUpgradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `UploadAndScheduleFileResponse`
- **Error**: `ApiException<ScheduleFileUpgradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleFileUpgradeRequest` | `src/Verizon/Requests/CampaignsV2/ScheduleFileUpgradeRequest.cs` |
| `UploadAndScheduleFileRequest` | `src/Verizon/Models/UploadAndScheduleFileRequest.cs` |
| `UploadAndScheduleFileResponse` | `src/Verizon/Models/UploadAndScheduleFileResponse.cs` |
| `ScheduleFileUpgradeError` | `src/Verizon/Errors/ScheduleFileUpgradeError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ScheduleSwUpgradeHttpDevices

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ScheduleSwUpgradeHttpDevices(ScheduleSwUpgradeHttpDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `UploadAndScheduleFileResponse`
- **Error**: `ApiException<ScheduleSwUpgradeHttpDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleSwUpgradeHttpDevicesRequest` | `src/Verizon/Requests/CampaignsV2/ScheduleSwUpgradeHttpDevicesRequest.cs` |
| `SchedulesSoftwareUpgradeRequest` | `src/Verizon/Models/SchedulesSoftwareUpgradeRequest.cs` |
| `UploadAndScheduleFileResponse` | `src/Verizon/Models/UploadAndScheduleFileResponse.cs` |
| `ScheduleSwUpgradeHttpDevicesError` | `src/Verizon/Errors/ScheduleSwUpgradeHttpDevicesError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### UpdateCampaignDates

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateCampaignDates(UpdateCampaignDatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `CampaignId`
- **Returns**: `CampaignSoftware`
- **Error**: `ApiException<UpdateCampaignDatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCampaignDatesRequest` | `src/Verizon/Requests/CampaignsV2/UpdateCampaignDatesRequest.cs` |
| `CampaignSoftware` | `src/Verizon/Models/CampaignSoftware.cs` |
| `UpdateCampaignDatesError` | `src/Verizon/Errors/UpdateCampaignDatesError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### UpdateCampaignFirmwareDevices

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateCampaignFirmwareDevices(UpdateCampaignFirmwareDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `CampaignId`
- **Returns**: `V2AddOrRemoveDeviceResult`
- **Error**: `ApiException<UpdateCampaignFirmwareDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCampaignFirmwareDevicesRequest` | `src/Verizon/Requests/CampaignsV2/UpdateCampaignFirmwareDevicesRequest.cs` |
| `V2AddOrRemoveDeviceResult` | `src/Verizon/Models/V2AddOrRemoveDeviceResult.cs` |
| `UpdateCampaignFirmwareDevicesError` | `src/Verizon/Errors/UpdateCampaignFirmwareDevicesError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

