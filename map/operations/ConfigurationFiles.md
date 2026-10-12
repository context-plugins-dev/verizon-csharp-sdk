<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConfigurationFiles — operations

Accessor: `client.ConfigurationFiles` · Source: `src/Verizon/Api/ConfigurationFiles.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetListOfFiles

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetListOfFiles(GetListOfFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `DistributionType`
- **Query params (wire ← C#)**: `distributionType` ← `DistributionType`
- **Returns**: `RetrievesAvailableFilesResponseList`
- **Error**: `ApiException<GetListOfFilesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetListOfFilesRequest` | `src/Verizon/Requests/ConfigurationFiles/GetListOfFilesRequest.cs` |
| `RetrievesAvailableFilesResponseList` | `src/Verizon/Models/RetrievesAvailableFilesResponseList.cs` |
| `GetListOfFilesError` | `src/Verizon/Errors/GetListOfFilesError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

### UploadConfigFile

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UploadConfigFile(UploadConfigFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Returns**: `UploadConfigurationFilesResponse`
- **Error**: `ApiException<UploadConfigFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadConfigFileRequest` | `src/Verizon/Requests/ConfigurationFiles/UploadConfigFileRequest.cs` |
| `UploadConfigurationFilesResponse` | `src/Verizon/Models/UploadConfigurationFilesResponse.cs` |
| `UploadConfigFileError` | `src/Verizon/Errors/UploadConfigFileError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

