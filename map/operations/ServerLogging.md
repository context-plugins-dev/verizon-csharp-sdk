<!-- Generated file — do not edit; regenerated with the SDK. -->

# ServerLogging — operations

Accessor: `client.ServerLogging` · Source: `src/Verizon/Api/ServerLogging.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDeviceCheckInHistory

- **Server group**: `SoftwareManagementV2`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GetDeviceCheckInHistory(GetDeviceCheckInHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Account`, `DeviceId`
- **Returns**: `IReadOnlyList<CheckInHistoryItem>`
- **Error**: `ApiException<GetDeviceCheckInHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDeviceCheckInHistoryRequest` | `src/Verizon/Requests/ServerLogging/GetDeviceCheckInHistoryRequest.cs` |
| `CheckInHistoryItem` | `src/Verizon/Models/CheckInHistoryItem.cs` |
| `GetDeviceCheckInHistoryError` | `src/Verizon/Errors/GetDeviceCheckInHistoryError.cs` |
| `FotaV2Result` | `src/Verizon/Models/FotaV2Result.cs` |

