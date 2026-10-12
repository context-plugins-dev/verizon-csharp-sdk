<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountServiceController — operations

Accessor: `client.AccountServiceController` · Source: `src/Verizon/Api/AccountServiceController.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountInformationUsingGet

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountInformationUsingGet(GetAccountInformationUsingGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`
- **Returns**: `GetAccountInformationResponseforplanner`
- **Error**: `ApiException<GetAccountInformationUsingGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner)` [400, 403, 404, 406, 429] · `TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountInformationUsingGetRequest` | `src/Verizon/Requests/AccountServiceController/GetAccountInformationUsingGetRequest.cs` |
| `GetAccountInformationResponseforplanner` | `src/Verizon/Models/GetAccountInformationResponseforplanner.cs` |
| `GetAccountInformationUsingGetError` | `src/Verizon/Errors/GetAccountInformationUsingGetError.cs` |
| `RestErrorResponseforplanner` | `src/Verizon/Models/RestErrorResponseforplanner.cs` |
| `AuthRestErrorResponseforplanner` | `src/Verizon/Models/AuthRestErrorResponseforplanner.cs` |

