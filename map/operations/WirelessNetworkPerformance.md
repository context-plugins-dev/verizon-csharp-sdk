<!-- Generated file — do not edit; regenerated with the SDK. -->

# WirelessNetworkPerformance — operations

Accessor: `client.WirelessNetworkPerformance` · Source: `src/Verizon/Api/WirelessNetworkPerformance.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceExperience30DaysHistory

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceExperience30DaysHistory(DeviceExperience30DaysHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WnpRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeviceExperience30DaysHistoryRequest` | `src/Verizon/Requests/WirelessNetworkPerformance/DeviceExperience30DaysHistoryRequest.cs` |
| `GetDeviceExperienceScoreHistoryRequest` | `src/Verizon/Models/GetDeviceExperienceScoreHistoryRequest.cs` |
| `WnpRequestResponse` | `src/Verizon/Models/WnpRequestResponse.cs` |

### DeviceExperienceBulkLatest

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeviceExperienceBulkLatest(DeviceExperienceBulkLatestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WnpRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeviceExperienceBulkLatestRequest` | `src/Verizon/Requests/WirelessNetworkPerformance/DeviceExperienceBulkLatestRequest.cs` |
| `GetDeviceExperienceScoreBulkRequest` | `src/Verizon/Models/GetDeviceExperienceScoreBulkRequest.cs` |
| `WnpRequestResponse` | `src/Verizon/Models/WnpRequestResponse.cs` |

### Domestic4GAnd5GNationwideNetworkCoverage

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `Domestic4GAnd5GNationwideNetworkCoverage(Domestic4GAnd5GNationwideNetworkCoverageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WnpRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Domestic4GAnd5GNationwideNetworkCoverageRequest` | `src/Verizon/Requests/WirelessNetworkPerformance/Domestic4GAnd5GNationwideNetworkCoverageRequest.cs` |
| `M2MV1IntelligenceWirelessCoverageRequest` | `src/Verizon/Models/AnyOf/M2MV1IntelligenceWirelessCoverageRequest.cs` |
| `WnpRequestResponse` | `src/Verizon/Models/WnpRequestResponse.cs` |

### NearRealTimeNetworkConditions

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `NearRealTimeNetworkConditions(NearRealTimeNetworkConditionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WnpRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NearRealTimeNetworkConditionsRequest` | `src/Verizon/Requests/WirelessNetworkPerformance/NearRealTimeNetworkConditionsRequest.cs` |
| `GetNetworkConditionsRequest` | `src/Verizon/Models/GetNetworkConditionsRequest.cs` |
| `WnpRequestResponse` | `src/Verizon/Models/WnpRequestResponse.cs` |

### SiteProximity

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `SiteProximity(SiteProximityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WnpRequestResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteProximityRequest` | `src/Verizon/Requests/WirelessNetworkPerformance/SiteProximityRequest.cs` |
| `GetNetworkConditionsRequest` | `src/Verizon/Models/GetNetworkConditionsRequest.cs` |
| `WnpRequestResponse` | `src/Verizon/Models/WnpRequestResponse.cs` |

