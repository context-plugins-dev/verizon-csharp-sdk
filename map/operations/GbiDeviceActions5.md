<!-- Generated file — do not edit; regenerated with the SDK. -->

# GbiDeviceActions5 — operations

Accessor: `client.GbiDeviceActions5` · Source: `src/Verizon/Api/GbiDeviceActions5.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BusinessInternetServiceplanchange

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` OR `options.VzM2MToken`
- **Signature**: `BusinessInternetServiceplanchange(BusinessInternetServiceplanchangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GbiRequestResponse5`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessInternetServiceplanchangeRequest` | `src/Verizon/Requests/GbiDeviceActions5/BusinessInternetServiceplanchangeRequest.cs` |
| `GbichangeRequest5` | `src/Verizon/Models/GbichangeRequest5.cs` |
| `GbiRequestResponse5` | `src/Verizon/Models/GbiRequestResponse5.cs` |

### BusinessInternetactivateUsingPost

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` OR `options.VzM2MToken`
- **Signature**: `BusinessInternetactivateUsingPost(BusinessInternetactivateUsingPostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GbiRequestResponse5`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessInternetactivateUsingPostRequest` | `src/Verizon/Requests/GbiDeviceActions5/BusinessInternetactivateUsingPostRequest.cs` |
| `GbiactivateRequest5` | `src/Verizon/Models/GbiactivateRequest5.cs` |
| `GbiRequestResponse5` | `src/Verizon/Models/GbiRequestResponse5.cs` |

### BusinessInternetlistDeviceInformation

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` OR `options.VzM2MToken`
- **Signature**: `BusinessInternetlistDeviceInformation(BusinessInternetlistDeviceInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GbideviceDetailsresponse5`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessInternetlistDeviceInformationRequest` | `src/Verizon/Requests/GbiDeviceActions5/BusinessInternetlistDeviceInformationRequest.cs` |
| `GbideviceId5` | `src/Verizon/Models/GbideviceId5.cs` |
| `GbideviceDetailsresponse5` | `src/Verizon/Models/GbideviceDetailsresponse5.cs` |

