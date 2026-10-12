<!-- Generated file — do not edit; regenerated with the SDK. -->

# MapMessageController — operations

Accessor: `client.MapMessageController` · Source: `src/Verizon/Api/MapMessageController.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMapMessage

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `DeleteMapMessage(DeleteMapMessageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RegionId`, `I10Nid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMapMessageError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 404, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMapMessageRequest` | `src/Verizon/Requests/MapMessageController/DeleteMapMessageRequest.cs` |
| `DeleteMapMessageError` | `src/Verizon/Errors/DeleteMapMessageError.cs` |
| `MdmErrorResponse` | `src/Verizon/Models/MdmErrorResponse.cs` |

### DownloadMapMessages

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `DownloadMapMessages(DownloadMapMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Geofence`, `VendorId`
- **Query params (wire ← C#)**: `Geofence` ← `Geofence`
- **Returns**: `string`
- **Error**: `ApiException<DownloadMapMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 404, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadMapMessagesRequest` | `src/Verizon/Requests/MapMessageController/DownloadMapMessagesRequest.cs` |
| `GeofencePolygon` | `src/Verizon/Models/GeofencePolygon.cs` |
| `DownloadMapMessagesError` | `src/Verizon/Errors/DownloadMapMessagesError.cs` |
| `MdmErrorResponse` | `src/Verizon/Models/MdmErrorResponse.cs` |

### IngestMapMessages

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `IngestMapMessages(IngestMapMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`, `Body`
- **Returns**: `string`
- **Error**: `ApiException<IngestMapMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 405, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IngestMapMessagesRequest` | `src/Verizon/Requests/MapMessageController/IngestMapMessagesRequest.cs` |
| `EtxMessageStandardEnum` | `src/Verizon/Models/Enums/EtxMessageStandardEnum.cs` |
| `EtxMapDataIngestRequest` | `src/Verizon/Models/EtxMapDataIngestRequest.cs` |
| `IngestMapMessagesError` | `src/Verizon/Errors/IngestMapMessagesError.cs` |
| `MdmErrorResponse` | `src/Verizon/Models/MdmErrorResponse.cs` |

### QueryMapMessages

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `QueryMapMessages(QueryMapMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`, `Body`
- **Returns**: `IReadOnlyList<object>`
- **Error**: `ApiException<QueryMapMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 405, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryMapMessagesRequest` | `src/Verizon/Requests/MapMessageController/QueryMapMessagesRequest.cs` |
| `MapDataQueryRequest` | `src/Verizon/Models/AnyOf/MapDataQueryRequest.cs` |
| `QueryMapMessagesError` | `src/Verizon/Errors/QueryMapMessagesError.cs` |
| `MdmErrorResponse` | `src/Verizon/Models/MdmErrorResponse.cs` |

