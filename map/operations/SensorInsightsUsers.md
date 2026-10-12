<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsUsers — operations

Accessor: `client.SensorInsightsUsers` · Source: `src/Verizon/Api/SensorInsightsUsers.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsCreateUserRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsCreateUserRequest(SensorInsightsCreateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ResourceUser`
- **Error**: `ApiException<SensorInsightsCreateUserRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsCreateUserRequest` | `src/Verizon/Requests/SensorInsightsUsers/SensorInsightsCreateUserRequest.cs` |
| `DtoCreateUserRequest` | `src/Verizon/Models/DtoCreateUserRequest.cs` |
| `ResourceUser` | `src/Verizon/Models/ResourceUser.cs` |
| `SensorInsightsCreateUserRequestError` | `src/Verizon/Errors/SensorInsightsCreateUserRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsDeleteUser

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsDeleteUser(SensorInsightsDeleteUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Deleterequestpayload`
- **Query params (wire ← C#)**: `deleterequestpayload` ← `Deleterequestpayload`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SensorInsightsDeleteUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsDeleteUserRequest` | `src/Verizon/Requests/SensorInsightsUsers/SensorInsightsDeleteUserRequest.cs` |
| `DtoDeleteUserRequest` | `src/Verizon/Models/DtoDeleteUserRequest.cs` |
| `SensorInsightsDeleteUserError` | `src/Verizon/Errors/SensorInsightsDeleteUserError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |

### SensorInsightsListUserRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListUserRequest(SensorInsightsListUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<ResourceUser>`
- **Error**: `ApiException<SensorInsightsListUserRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListUserRequest` | `src/Verizon/Requests/SensorInsightsUsers/SensorInsightsListUserRequest.cs` |
| `DtoListUserRequest` | `src/Verizon/Models/DtoListUserRequest.cs` |
| `ResourceUser` | `src/Verizon/Models/ResourceUser.cs` |
| `SensorInsightsListUserRequestError` | `src/Verizon/Errors/SensorInsightsListUserRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsUpdateUserRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsUpdateUserRequest(SensorInsightsUpdateUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ResourceUser`
- **Error**: `ApiException<SensorInsightsUpdateUserRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsUpdateUserRequest` | `src/Verizon/Requests/SensorInsightsUsers/SensorInsightsUpdateUserRequest.cs` |
| `DtoUpdateUserRequest` | `src/Verizon/Models/DtoUpdateUserRequest.cs` |
| `ResourceUser` | `src/Verizon/Models/ResourceUser.cs` |
| `SensorInsightsUpdateUserRequestError` | `src/Verizon/Errors/SensorInsightsUpdateUserRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

