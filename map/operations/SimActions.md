<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimActions — operations

Accessor: `client.SimActions` · Source: `src/Verizon/Api/SimActions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Newactivatecode

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `Newactivatecode(NewactivatecodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ESimRequestResponse`
- **Error**: `ApiException<NewactivatecodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NewactivatecodeRequest` | `src/Verizon/Requests/SimActions/NewactivatecodeRequest.cs` |
| `ESimProfileRequest2` | `src/Verizon/Models/ESimProfileRequest2.cs` |
| `ESimRequestResponse` | `src/Verizon/Models/ESimRequestResponse.cs` |
| `NewactivatecodeError` | `src/Verizon/Errors/NewactivatecodeError.cs` |
| `ESimRestErrorResponse` | `src/Verizon/Models/ESimRestErrorResponse.cs` |

### SetactivateUsingPost

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SetactivateUsingPost(SetactivateUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ESimRequestResponse`
- **Error**: `ApiException<SetactivateUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetactivateUsingPostRequest` | `src/Verizon/Requests/SimActions/SetactivateUsingPostRequest.cs` |
| `ESimProfileRequest` | `src/Verizon/Models/ESimProfileRequest.cs` |
| `ESimRequestResponse` | `src/Verizon/Models/ESimRequestResponse.cs` |
| `SetactivateUsingPostError` | `src/Verizon/Errors/SetactivateUsingPostError.cs` |
| `ESimRestErrorResponse` | `src/Verizon/Models/ESimRestErrorResponse.cs` |

### SetdeactivateUsingPost

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SetdeactivateUsingPost(SetdeactivateUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ESimRequestResponse`
- **Error**: `ApiException<SetdeactivateUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetdeactivateUsingPostRequest` | `src/Verizon/Requests/SimActions/SetdeactivateUsingPostRequest.cs` |
| `ProfileRequest2` | `src/Verizon/Models/ProfileRequest2.cs` |
| `ESimRequestResponse` | `src/Verizon/Models/ESimRequestResponse.cs` |
| `SetdeactivateUsingPostError` | `src/Verizon/Errors/SetdeactivateUsingPostError.cs` |
| `ESimRestErrorResponse` | `src/Verizon/Models/ESimRestErrorResponse.cs` |

