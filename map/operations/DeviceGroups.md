<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceGroups — operations

Accessor: `client.DeviceGroups` · Source: `src/Verizon/Api/DeviceGroups.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateDeviceGroup

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateDeviceGroup(CreateDeviceGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `ApiException<CreateDeviceGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateDeviceGroupOperationRequest` | `src/Verizon/Requests/DeviceGroups/CreateDeviceGroupOperationRequest.cs` |
| `CreateDeviceGroupRequest` | `src/Verizon/Models/CreateDeviceGroupRequest.cs` |
| `ConnectivityManagementSuccessResult` | `src/Verizon/Models/ConnectivityManagementSuccessResult.cs` |
| `CreateDeviceGroupError` | `src/Verizon/Errors/CreateDeviceGroupError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### DeleteDeviceGroup

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteDeviceGroup(DeleteDeviceGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`, `Gname`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `ApiException<DeleteDeviceGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDeviceGroupRequest` | `src/Verizon/Requests/DeviceGroups/DeleteDeviceGroupRequest.cs` |
| `ConnectivityManagementSuccessResult` | `src/Verizon/Models/ConnectivityManagementSuccessResult.cs` |
| `DeleteDeviceGroupError` | `src/Verizon/Errors/DeleteDeviceGroupError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### GetDeviceGroupInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceGroupInformation(GetDeviceGroupInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`, `Gname`
- **Query params (wire ← C#)**: `next` ← `Next`
- **Returns**: `DeviceGroupDevicesData`
- **Error**: `ApiException<GetDeviceGroupInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceGroupInformationRequest` | `src/Verizon/Requests/DeviceGroups/GetDeviceGroupInformationRequest.cs` |
| `DeviceGroupDevicesData` | `src/Verizon/Models/DeviceGroupDevicesData.cs` |
| `GetDeviceGroupInformationError` | `src/Verizon/Errors/GetDeviceGroupInformationError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### ListDeviceGroups

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDeviceGroups(ListDeviceGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `IReadOnlyList<DeviceGroup>`
- **Error**: `ApiException<ListDeviceGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDeviceGroupsRequest` | `src/Verizon/Requests/DeviceGroups/ListDeviceGroupsRequest.cs` |
| `DeviceGroup` | `src/Verizon/Models/DeviceGroup.cs` |
| `ListDeviceGroupsError` | `src/Verizon/Errors/ListDeviceGroupsError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

### UpdateDeviceGroup

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDeviceGroup(UpdateDeviceGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`, `Gname`, `Body`
- **Returns**: `ConnectivityManagementSuccessResult`
- **Error**: `ApiException<UpdateDeviceGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateDeviceGroupRequest` | `src/Verizon/Requests/DeviceGroups/UpdateDeviceGroupRequest.cs` |
| `DeviceGroupUpdateRequest` | `src/Verizon/Models/DeviceGroupUpdateRequest.cs` |
| `ConnectivityManagementSuccessResult` | `src/Verizon/Models/ConnectivityManagementSuccessResult.cs` |
| `UpdateDeviceGroupError` | `src/Verizon/Errors/UpdateDeviceGroupError.cs` |
| `ConnectivityManagementResult` | `src/Verizon/Models/ConnectivityManagementResult.cs` |

