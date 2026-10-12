<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceCredentialManagement — operations

Accessor: `client.DeviceCredentialManagement` · Source: `src/Verizon/Api/DeviceCredentialManagement.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DropCredentials

- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DropCredentials(DropCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DropResponse`
- **Error**: `ApiException<DropCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DropCredentialsRequest` | `src/Verizon/Requests/DeviceCredentialManagement/DropCredentialsRequest.cs` |
| `CredentialsRequest` | `src/Verizon/Models/CredentialsRequest.cs` |
| `DropResponse` | `src/Verizon/Models/DropResponse.cs` |
| `DropCredentialsError` | `src/Verizon/Errors/DropCredentialsError.cs` |
| `ErrorResponseModel` | `src/Verizon/Models/ErrorResponseModel.cs` |

### GenerateCredentials

- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GenerateCredentials(GenerateCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GenerateResponse`
- **Error**: `ApiException<GenerateCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateCredentialsRequest` | `src/Verizon/Requests/DeviceCredentialManagement/GenerateCredentialsRequest.cs` |
| `CredentialsRequest` | `src/Verizon/Models/CredentialsRequest.cs` |
| `GenerateResponse` | `src/Verizon/Models/GenerateResponse.cs` |
| `GenerateCredentialsError` | `src/Verizon/Errors/GenerateCredentialsError.cs` |
| `ErrorResponseModel` | `src/Verizon/Models/ErrorResponseModel.cs` |

### ResetCredentials

- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ResetCredentials(ResetCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GenerateResponse`
- **Error**: `ApiException<ResetCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ResetCredentialsRequest` | `src/Verizon/Requests/DeviceCredentialManagement/ResetCredentialsRequest.cs` |
| `CredentialsRequest` | `src/Verizon/Models/CredentialsRequest.cs` |
| `GenerateResponse` | `src/Verizon/Models/GenerateResponse.cs` |
| `ResetCredentialsError` | `src/Verizon/Errors/ResetCredentialsError.cs` |
| `ErrorResponseModel` | `src/Verizon/Models/ErrorResponseModel.cs` |

### RetrieveCredentials

- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveCredentials(RetrieveCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RetrieveResponse`
- **Error**: `ApiException<RetrieveCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetNoContent(out RawError)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveCredentialsRequest` | `src/Verizon/Requests/DeviceCredentialManagement/RetrieveCredentialsRequest.cs` |
| `CredentialsRequest` | `src/Verizon/Models/CredentialsRequest.cs` |
| `RetrieveResponse` | `src/Verizon/Models/RetrieveResponse.cs` |
| `RetrieveCredentialsError` | `src/Verizon/Errors/RetrieveCredentialsError.cs` |
| `ErrorResponseModel` | `src/Verizon/Models/ErrorResponseModel.cs` |

