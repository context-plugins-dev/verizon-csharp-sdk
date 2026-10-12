<!-- Generated file — do not edit; regenerated with the SDK. -->

# EtxRegistration — operations

Accessor: `client.EtxRegistration` · Source: `src/Verizon/Api/EtxRegistration.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEtxClientCertificate

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `GetEtxClientCertificate(GetEtxClientCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `VendorId`
- **Query params (wire ← C#)**: `ID` ← `Id`
- **Returns**: `ClientPersistenceResponse`
- **Error**: `ApiException<GetEtxClientCertificateError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 404, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEtxClientCertificateRequest` | `src/Verizon/Requests/EtxRegistration/GetEtxClientCertificateRequest.cs` |
| `EtxClientIdLookup` | `src/Verizon/Models/EtxClientIdLookup.cs` |
| `ClientPersistenceResponse` | `src/Verizon/Models/ClientPersistenceResponse.cs` |
| `GetEtxClientCertificateError` | `src/Verizon/Errors/GetEtxClientCertificateError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

### GetEtxConnectionUrl

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `GetEtxConnectionUrl(GetEtxConnectionUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`, `Body`
- **Returns**: `ConnectionResponse`
- **Error**: `ApiException<GetEtxConnectionUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEtxConnectionUrlRequest` | `src/Verizon/Requests/EtxRegistration/GetEtxConnectionUrlRequest.cs` |
| `ConnectionRequest` | `src/Verizon/Models/ConnectionRequest.cs` |
| `ConnectionResponse` | `src/Verizon/Models/ConnectionResponse.cs` |
| `GetEtxConnectionUrlError` | `src/Verizon/Errors/GetEtxConnectionUrlError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

### GetEtxConnectionUrlMultiMec

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `GetEtxConnectionUrlMultiMec(GetEtxConnectionUrlMultiMecRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`, `Body`
- **Returns**: `ConnectionResponseV3`
- **Error**: `ApiException<GetEtxConnectionUrlMultiMecError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEtxConnectionUrlMultiMecRequest` | `src/Verizon/Requests/EtxRegistration/GetEtxConnectionUrlMultiMecRequest.cs` |
| `ConnectionRequest` | `src/Verizon/Models/ConnectionRequest.cs` |
| `ConnectionResponseV3` | `src/Verizon/Models/ConnectionResponseV3.cs` |
| `GetEtxConnectionUrlMultiMecError` | `src/Verizon/Errors/GetEtxConnectionUrlMultiMecError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

### QueryEtxDevices

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `QueryEtxDevices(QueryEtxDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<DevicesResponse>`
- **Error**: `ApiException<QueryEtxDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `QueryEtxDevicesRequest` | `src/Verizon/Requests/EtxRegistration/QueryEtxDevicesRequest.cs` |
| `DevicesRequest` | `src/Verizon/Models/DevicesRequest.cs` |
| `DevicesResponse` | `src/Verizon/Models/DevicesResponse.cs` |
| `QueryEtxDevicesError` | `src/Verizon/Errors/QueryEtxDevicesError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

### RegisterEtxClient

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `RegisterEtxClient(RegisterEtxClientRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ClientRegistrationResponse`
- **Error**: `ApiException<RegisterEtxClientError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RegisterEtxClientRequest` | `src/Verizon/Requests/EtxRegistration/RegisterEtxClientRequest.cs` |
| `ClientRegistrationRequestV2` | `src/Verizon/Models/ClientRegistrationRequestV2.cs` |
| `ClientRegistrationResponse` | `src/Verizon/Models/ClientRegistrationResponse.cs` |
| `RegisterEtxClientError` | `src/Verizon/Errors/RegisterEtxClientError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

### RenewEtxClientCertificate

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `RenewEtxClientCertificate(RenewEtxClientCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`, `VendorId`
- **Returns**: `ClientRegistrationResponse`
- **Error**: `ApiException<RenewEtxClientCertificateError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RenewEtxClientCertificateRequest` | `src/Verizon/Requests/EtxRegistration/RenewEtxClientCertificateRequest.cs` |
| `ClientRegistrationResponse` | `src/Verizon/Models/ClientRegistrationResponse.cs` |
| `RenewEtxClientCertificateError` | `src/Verizon/Errors/RenewEtxClientCertificateError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

### UnregisterEtxClients

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `UnregisterEtxClients(UnregisterEtxClientsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceIDs`, `VendorId`
- **Query params (wire ← C#)**: `DeviceIDs` ← `DeviceIDs`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UnregisterEtxClientsError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnregisterEtxClientsRequest` | `src/Verizon/Requests/EtxRegistration/UnregisterEtxClientsRequest.cs` |
| `UnregisterEtxClientsError` | `src/Verizon/Errors/UnregisterEtxClientsError.cs` |
| `EtxRespondingError` | `src/Verizon/Models/EtxRespondingError.cs` |

