<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManagingESimProfiles — operations

Accessor: `client.ManagingESimProfiles` · Source: `src/Verizon/Api/ManagingESimProfiles.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateADeviceProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ActivateADeviceProfile(ActivateADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActivateADeviceProfileRequest` | `src/Verizon/Requests/ManagingESimProfiles/ActivateADeviceProfileRequest.cs` |
| `GioProfileRequest` | `src/Verizon/Models/GioProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### DeactivateADeviceProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeactivateADeviceProfile(DeactivateADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeactivateADeviceProfileRequest` | `src/Verizon/Requests/ManagingESimProfiles/DeactivateADeviceProfileRequest.cs` |
| `GioDeactivateDeviceProfileRequest` | `src/Verizon/Models/GioDeactivateDeviceProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### DeleteADeviceProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteADeviceProfile(DeleteADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteADeviceProfileRequest` | `src/Verizon/Requests/ManagingESimProfiles/DeleteADeviceProfileRequest.cs` |
| `DeviceProfileRequest` | `src/Verizon/Models/DeviceProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### DeviceSuspend

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceSuspend(DeviceSuspendRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeviceSuspendRequest` | `src/Verizon/Requests/ManagingESimProfiles/DeviceSuspendRequest.cs` |
| `GioProfileRequest` | `src/Verizon/Models/GioProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### DownloadADeviceProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DownloadADeviceProfile(DownloadADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DownloadADeviceProfileRequest` | `src/Verizon/Requests/ManagingESimProfiles/DownloadADeviceProfileRequest.cs` |
| `DeviceProfileRequest` | `src/Verizon/Models/DeviceProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### EnableADeviceProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `EnableADeviceProfile(EnableADeviceProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableADeviceProfileRequest` | `src/Verizon/Requests/ManagingESimProfiles/EnableADeviceProfileRequest.cs` |
| `DeviceProfileRequest` | `src/Verizon/Models/DeviceProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### EnableADeviceProfileForDownload

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `EnableADeviceProfileForDownload(EnableADeviceProfileForDownloadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableADeviceProfileForDownloadRequest` | `src/Verizon/Requests/ManagingESimProfiles/EnableADeviceProfileForDownloadRequest.cs` |
| `DeviceProfileRequest` | `src/Verizon/Models/DeviceProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### ProfileSuspend

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ProfileSuspend(ProfileSuspendRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProfileSuspendRequest` | `src/Verizon/Requests/ManagingESimProfiles/ProfileSuspendRequest.cs` |
| `GioProfileRequest` | `src/Verizon/Models/GioProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### ResumeProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ResumeProfile(ResumeProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ResumeProfileRequest` | `src/Verizon/Requests/ManagingESimProfiles/ResumeProfileRequest.cs` |
| `GioProfileRequest` | `src/Verizon/Models/GioProfileRequest.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

### SetFallback

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SetFallback(SetFallbackRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GioRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SetFallbackRequest` | `src/Verizon/Requests/ManagingESimProfiles/SetFallbackRequest.cs` |
| `FallBack` | `src/Verizon/Models/FallBack.cs` |
| `GioRequestResponse` | `src/Verizon/Models/GioRequestResponse.cs` |

