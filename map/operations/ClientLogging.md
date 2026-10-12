<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClientLogging — operations

Accessor: `client.ClientLogging` · Source: `src/Verizon/Api/ClientLogging.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DisableDeviceLogging

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DisableDeviceLogging(DisableDeviceLoggingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DisableDeviceLoggingError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableDeviceLoggingRequest` | `src/Verizon/Requests/ClientLogging/DisableDeviceLoggingRequest.cs` |
| `DisableDeviceLoggingError` | `src/Verizon/Errors/DisableDeviceLoggingError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### DisableLoggingForDevices

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DisableLoggingForDevices(DisableLoggingForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceIds`
- **Query params (wire ← C#)**: `deviceIds` ← `DeviceIds`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DisableLoggingForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DisableLoggingForDevicesRequest` | `src/Verizon/Requests/ClientLogging/DisableLoggingForDevicesRequest.cs` |
| `DisableLoggingForDevicesError` | `src/Verizon/Errors/DisableLoggingForDevicesError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### EnableDeviceLogging

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `EnableDeviceLogging(EnableDeviceLoggingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceId`
- **Returns**: `DeviceLoggingStatus`
- **Error**: `ApiException<EnableDeviceLoggingError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableDeviceLoggingRequest` | `src/Verizon/Requests/ClientLogging/EnableDeviceLoggingRequest.cs` |
| `DeviceLoggingStatus` | `src/Verizon/Models/DeviceLoggingStatus.cs` |
| `EnableDeviceLoggingError` | `src/Verizon/Errors/EnableDeviceLoggingError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### EnableLoggingForDevices

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `EnableLoggingForDevices(EnableLoggingForDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `IReadOnlyList<DeviceLoggingStatus>`
- **Error**: `ApiException<EnableLoggingForDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableLoggingForDevicesRequest` | `src/Verizon/Requests/ClientLogging/EnableLoggingForDevicesRequest.cs` |
| `DeviceLoggingStatus` | `src/Verizon/Models/DeviceLoggingStatus.cs` |
| `EnableLoggingForDevicesError` | `src/Verizon/Errors/EnableLoggingForDevicesError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ListDeviceLogs

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDeviceLogs(ListDeviceLogsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceId`
- **Returns**: `IReadOnlyList<DeviceLog>`
- **Error**: `ApiException<ListDeviceLogsError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDeviceLogsRequest` | `src/Verizon/Requests/ClientLogging/ListDeviceLogsRequest.cs` |
| `DeviceLog` | `src/Verizon/Models/DeviceLog.cs` |
| `ListDeviceLogsError` | `src/Verizon/Errors/ListDeviceLogsError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ListDevicesWithLoggingEnabled

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListDevicesWithLoggingEnabled(ListDevicesWithLoggingEnabledRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `IReadOnlyList<DeviceLoggingStatus>`
- **Error**: `ApiException<ListDevicesWithLoggingEnabledError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListDevicesWithLoggingEnabledRequest` | `src/Verizon/Requests/ClientLogging/ListDevicesWithLoggingEnabledRequest.cs` |
| `DeviceLoggingStatus` | `src/Verizon/Models/DeviceLoggingStatus.cs` |
| `ListDevicesWithLoggingEnabledError` | `src/Verizon/Errors/ListDevicesWithLoggingEnabledError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

