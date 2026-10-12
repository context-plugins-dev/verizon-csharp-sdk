<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceProfileManagement — operations

Accessor: `client.DeviceProfileManagement` · Source: `src/Verizon/Api/DeviceProfileManagement.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateDeviceThroughProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ActivateDeviceThroughProfile(ActivateDeviceThroughProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<ActivateDeviceThroughProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateDeviceThroughProfileRequest` | `src/Verizon/Requests/DeviceProfileManagement/ActivateDeviceThroughProfileRequest.cs` |
| `ActivateDeviceProfileRequest` | `src/Verizon/Models/ActivateDeviceProfileRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `ActivateDeviceThroughProfileError` | `src/Verizon/Errors/ActivateDeviceThroughProfileError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### ProfileToActivateDevice

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ProfileToActivateDevice(ProfileToActivateDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<ProfileToActivateDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileToActivateDeviceRequest` | `src/Verizon/Requests/DeviceProfileManagement/ProfileToActivateDeviceRequest.cs` |
| `ProfileRequest` | `src/Verizon/Models/ProfileRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `ProfileToActivateDeviceError` | `src/Verizon/Errors/ProfileToActivateDeviceError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### ProfileToDeactivateDevice

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ProfileToDeactivateDevice(ProfileToDeactivateDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<ProfileToDeactivateDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileToDeactivateDeviceRequest` | `src/Verizon/Requests/DeviceProfileManagement/ProfileToDeactivateDeviceRequest.cs` |
| `DeactivateDeviceProfileRequest` | `src/Verizon/Models/DeactivateDeviceProfileRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `ProfileToDeactivateDeviceError` | `src/Verizon/Errors/ProfileToDeactivateDeviceError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

### ProfileToSetFallbackAttribute

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ProfileToSetFallbackAttribute(ProfileToSetFallbackAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RequestResponse`
- **Error**: `ApiException<ProfileToSetFallbackAttributeError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileToSetFallbackAttributeRequest` | `src/Verizon/Requests/DeviceProfileManagement/ProfileToSetFallbackAttributeRequest.cs` |
| `SetFallbackAttributeRequest` | `src/Verizon/Models/SetFallbackAttributeRequest.cs` |
| `RequestResponse` | `src/Verizon/Models/RequestResponse.cs` |
| `ProfileToSetFallbackAttributeError` | `src/Verizon/Errors/ProfileToSetFallbackAttributeError.cs` |
| `RestErrorResponse` | `src/Verizon/Models/RestErrorResponse.cs` |

