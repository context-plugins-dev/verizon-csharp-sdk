<!-- Generated file — do not edit; regenerated with the SDK. -->

# GlobalReporting — operations

Accessor: `client.GlobalReporting` · Source: `src/Verizon/Api/GlobalReporting.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceprovhistoryUsingPost

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceprovhistoryUsingPost(DeviceprovhistoryUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ESimRequestResponse`
- **Error**: `ApiException<DeviceprovhistoryUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceprovhistoryUsingPostRequest` | `src/Verizon/Requests/GlobalReporting/DeviceprovhistoryUsingPostRequest.cs` |
| `ESimProvhistoryRequest` | `src/Verizon/Models/ESimProvhistoryRequest.cs` |
| `ESimRequestResponse` | `src/Verizon/Models/ESimRequestResponse.cs` |
| `DeviceprovhistoryUsingPostError` | `src/Verizon/Errors/DeviceprovhistoryUsingPostError.cs` |
| `ESimRestErrorResponse` | `src/Verizon/Models/ESimRestErrorResponse.cs` |

### RetrieveGlobalList

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `RetrieveGlobalList(RetrieveGlobalListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ESimRequestResponse`
- **Error**: `ApiException<RetrieveGlobalListError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveGlobalListRequest` | `src/Verizon/Requests/GlobalReporting/RetrieveGlobalListRequest.cs` |
| `ESimGlobalDeviceList` | `src/Verizon/Models/ESimGlobalDeviceList.cs` |
| `ESimRequestResponse` | `src/Verizon/Models/ESimRequestResponse.cs` |
| `RetrieveGlobalListError` | `src/Verizon/Errors/RetrieveGlobalListError.cs` |
| `ESimRestErrorResponse` | `src/Verizon/Models/ESimRestErrorResponse.cs` |

