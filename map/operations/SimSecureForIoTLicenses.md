<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimSecureForIoTLicenses — operations

Accessor: `client.SimSecureForIoTLicenses` · Source: `src/Verizon/Api/SimSecureForIoTLicenses.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicenseToDevices

- **Server group**: `M2M`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AssignLicenseToDevices(AssignLicenseToDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SecuritySuccessResult`
- **Error**: `ApiException<AssignLicenseToDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetSecurityResult(out SecurityResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssignLicenseToDevicesRequest` | `src/Verizon/Requests/SimSecureForIoTLicenses/AssignLicenseToDevicesRequest.cs` |
| `AssignLicenseRequest` | `src/Verizon/Models/AssignLicenseRequest.cs` |
| `SecuritySuccessResult` | `src/Verizon/Models/SecuritySuccessResult.cs` |
| `AssignLicenseToDevicesError` | `src/Verizon/Errors/AssignLicenseToDevicesError.cs` |
| `SecurityResult` | `src/Verizon/Models/SecurityResult.cs` |

### UnassignLicenseToDevices

- **Server group**: `M2M`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UnassignLicenseToDevices(UnassignLicenseToDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `XRequestId`
- **Returns**: `SecuritySuccessResult`
- **Error**: `ApiException<UnassignLicenseToDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetSecurityResult(out SecurityResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnassignLicenseToDevicesRequest` | `src/Verizon/Requests/SimSecureForIoTLicenses/UnassignLicenseToDevicesRequest.cs` |
| `SecuritySuccessResult` | `src/Verizon/Models/SecuritySuccessResult.cs` |
| `UnassignLicenseToDevicesError` | `src/Verizon/Errors/UnassignLicenseToDevicesError.cs` |
| `SecurityResult` | `src/Verizon/Models/SecurityResult.cs` |

