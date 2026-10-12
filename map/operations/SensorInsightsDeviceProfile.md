<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsDeviceProfile — operations

Accessor: `client.SensorInsightsDeviceProfile` · Source: `src/Verizon/Api/SensorInsightsDeviceProfile.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateAProfile(CreateAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `ApiException<CreateAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAProfileRequest` | `src/Verizon/Requests/SensorInsightsDeviceProfile/CreateAProfileRequest.cs` |
| `DtoConfigurationProfile` | `src/Verizon/Models/DtoConfigurationProfile.cs` |
| `DtoProfileResponse` | `src/Verizon/Models/DtoProfileResponse.cs` |
| `CreateAProfileError` | `src/Verizon/Errors/CreateAProfileError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### DeleteAProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteAProfile(DeleteAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Deleterequest`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `ApiException<DeleteAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAProfileRequest` | `src/Verizon/Requests/SensorInsightsDeviceProfile/DeleteAProfileRequest.cs` |
| `DtoConfigurationProfileDelete` | `src/Verizon/Models/DtoConfigurationProfileDelete.cs` |
| `DtoProfileResponse` | `src/Verizon/Models/DtoProfileResponse.cs` |
| `DeleteAProfileError` | `src/Verizon/Errors/DeleteAProfileError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### QueryAProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `QueryAProfile(QueryAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `ApiException<QueryAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryAProfileRequest` | `src/Verizon/Requests/SensorInsightsDeviceProfile/QueryAProfileRequest.cs` |
| `ResourceResourceQuery` | `src/Verizon/Models/ResourceResourceQuery.cs` |
| `DtoProfileResponse` | `src/Verizon/Models/DtoProfileResponse.cs` |
| `QueryAProfileError` | `src/Verizon/Errors/QueryAProfileError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### UpdateAProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateAProfile(UpdateAProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DtoProfileResponse>`
- **Error**: `ApiException<UpdateAProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAProfileRequest` | `src/Verizon/Requests/SensorInsightsDeviceProfile/UpdateAProfileRequest.cs` |
| `DtoConfigurationProfilePath` | `src/Verizon/Models/DtoConfigurationProfilePath.cs` |
| `DtoProfileResponse` | `src/Verizon/Models/DtoProfileResponse.cs` |
| `UpdateAProfileError` | `src/Verizon/Errors/UpdateAProfileError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

