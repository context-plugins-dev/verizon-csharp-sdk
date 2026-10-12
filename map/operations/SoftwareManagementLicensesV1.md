<!-- Generated file — do not edit; regenerated with the SDK. -->

# SoftwareManagementLicensesV1 — operations

Accessor: `client.SoftwareManagementLicensesV1` · Source: `src/Verizon/Api/SoftwareManagementLicensesV1.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssignLicensesToDevices

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AssignLicensesToDevices(AssignLicensesToDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `Body`
- **Returns**: `V1LicensesAssignedRemovedResult`
- **Error**: `ApiException<AssignLicensesToDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AssignLicensesToDevicesRequest` | `src/Verizon/Requests/SoftwareManagementLicensesV1/AssignLicensesToDevicesRequest.cs` |
| `V1LicensesAssignedRemovedRequest` | `src/Verizon/Models/V1LicensesAssignedRemovedRequest.cs` |
| `V1LicensesAssignedRemovedResult` | `src/Verizon/Models/V1LicensesAssignedRemovedResult.cs` |
| `AssignLicensesToDevicesError` | `src/Verizon/Errors/AssignLicensesToDevicesError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### CreateListOfLicensesToRemove

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateListOfLicensesToRemove(CreateListOfLicensesToRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `Body`
- **Returns**: `V1ListOfLicensesToRemoveResult`
- **Error**: `ApiException<CreateListOfLicensesToRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateListOfLicensesToRemoveRequest` | `src/Verizon/Requests/SoftwareManagementLicensesV1/CreateListOfLicensesToRemoveRequest.cs` |
| `V1ListOfLicensesToRemoveRequest` | `src/Verizon/Models/V1ListOfLicensesToRemoveRequest.cs` |
| `V1ListOfLicensesToRemoveResult` | `src/Verizon/Models/V1ListOfLicensesToRemoveResult.cs` |
| `CreateListOfLicensesToRemoveError` | `src/Verizon/Errors/CreateListOfLicensesToRemoveError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### DeleteListOfLicensesToRemove

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteListOfLicensesToRemove(DeleteListOfLicensesToRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteListOfLicensesToRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteListOfLicensesToRemoveRequest` | `src/Verizon/Requests/SoftwareManagementLicensesV1/DeleteListOfLicensesToRemoveRequest.cs` |
| `DeleteListOfLicensesToRemoveError` | `src/Verizon/Errors/DeleteListOfLicensesToRemoveError.cs` |

### ListLicensesToRemove

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListLicensesToRemove(ListLicensesToRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `StartIndex`
- **Returns**: `V1ListOfLicensesToRemove`
- **Error**: `ApiException<ListLicensesToRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListLicensesToRemoveRequest` | `src/Verizon/Requests/SoftwareManagementLicensesV1/ListLicensesToRemoveRequest.cs` |
| `V1ListOfLicensesToRemove` | `src/Verizon/Models/V1ListOfLicensesToRemove.cs` |
| `ListLicensesToRemoveError` | `src/Verizon/Errors/ListLicensesToRemoveError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

### RemoveLicensesFromDevices

- **Server group**: `SoftwareManagementV1`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RemoveLicensesFromDevices(RemoveLicensesFromDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `Body`
- **Returns**: `V1LicensesAssignedRemovedResult`
- **Error**: `ApiException<RemoveLicensesFromDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV1Result(out FotaV1Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveLicensesFromDevicesRequest` | `src/Verizon/Requests/SoftwareManagementLicensesV1/RemoveLicensesFromDevicesRequest.cs` |
| `V1LicensesAssignedRemovedRequest` | `src/Verizon/Models/V1LicensesAssignedRemovedRequest.cs` |
| `V1LicensesAssignedRemovedResult` | `src/Verizon/Models/V1LicensesAssignedRemovedResult.cs` |
| `RemoveLicensesFromDevicesError` | `src/Verizon/Errors/RemoveLicensesFromDevicesError.cs` |
| `FotaV1Result` | `src/Verizon/Models/FotaV1Result.cs` |

