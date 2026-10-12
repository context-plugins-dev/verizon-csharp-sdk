<!-- Generated file — do not edit; regenerated with the SDK. -->

# CloudConnectorDevices — operations

Accessor: `client.CloudConnectorDevices` · Source: `src/Verizon/Api/CloudConnectorDevices.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDeviceFromAccount

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteDeviceFromAccount(DeleteDeviceFromAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteDeviceFromAccountRequest` | `src/Verizon/Requests/CloudConnectorDevices/DeleteDeviceFromAccountRequest.cs` |
| `RemoveDeviceRequest` | `src/Verizon/Models/RemoveDeviceRequest.cs` |

### FindDeviceByPropertyValues

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `FindDeviceByPropertyValues(FindDeviceByPropertyValuesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FindDeviceByPropertyResponseList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FindDeviceByPropertyValuesRequest` | `src/Verizon/Requests/CloudConnectorDevices/FindDeviceByPropertyValuesRequest.cs` |
| `QuerySubscriptionRequest` | `src/Verizon/Models/QuerySubscriptionRequest.cs` |
| `FindDeviceByPropertyResponseList` | `src/Verizon/Models/FindDeviceByPropertyResponseList.cs` |

### SearchDeviceEventHistory

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SearchDeviceEventHistory(SearchDeviceEventHistoryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchDeviceEventHistoryResponseList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchDeviceEventHistoryOperationRequest` | `src/Verizon/Requests/CloudConnectorDevices/SearchDeviceEventHistoryOperationRequest.cs` |
| `SearchDeviceEventHistoryRequest` | `src/Verizon/Models/SearchDeviceEventHistoryRequest.cs` |
| `SearchDeviceEventHistoryResponseList` | `src/Verizon/Models/SearchDeviceEventHistoryResponseList.cs` |

### SearchDevicesResourcesByPropertyValues

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SearchDevicesResourcesByPropertyValues(SearchDevicesResourcesByPropertyValuesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchDeviceByPropertyResponseList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchDevicesResourcesByPropertyValuesRequest` | `src/Verizon/Requests/CloudConnectorDevices/SearchDevicesResourcesByPropertyValuesRequest.cs` |
| `QuerySubscriptionRequest` | `src/Verizon/Models/QuerySubscriptionRequest.cs` |
| `SearchDeviceByPropertyResponseList` | `src/Verizon/Models/SearchDeviceByPropertyResponseList.cs` |

### SearchSensorReadings

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SearchSensorReadings(SearchSensorReadingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Fieldname`, `Body`
- **Returns**: `SearchSensorHistoryResponseList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchSensorReadingsRequest` | `src/Verizon/Requests/CloudConnectorDevices/SearchSensorReadingsRequest.cs` |
| `SearchSensorHistoryRequest` | `src/Verizon/Models/SearchSensorHistoryRequest.cs` |
| `SearchSensorHistoryResponseList` | `src/Verizon/Models/SearchSensorHistoryResponseList.cs` |

### UpdateDevicesConfigurationValue

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `UpdateDevicesConfigurationValue(UpdateDevicesConfigurationValueRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChangeConfigurationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateDevicesConfigurationValueRequest` | `src/Verizon/Requests/CloudConnectorDevices/UpdateDevicesConfigurationValueRequest.cs` |
| `ChangeConfigurationRequest` | `src/Verizon/Models/ChangeConfigurationRequest.cs` |
| `ChangeConfigurationResponse` | `src/Verizon/Models/ChangeConfigurationResponse.cs` |

