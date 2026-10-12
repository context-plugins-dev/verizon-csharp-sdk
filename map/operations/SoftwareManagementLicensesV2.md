<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementLicensesV2 — operations

Accessor: `client.SoftwareManagementLicensesV2` · Source: `src/Verizon/Api/SoftwareManagementLicensesV2.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicensesToDevices2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AssignLicensesToDevices2(AssignLicensesToDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `V2LicensesAssignedRemovedResult`
- **Error**: `ApiException<AssignLicensesToDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssignLicensesToDevices2Request` | `src/Verizon/Requests/SoftwareManagementLicensesV2/AssignLicensesToDevices2Request.cs` |
| `V2LicensesAssignedRemovedResult` | `src/Verizon/Models/V2LicensesAssignedRemovedResult.cs` |
| `AssignLicensesToDevices2Error` | `src/Verizon/Errors/AssignLicensesToDevices2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### CreateListOfLicensesToRemove2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateListOfLicensesToRemove2(CreateListOfLicensesToRemove2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `V2ListOfLicensesToRemoveResult`
- **Error**: `ApiException<CreateListOfLicensesToRemove2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateListOfLicensesToRemove2Request` | `src/Verizon/Requests/SoftwareManagementLicensesV2/CreateListOfLicensesToRemove2Request.cs` |
| `V2ListOfLicensesToRemoveResult` | `src/Verizon/Models/V2ListOfLicensesToRemoveResult.cs` |
| `CreateListOfLicensesToRemove2Error` | `src/Verizon/Errors/CreateListOfLicensesToRemove2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### DeleteListOfLicensesToRemove2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteListOfLicensesToRemove2(DeleteListOfLicensesToRemove2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `FotaV2SuccessResult`
- **Error**: `ApiException<DeleteListOfLicensesToRemove2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteListOfLicensesToRemove2Request` | `src/Verizon/Requests/SoftwareManagementLicensesV2/DeleteListOfLicensesToRemove2Request.cs` |
| `FotaV2SuccessResult` | `src/Verizon/Models/FotaV2SuccessResult.cs` |
| `DeleteListOfLicensesToRemove2Error` | `src/Verizon/Errors/DeleteListOfLicensesToRemove2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### GetAccountLicenseStatus2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountLicenseStatus2(GetAccountLicenseStatus2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `LastSeenDeviceId`
- **Returns**: `V2LicenseSummary`
- **Error**: `ApiException<GetAccountLicenseStatus2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountLicenseStatus2Request` | `src/Verizon/Requests/SoftwareManagementLicensesV2/GetAccountLicenseStatus2Request.cs` |
| `V2LicenseSummary` | `src/Verizon/Models/V2LicenseSummary.cs` |
| `GetAccountLicenseStatus2Error` | `src/Verizon/Errors/GetAccountLicenseStatus2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### ListLicensesToRemove2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListLicensesToRemove2(ListLicensesToRemove2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Query params (wire ← C#)**: `startIndex` ← `StartIndex`
- **Returns**: `V2ListOfLicensesToRemove`
- **Error**: `ApiException<ListLicensesToRemove2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListLicensesToRemove2Request` | `src/Verizon/Requests/SoftwareManagementLicensesV2/ListLicensesToRemove2Request.cs` |
| `V2ListOfLicensesToRemove` | `src/Verizon/Models/V2ListOfLicensesToRemove.cs` |
| `ListLicensesToRemove2Error` | `src/Verizon/Errors/ListLicensesToRemove2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### RemoveLicensesFromDevices2

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RemoveLicensesFromDevices2(RemoveLicensesFromDevices2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `V2LicensesAssignedRemovedResult`
- **Error**: `ApiException<RemoveLicensesFromDevices2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveLicensesFromDevices2Request` | `src/Verizon/Requests/SoftwareManagementLicensesV2/RemoveLicensesFromDevices2Request.cs` |
| `V2LicensesAssignedRemovedResult` | `src/Verizon/Models/V2LicensesAssignedRemovedResult.cs` |
| `RemoveLicensesFromDevices2Error` | `src/Verizon/Errors/RemoveLicensesFromDevices2Error.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

