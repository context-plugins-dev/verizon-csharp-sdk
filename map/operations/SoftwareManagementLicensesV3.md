<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementLicensesV3 — operations

Accessor: `client.SoftwareManagementLicensesV3` · Source: `src/Verizon/Api/SoftwareManagementLicensesV3.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicensesToDevices3

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AssignLicensesToDevices3(AssignLicensesToDevices3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `V3LicenseAssignedRemovedResult`
- **Error**: `ApiException<AssignLicensesToDevices3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssignLicensesToDevices3Request` | `src/Verizon/Requests/SoftwareManagementLicensesV3/AssignLicensesToDevices3Request.cs` |
| `V3LicenseImei` | `src/Verizon/Models/V3LicenseImei.cs` |
| `V3LicenseAssignedRemovedResult` | `src/Verizon/Models/V3LicenseAssignedRemovedResult.cs` |
| `AssignLicensesToDevices3Error` | `src/Verizon/Errors/AssignLicensesToDevices3Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### GetAccountLicensesStatus

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountLicensesStatus(GetAccountLicensesStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `LastSeenDeviceId`
- **Returns**: `V3LicenseSummary`
- **Error**: `ApiException<GetAccountLicensesStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountLicensesStatusRequest` | `src/Verizon/Requests/SoftwareManagementLicensesV3/GetAccountLicensesStatusRequest.cs` |
| `V3LicenseSummary` | `src/Verizon/Models/V3LicenseSummary.cs` |
| `GetAccountLicensesStatusError` | `src/Verizon/Errors/GetAccountLicensesStatusError.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### RemoveLicensesFromDevices3

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RemoveLicensesFromDevices3(RemoveLicensesFromDevices3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `V3LicenseAssignedRemovedResult`
- **Error**: `ApiException<RemoveLicensesFromDevices3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveLicensesFromDevices3Request` | `src/Verizon/Requests/SoftwareManagementLicensesV3/RemoveLicensesFromDevices3Request.cs` |
| `V3LicenseImei` | `src/Verizon/Models/V3LicenseImei.cs` |
| `V3LicenseAssignedRemovedResult` | `src/Verizon/Models/V3LicenseAssignedRemovedResult.cs` |
| `RemoveLicensesFromDevices3Error` | `src/Verizon/Errors/RemoveLicensesFromDevices3Error.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

