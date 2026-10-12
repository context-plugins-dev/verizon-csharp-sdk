<!-- Generated file — do not edit; regenerated with the SDK. -->

# DevicesLocations — operations

Accessor: `client.DevicesLocations` · Source: `src/Verizon/Api/DevicesLocations.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelQueuedLocationReportGeneration

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CancelQueuedLocationReportGeneration(CancelQueuedLocationReportGenerationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `Txid`
- **Returns**: `TransactionId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelQueuedLocationReportGenerationRequest` | `src/Verizon/Requests/DevicesLocations/CancelQueuedLocationReportGenerationRequest.cs` |
| `TransactionId` | `src/Verizon/Models/TransactionId.cs` |

### CreateLocationReport

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateLocationReport(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AsynchronousLocationRequestResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AsynchronousLocationRequestResult` | `src/Verizon/Models/AsynchronousLocationRequestResult.cs` |

### GetLocationReportStatus

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetLocationReportStatus(GetLocationReportStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `Txid`
- **Returns**: `LocationReportStatus`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetLocationReportStatusRequest` | `src/Verizon/Requests/DevicesLocations/GetLocationReportStatusRequest.cs` |
| `LocationReportStatus` | `src/Verizon/Models/LocationReportStatus.cs` |

### ListDevicesLocationsAsynchronous

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesLocationsAsynchronous(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SynchronousLocationRequestResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SynchronousLocationRequestResult` | `src/Verizon/Models/SynchronousLocationRequestResult.cs` |

### ListDevicesLocationsSynchronous

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesLocationsSynchronous(ListDevicesLocationsSynchronousRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<Location>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDevicesLocationsSynchronousRequest` | `src/Verizon/Requests/DevicesLocations/ListDevicesLocationsSynchronousRequest.cs` |
| `LocationRequest` | `src/Verizon/Models/LocationRequest.cs` |
| `Location` | `src/Verizon/Models/Location.cs` |

### RetrieveLocationReport

- **Server group**: `DeviceLocation`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveLocationReport(RetrieveLocationReportRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `Txid`, `Startindex`
- **Returns**: `LocationReport`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationReportRequest` | `src/Verizon/Requests/DevicesLocations/RetrieveLocationReportRequest.cs` |
| `LocationReport` | `src/Verizon/Models/LocationReport.cs` |

