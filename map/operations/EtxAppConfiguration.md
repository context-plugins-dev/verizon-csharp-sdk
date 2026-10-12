<!-- Generated file — do not edit; regenerated with the SDK. -->

# EtxAppConfiguration — operations

Accessor: `client.EtxAppConfiguration` · Source: `src/Verizon/Api/EtxAppConfiguration.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateConfiguration

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `CreateConfiguration(CreateConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`, `Body`
- **Returns**: `GeoFenceConfigurationResponse`
- **Error**: `ApiException<CreateConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [400, 403, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateConfigurationRequest` | `src/Verizon/Requests/EtxAppConfiguration/CreateConfigurationRequest.cs` |
| `GeoFenceConfigurationRequest` | `src/Verizon/Models/GeoFenceConfigurationRequest.cs` |
| `GeoFenceConfigurationResponse` | `src/Verizon/Models/GeoFenceConfigurationResponse.cs` |
| `CreateConfigurationError` | `src/Verizon/Errors/CreateConfigurationError.cs` |
| `ResponseError` | `src/Verizon/Models/ResponseError.cs` |

### DeleteConfiguration

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `DeleteConfiguration(DeleteConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `VendorId`
- **Query params (wire ← C#)**: `id` ← `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [403, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteConfigurationRequest` | `src/Verizon/Requests/EtxAppConfiguration/DeleteConfigurationRequest.cs` |
| `DeleteConfigurationError` | `src/Verizon/Errors/DeleteConfigurationError.cs` |
| `ResponseError` | `src/Verizon/Models/ResponseError.cs` |

### GetConfiguration

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `GetConfiguration(GetConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `VendorId`
- **Query params (wire ← C#)**: `id` ← `Id`
- **Returns**: `GeoFenceConfigurationResponse`
- **Error**: `ApiException<GetConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [403, 404, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetConfigurationRequest` | `src/Verizon/Requests/EtxAppConfiguration/GetConfigurationRequest.cs` |
| `GeoFenceConfigurationResponse` | `src/Verizon/Models/GeoFenceConfigurationResponse.cs` |
| `GetConfigurationError` | `src/Verizon/Errors/GetConfigurationError.cs` |
| `ResponseError` | `src/Verizon/Models/ResponseError.cs` |

### GetConfigurationList

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `GetConfigurationList(GetConfigurationListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`
- **Returns**: `IReadOnlyList<ConfigurationListItem>`
- **Error**: `ApiException<GetConfigurationListError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [403, 404, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetConfigurationListRequest` | `src/Verizon/Requests/EtxAppConfiguration/GetConfigurationListRequest.cs` |
| `ConfigurationListItem` | `src/Verizon/Models/ConfigurationListItem.cs` |
| `GetConfigurationListError` | `src/Verizon/Errors/GetConfigurationListError.cs` |
| `ResponseError` | `src/Verizon/Models/ResponseError.cs` |

### UpdateConfiguration

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `UpdateConfiguration(UpdateConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `VendorId`, `Body`
- **Query params (wire ← C#)**: `id` ← `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetResponseError(out ResponseError)` [400, 403, 404, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateConfigurationRequest` | `src/Verizon/Requests/EtxAppConfiguration/UpdateConfigurationRequest.cs` |
| `GeoFenceConfigurationUpdateRequest` | `src/Verizon/Models/GeoFenceConfigurationUpdateRequest.cs` |
| `UpdateConfigurationError` | `src/Verizon/Errors/UpdateConfigurationError.cs` |
| `ResponseError` | `src/Verizon/Models/ResponseError.cs` |

