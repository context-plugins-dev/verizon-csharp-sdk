<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceManagement — operations

Accessor: `client.DeviceManagement` · Source: `src/Verizon/Api/DeviceManagement.cs` · 29 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateServiceForDevices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ActivateServiceForDevices(ActivateServiceForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<ActivateServiceForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateServiceForDevicesRequest` | `src/Verizon/Requests/DeviceManagement/ActivateServiceForDevicesRequest.cs` |
| `CarrierActivateRequest` | `src/Verizon/Models/CarrierActivateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `ActivateServiceForDevicesError` | `src/Verizon/Errors/ActivateServiceForDevicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### AddDevices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AddDevices(AddDevicesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<AddDevicesResult>`
- **Error**: `ApiException<AddDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddDevicesOperationRequest` | `src/Verizon/Requests/DeviceManagement/AddDevicesOperationRequest.cs` |
| `AddDevicesRequest` | `src/Verizon/Models/AddDevicesRequest.cs` |
| `AddDevicesResult` | `src/Verizon/Models/AddDevicesResult.cs` |
| `AddDevicesError` | `src/Verizon/Errors/AddDevicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### BilledUsageInfo

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `BilledUsageInfo(BilledUsageInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<BilledUsageInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BilledUsageInfoRequest` | `src/Verizon/Requests/DeviceManagement/BilledUsageInfoRequest.cs` |
| `BilledusageListRequest` | `src/Verizon/Models/BilledusageListRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `BilledUsageInfoError` | `src/Verizon/Errors/BilledUsageInfoError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ChangeDevicesServicePlan

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ChangeDevicesServicePlan(ChangeDevicesServicePlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<ChangeDevicesServicePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeDevicesServicePlanRequest` | `src/Verizon/Requests/DeviceManagement/ChangeDevicesServicePlanRequest.cs` |
| `ServicePlanUpdateRequest` | `src/Verizon/Models/ServicePlanUpdateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `ChangeDevicesServicePlanError` | `src/Verizon/Errors/ChangeDevicesServicePlanError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### CheckDevicesAvailabilityForActivation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CheckDevicesAvailabilityForActivation(CheckDevicesAvailabilityForActivationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<CheckDevicesAvailabilityForActivationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckDevicesAvailabilityForActivationRequest` | `src/Verizon/Requests/DeviceManagement/CheckDevicesAvailabilityForActivationRequest.cs` |
| `DeviceActivationRequest` | `src/Verizon/Models/DeviceActivationRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `CheckDevicesAvailabilityForActivationError` | `src/Verizon/Errors/CheckDevicesAvailabilityForActivationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### DeactivateServiceForDevices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeactivateServiceForDevices(DeactivateServiceForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<DeactivateServiceForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeactivateServiceForDevicesRequest` | `src/Verizon/Requests/DeviceManagement/DeactivateServiceForDevicesRequest.cs` |
| `CarrierDeactivateRequest` | `src/Verizon/Models/CarrierDeactivateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `DeactivateServiceForDevicesError` | `src/Verizon/Errors/DeactivateServiceForDevicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### DeleteDeactivatedDevices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteDeactivatedDevices(DeleteDeactivatedDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DeleteDevicesResult>`
- **Error**: `ApiException<DeleteDeactivatedDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDeactivatedDevicesRequest` | `src/Verizon/Requests/DeviceManagement/DeleteDeactivatedDevicesRequest.cs` |
| `DeleteDevicesRequest` | `src/Verizon/Models/DeleteDevicesRequest.cs` |
| `DeleteDevicesResult` | `src/Verizon/Models/DeleteDevicesResult.cs` |
| `DeleteDeactivatedDevicesError` | `src/Verizon/Errors/DeleteDeactivatedDevicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### DeviceUpload

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceUpload(DeviceUploadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<DeviceUploadError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceUploadOperationRequest` | `src/Verizon/Requests/DeviceManagement/DeviceUploadOperationRequest.cs` |
| `DeviceUploadRequest` | `src/Verizon/Models/DeviceUploadRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `DeviceUploadError` | `src/Verizon/Errors/DeviceUploadError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### DeviceUploadStatus

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceUploadStatus(DeviceUploadStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<DeviceUploadStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceUploadStatusRequest` | `src/Verizon/Requests/DeviceManagement/DeviceUploadStatusRequest.cs` |
| `CheckOrderStatusRequest` | `src/Verizon/Models/CheckOrderStatusRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `DeviceUploadStatusError` | `src/Verizon/Errors/DeviceUploadStatusError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### GetDeviceExtendedDiagnosticInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceExtendedDiagnosticInformation(GetDeviceExtendedDiagnosticInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceExtendedDiagnosticsResult`
- **Error**: `ApiException<GetDeviceExtendedDiagnosticInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceExtendedDiagnosticInformationRequest` | `src/Verizon/Requests/DeviceManagement/GetDeviceExtendedDiagnosticInformationRequest.cs` |
| `DeviceExtendedDiagnosticsRequest` | `src/Verizon/Models/DeviceExtendedDiagnosticsRequest.cs` |
| `DeviceExtendedDiagnosticsResult` | `src/Verizon/Models/DeviceExtendedDiagnosticsResult.cs` |
| `GetDeviceExtendedDiagnosticInformationError` | `src/Verizon/Errors/GetDeviceExtendedDiagnosticInformationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### GetDeviceServiceSuspensionStatus

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceServiceSuspensionStatus(GetDeviceServiceSuspensionStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<GetDeviceServiceSuspensionStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceServiceSuspensionStatusRequest` | `src/Verizon/Requests/DeviceManagement/GetDeviceServiceSuspensionStatusRequest.cs` |
| `DeviceSuspensionStatusRequest` | `src/Verizon/Models/DeviceSuspensionStatusRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `GetDeviceServiceSuspensionStatusError` | `src/Verizon/Errors/GetDeviceServiceSuspensionStatusError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListCurrentDevicesPrlVersion

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListCurrentDevicesPrlVersion(ListCurrentDevicesPrlVersionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<ListCurrentDevicesPrlVersionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCurrentDevicesPrlVersionRequest` | `src/Verizon/Requests/DeviceManagement/ListCurrentDevicesPrlVersionRequest.cs` |
| `DevicePrlListRequest` | `src/Verizon/Models/DevicePrlListRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `ListCurrentDevicesPrlVersionError` | `src/Verizon/Errors/ListCurrentDevicesPrlVersionError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListDevicesInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesInformation(ListDevicesInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountDeviceListResult`
- **Error**: `ApiException<ListDevicesInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDevicesInformationRequest` | `src/Verizon/Requests/DeviceManagement/ListDevicesInformationRequest.cs` |
| `AccountDeviceListRequest` | `src/Verizon/Models/AccountDeviceListRequest.cs` |
| `AccountDeviceListResult` | `src/Verizon/Models/AccountDeviceListResult.cs` |
| `ListDevicesInformationError` | `src/Verizon/Errors/ListDevicesInformationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListDevicesProvisioningHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesProvisioningHistory(ListDevicesProvisioningHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DeviceProvisioningHistoryListResult>`
- **Error**: `ApiException<ListDevicesProvisioningHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDevicesProvisioningHistoryRequest` | `src/Verizon/Requests/DeviceManagement/ListDevicesProvisioningHistoryRequest.cs` |
| `DeviceProvisioningHistoryListRequest` | `src/Verizon/Models/DeviceProvisioningHistoryListRequest.cs` |
| `DeviceProvisioningHistoryListResult` | `src/Verizon/Models/DeviceProvisioningHistoryListResult.cs` |
| `ListDevicesProvisioningHistoryError` | `src/Verizon/Errors/ListDevicesProvisioningHistoryError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListDevicesUsageHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesUsageHistory(ListDevicesUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceUsageListResult`
- **Error**: `ApiException<ListDevicesUsageHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDevicesUsageHistoryRequest` | `src/Verizon/Requests/DeviceManagement/ListDevicesUsageHistoryRequest.cs` |
| `DeviceUsageListRequest` | `src/Verizon/Models/DeviceUsageListRequest.cs` |
| `DeviceUsageListResult` | `src/Verizon/Models/DeviceUsageListResult.cs` |
| `ListDevicesUsageHistoryError` | `src/Verizon/Errors/ListDevicesUsageHistoryError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListDevicesWithImeiIccidMismatch

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesWithImeiIccidMismatch(ListDevicesWithImeiIccidMismatchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceMismatchListResult`
- **Error**: `ApiException<ListDevicesWithImeiIccidMismatchError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDevicesWithImeiIccidMismatchRequest` | `src/Verizon/Requests/DeviceManagement/ListDevicesWithImeiIccidMismatchRequest.cs` |
| `DeviceMismatchListRequest` | `src/Verizon/Models/DeviceMismatchListRequest.cs` |
| `DeviceMismatchListResult` | `src/Verizon/Models/DeviceMismatchListResult.cs` |
| `ListDevicesWithImeiIccidMismatchError` | `src/Verizon/Errors/ListDevicesWithImeiIccidMismatchError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### MoveDevicesWithinAccountsOfProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `MoveDevicesWithinAccountsOfProfile(MoveDevicesWithinAccountsOfProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<MoveDevicesWithinAccountsOfProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MoveDevicesWithinAccountsOfProfileRequest` | `src/Verizon/Requests/DeviceManagement/MoveDevicesWithinAccountsOfProfileRequest.cs` |
| `MoveDeviceRequest` | `src/Verizon/Models/MoveDeviceRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `MoveDevicesWithinAccountsOfProfileError` | `src/Verizon/Errors/MoveDevicesWithinAccountsOfProfileError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### RestoreServiceForSuspendedDevices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RestoreServiceForSuspendedDevices(RestoreServiceForSuspendedDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<RestoreServiceForSuspendedDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RestoreServiceForSuspendedDevicesRequest` | `src/Verizon/Requests/DeviceManagement/RestoreServiceForSuspendedDevicesRequest.cs` |
| `CarrierActionsRequest` | `src/Verizon/Models/CarrierActionsRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `RestoreServiceForSuspendedDevicesError` | `src/Verizon/Errors/RestoreServiceForSuspendedDevicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### RetrieveAggregateDeviceUsageHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveAggregateDeviceUsageHistory(RetrieveAggregateDeviceUsageHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<RetrieveAggregateDeviceUsageHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveAggregateDeviceUsageHistoryRequest` | `src/Verizon/Requests/DeviceManagement/RetrieveAggregateDeviceUsageHistoryRequest.cs` |
| `DeviceAggregateUsageListRequest` | `src/Verizon/Models/DeviceAggregateUsageListRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `RetrieveAggregateDeviceUsageHistoryError` | `src/Verizon/Errors/RetrieveAggregateDeviceUsageHistoryError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### RetrieveDeviceConnectionHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveDeviceConnectionHistory(RetrieveDeviceConnectionHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ConnectionHistoryResult`
- **Error**: `ApiException<RetrieveDeviceConnectionHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveDeviceConnectionHistoryRequest` | `src/Verizon/Requests/DeviceManagement/RetrieveDeviceConnectionHistoryRequest.cs` |
| `DeviceConnectionListRequest` | `src/Verizon/Models/DeviceConnectionListRequest.cs` |
| `ConnectionHistoryResult` | `src/Verizon/Models/ConnectionHistoryResult.cs` |
| `RetrieveDeviceConnectionHistoryError` | `src/Verizon/Errors/RetrieveDeviceConnectionHistoryError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### SuspendServiceForDevices

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SuspendServiceForDevices(SuspendServiceForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<SuspendServiceForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SuspendServiceForDevicesRequest` | `src/Verizon/Requests/DeviceManagement/SuspendServiceForDevicesRequest.cs` |
| `CarrierActionsRequest` | `src/Verizon/Models/CarrierActionsRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `SuspendServiceForDevicesError` | `src/Verizon/Errors/SuspendServiceForDevicesError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UpdateDeviceId

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDeviceId(UpdateDeviceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ServiceType`, `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UpdateDeviceIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDeviceIdRequest` | `src/Verizon/Requests/DeviceManagement/UpdateDeviceIdRequest.cs` |
| `ChangeDeviceIdRequest` | `src/Verizon/Models/ChangeDeviceIdRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UpdateDeviceIdError` | `src/Verizon/Errors/UpdateDeviceIdError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UpdateDevicesContactInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDevicesContactInformation(UpdateDevicesContactInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UpdateDevicesContactInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDevicesContactInformationRequest` | `src/Verizon/Requests/DeviceManagement/UpdateDevicesContactInformationRequest.cs` |
| `ContactInfoUpdateRequest` | `src/Verizon/Models/ContactInfoUpdateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UpdateDevicesContactInformationError` | `src/Verizon/Errors/UpdateDevicesContactInformationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UpdateDevicesCostCenterCode

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDevicesCostCenterCode(UpdateDevicesCostCenterCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UpdateDevicesCostCenterCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDevicesCostCenterCodeRequest` | `src/Verizon/Requests/DeviceManagement/UpdateDevicesCostCenterCodeRequest.cs` |
| `DeviceCostCenterRequest` | `src/Verizon/Models/DeviceCostCenterRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UpdateDevicesCostCenterCodeError` | `src/Verizon/Errors/UpdateDevicesCostCenterCodeError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UpdateDevicesCustomFields

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDevicesCustomFields(UpdateDevicesCustomFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UpdateDevicesCustomFieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDevicesCustomFieldsRequest` | `src/Verizon/Requests/DeviceManagement/UpdateDevicesCustomFieldsRequest.cs` |
| `CustomFieldsUpdateRequest` | `src/Verizon/Models/CustomFieldsUpdateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UpdateDevicesCustomFieldsError` | `src/Verizon/Errors/UpdateDevicesCustomFieldsError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UpdateDevicesState

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDevicesState(UpdateDevicesStateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UpdateDevicesStateError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDevicesStateRequest` | `src/Verizon/Requests/DeviceManagement/UpdateDevicesStateRequest.cs` |
| `GoToStateRequest` | `src/Verizon/Models/GoToStateRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UpdateDevicesStateError` | `src/Verizon/Errors/UpdateDevicesStateError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UploadActivateDevice

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UploadActivateDevice(UploadActivateDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UploadActivateDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadActivateDeviceRequest` | `src/Verizon/Requests/DeviceManagement/UploadActivateDeviceRequest.cs` |
| `UploadsActivatesDeviceRequest` | `src/Verizon/Models/UploadsActivatesDeviceRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UploadActivateDeviceError` | `src/Verizon/Errors/UploadActivateDeviceError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UsageSegmentationLabelAssociation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UsageSegmentationLabelAssociation(UsageSegmentationLabelAssociationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UsageSegmentationLabelAssociationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsageSegmentationLabelAssociationRequest` | `src/Verizon/Requests/DeviceManagement/UsageSegmentationLabelAssociationRequest.cs` |
| `AssociateLabelRequest` | `src/Verizon/Models/AssociateLabelRequest.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UsageSegmentationLabelAssociationError` | `src/Verizon/Errors/UsageSegmentationLabelAssociationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UsageSegmentationLabelDeletion

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UsageSegmentationLabelDeletion(UsageSegmentationLabelDeletionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `LabelList`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`, `LabelList` ← `LabelList`
- **Returns**: `DeviceManagementResult`
- **Error**: `ApiException<UsageSegmentationLabelDeletionError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsageSegmentationLabelDeletionRequest` | `src/Verizon/Requests/DeviceManagement/UsageSegmentationLabelDeletionRequest.cs` |
| `LabelsList` | `src/Verizon/Models/LabelsList.cs` |
| `DeviceManagementResult` | `src/Verizon/Models/DeviceManagementResult.cs` |
| `UsageSegmentationLabelDeletionError` | `src/Verizon/Errors/UsageSegmentationLabelDeletionError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

