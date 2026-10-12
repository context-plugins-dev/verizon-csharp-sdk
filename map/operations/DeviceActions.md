<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceActions — operations

Accessor: `client.DeviceActions` · Source: `src/Verizon/Api/DeviceActions.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AccountInformation(AccountInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `AccountDetails`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountInformationRequest` | `src/Verizon/Requests/DeviceActions/AccountInformationRequest.cs` |
| `AccountDetails` | `src/Verizon/Models/AccountDetails.cs` |

### AggregateUsage

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AggregateUsage(AggregateUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AggregateUsageRequest` | `src/Verizon/Requests/DeviceActions/AggregateUsageRequest.cs` |
| `AggregateUsage` | `src/Verizon/Models/AggregateUsage.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### DailyUsage

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DailyUsage(DailyUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DailyUsageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DailyUsageRequest` | `src/Verizon/Requests/DeviceActions/DailyUsageRequest.cs` |
| `DailyUsage` | `src/Verizon/Models/DailyUsage.cs` |
| `DailyUsageResponse` | `src/Verizon/Models/DailyUsageResponse.cs` |

### GetAsynchronousRequestStatus

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAsynchronousRequestStatus(GetAsynchronousRequestStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `RequestId`
- **Returns**: `StatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAsynchronousRequestStatusRequest` | `src/Verizon/Requests/DeviceActions/GetAsynchronousRequestStatusRequest.cs` |
| `StatusResponse` | `src/Verizon/Models/StatusResponse.cs` |

### RetrieveDeviceProvisioningHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveDeviceProvisioningHistory(RetrieveDeviceProvisioningHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDeviceProvisioningHistoryRequest` | `src/Verizon/Requests/DeviceActions/RetrieveDeviceProvisioningHistoryRequest.cs` |
| `ProvhistoryRequest` | `src/Verizon/Models/ProvhistoryRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### RetrieveTheGlobalDeviceList

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveTheGlobalDeviceList(RetrieveTheGlobalDeviceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTheGlobalDeviceListRequest` | `src/Verizon/Requests/DeviceActions/RetrieveTheGlobalDeviceListRequest.cs` |
| `GetDeviceListWithProfilesRequest` | `src/Verizon/Models/GetDeviceListWithProfilesRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### ServicePlanList

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ServicePlanList(ServicePlanListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `AccountDetails`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ServicePlanListRequest` | `src/Verizon/Requests/DeviceActions/ServicePlanListRequest.cs` |
| `AccountDetails` | `src/Verizon/Models/AccountDetails.cs` |

