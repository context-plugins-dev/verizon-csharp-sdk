<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountDevices — operations

Accessor: `client.AccountDevices` · Source: `src/Verizon/Api/AccountDevices.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountDeviceInformation

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetAccountDeviceInformation(GetAccountDeviceInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`
- **Query params (wire ← C#)**: `lastSeenDeviceId` ← `LastSeenDeviceId`, `protocol` ← `Protocol`
- **Returns**: `V3AccountDeviceList`
- **Error**: `ApiException<GetAccountDeviceInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountDeviceInformationRequest` | `src/Verizon/Requests/AccountDevices/GetAccountDeviceInformationRequest.cs` |
| `DevicesProtocol` | `src/Verizon/Models/Enums/DevicesProtocol.cs` |
| `V3AccountDeviceList` | `src/Verizon/Models/V3AccountDeviceList.cs` |
| `GetAccountDeviceInformationError` | `src/Verizon/Errors/GetAccountDeviceInformationError.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

### ListAccountDevicesInformation

- **Server group**: `SoftwareManagementV3`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListAccountDevicesInformation(ListAccountDevicesInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Acc`, `Body`
- **Returns**: `DeviceListResult`
- **Error**: `ApiException<ListAccountDevicesInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV3Result(out FotaV3Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAccountDevicesInformationRequest` | `src/Verizon/Requests/AccountDevices/ListAccountDevicesInformationRequest.cs` |
| `DeviceImei` | `src/Verizon/Models/DeviceImei.cs` |
| `DeviceListResult` | `src/Verizon/Models/DeviceListResult.cs` |
| `ListAccountDevicesInformationError` | `src/Verizon/Errors/ListAccountDevicesInformationError.cs` |
| `FotaV3Result` | `src/Verizon/Models/FotaV3Result.cs` |

