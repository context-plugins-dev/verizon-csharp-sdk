<!-- Generated file — do not edit; regenerated with the SDK. -->

# Pwn — operations

Accessor: `client.Pwn` · Source: `src/Verizon/Api/Pwn.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangePwnDeviceIPaddress

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ChangePwnDeviceIPaddress(ChangePwnDeviceIPaddressOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChangePwnDeviceIpAddressResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceIPaddressOperationRequest` | `src/Verizon/Requests/Pwn/ChangePwnDeviceIPaddressOperationRequest.cs` |
| `ChangePwnDeviceIPaddressRequest` | `src/Verizon/Models/ChangePwnDeviceIPaddressRequest.cs` |
| `ChangePwnDeviceIpAddressResponse` | `src/Verizon/Models/ChangePwnDeviceIpAddressResponse.cs` |

### ChangePwnDeviceProfile

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ChangePwnDeviceProfile(ChangePwnDeviceProfileOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChangePwnDeviceProfileResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceProfileOperationRequest` | `src/Verizon/Requests/Pwn/ChangePwnDeviceProfileOperationRequest.cs` |
| `ChangePwnDeviceProfileRequest` | `src/Verizon/Models/ChangePwnDeviceProfileRequest.cs` |
| `ChangePwnDeviceProfileResponse` | `src/Verizon/Models/ChangePwnDeviceProfileResponse.cs` |

### ChangePwnDeviceStateActivate

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ChangePwnDeviceStateActivate(ChangePwnDeviceStateActivateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChangePwnDeviceStateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceStateActivateOperationRequest` | `src/Verizon/Requests/Pwn/ChangePwnDeviceStateActivateOperationRequest.cs` |
| `ChangePwnDeviceStateActivateRequest` | `src/Verizon/Models/ChangePwnDeviceStateActivateRequest.cs` |
| `ChangePwnDeviceStateResponse` | `src/Verizon/Models/ChangePwnDeviceStateResponse.cs` |

### ChangePwnDeviceStateDeactivate

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ChangePwnDeviceStateDeactivate(ChangePwnDeviceStateDeactivateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChangePwnDeviceStateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceStateDeactivateOperationRequest` | `src/Verizon/Requests/Pwn/ChangePwnDeviceStateDeactivateOperationRequest.cs` |
| `ChangePwnDeviceStateDeactivateRequest` | `src/Verizon/Models/ChangePwnDeviceStateDeactivateRequest.cs` |
| `ChangePwnDeviceStateResponse` | `src/Verizon/Models/ChangePwnDeviceStateResponse.cs` |

### GetProfileList

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetProfileList(GetProfileListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `PwnProfileList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetProfileListRequest` | `src/Verizon/Requests/Pwn/GetProfileListRequest.cs` |
| `PwnProfileList` | `src/Verizon/Models/PwnProfileList.cs` |

### GetPwnPerformanceConsent

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetPwnPerformanceConsent(GetPwnPerformanceConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `GetPwnPerformanceConsentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPwnPerformanceConsentRequest` | `src/Verizon/Requests/Pwn/GetPwnPerformanceConsentRequest.cs` |
| `GetPwnPerformanceConsentResponse` | `src/Verizon/Models/GetPwnPerformanceConsentResponse.cs` |

### KpiList

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `KpiList(KpiListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Aname`
- **Returns**: `KpiInfoList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `KpiListRequest` | `src/Verizon/Requests/Pwn/KpiListRequest.cs` |
| `KpiInfoList` | `src/Verizon/Models/KpiInfoList.cs` |

