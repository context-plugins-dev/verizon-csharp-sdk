<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsNotificationGroups — operations

Accessor: `client.SensorInsightsNotificationGroups` · Source: `src/Verizon/Api/SensorInsightsNotificationGroups.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsAddUsersToNotificationGroupRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsAddUsersToNotificationGroupRequest(SensorInsightsAddUsersToNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SensorInsightsAddUsersToNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsAddUsersToNotificationGroupRequest` | `src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsAddUsersToNotificationGroupRequest.cs` |
| `DtoAddUsersToNotificationGroupRequest` | `src/Verizon/Models/DtoAddUsersToNotificationGroupRequest.cs` |
| `SensorInsightsAddUsersToNotificationGroupRequestError` | `src/Verizon/Errors/SensorInsightsAddUsersToNotificationGroupRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsCreateNotificationGroupRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsCreateNotificationGroupRequest(SensorInsightsCreateNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoNotificationGroupResponseEntity`
- **Error**: `ApiException<SensorInsightsCreateNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsCreateNotificationGroupRequest` | `src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsCreateNotificationGroupRequest.cs` |
| `DtoCreateNotificationGroupRequest` | `src/Verizon/Models/DtoCreateNotificationGroupRequest.cs` |
| `DtoNotificationGroupResponseEntity` | `src/Verizon/Models/DtoNotificationGroupResponseEntity.cs` |
| `SensorInsightsCreateNotificationGroupRequestError` | `src/Verizon/Errors/SensorInsightsCreateNotificationGroupRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsDeleteNotificationGroup

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsDeleteNotificationGroup(SensorInsightsDeleteNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Payload`
- **Query params (wire ← C#)**: `payload` ← `Payload`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SensorInsightsDeleteNotificationGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsDeleteNotificationGroupRequest` | `src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsDeleteNotificationGroupRequest.cs` |
| `DtoDeleteNotificationGroupRequest` | `src/Verizon/Models/DtoDeleteNotificationGroupRequest.cs` |
| `SensorInsightsDeleteNotificationGroupError` | `src/Verizon/Errors/SensorInsightsDeleteNotificationGroupError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |

### SensorInsightsListNotificationGroupRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsListNotificationGroupRequest(SensorInsightsListNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DtoNotificationGroupResponseEntity>`
- **Error**: `ApiException<SensorInsightsListNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsListNotificationGroupRequest` | `src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsListNotificationGroupRequest.cs` |
| `DtoListNotificationGroupRequest` | `src/Verizon/Models/DtoListNotificationGroupRequest.cs` |
| `DtoNotificationGroupResponseEntity` | `src/Verizon/Models/DtoNotificationGroupResponseEntity.cs` |
| `SensorInsightsListNotificationGroupRequestError` | `src/Verizon/Errors/SensorInsightsListNotificationGroupRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsRemoveUsersFromNotificationGroupRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsRemoveUsersFromNotificationGroupRequest(SensorInsightsRemoveUsersFromNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SensorInsightsRemoveUsersFromNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsRemoveUsersFromNotificationGroupRequest` | `src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsRemoveUsersFromNotificationGroupRequest.cs` |
| `DtoRemoveUsersFromNotificationGroupRequest` | `src/Verizon/Models/DtoRemoveUsersFromNotificationGroupRequest.cs` |
| `SensorInsightsRemoveUsersFromNotificationGroupRequestError` | `src/Verizon/Errors/SensorInsightsRemoveUsersFromNotificationGroupRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

### SensorInsightsUpdateNotificationGroupRequest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SensorInsightsUpdateNotificationGroupRequest(SensorInsightsUpdateNotificationGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DtoNotificationGroupResponseEntity`
- **Error**: `ApiException<SensorInsightsUpdateNotificationGroupRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SensorInsightsUpdateNotificationGroupRequest` | `src/Verizon/Requests/SensorInsightsNotificationGroups/SensorInsightsUpdateNotificationGroupRequest.cs` |
| `DtoUpdateNotificationGroupRequest` | `src/Verizon/Models/DtoUpdateNotificationGroupRequest.cs` |
| `DtoNotificationGroupResponseEntity` | `src/Verizon/Models/DtoNotificationGroupResponseEntity.cs` |
| `SensorInsightsUpdateNotificationGroupRequestError` | `src/Verizon/Errors/SensorInsightsUpdateNotificationGroupRequestError.cs` |
| `ManagementError400` | `src/Verizon/Models/ManagementError400.cs` |
| `ManagementError` | `src/Verizon/Models/ManagementError.cs` |
| `ManagementError403` | `src/Verizon/Models/ManagementError403.cs` |
| `ManagementError404` | `src/Verizon/Models/ManagementError404.cs` |
| `ManagementError500` | `src/Verizon/Models/ManagementError500.cs` |

