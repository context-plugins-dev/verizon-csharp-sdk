<!-- Generated file — do not edit; regenerated with the SDK. -->

# ThingSpaceQualityOfServiceApiActions — operations

Accessor: `client.ThingSpaceQualityOfServiceApiActions` · Source: `src/Verizon/Api/ThingSpaceQualityOfServiceApiActions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAThingSpaceQualityOfServiceApiSubscription

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateAThingSpaceQualityOfServiceApiSubscription(CreateAThingSpaceQualityOfServiceApiSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Success201`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateAThingSpaceQualityOfServiceApiSubscriptionRequest` | `src/Verizon/Requests/ThingSpaceQualityOfServiceApiActions/CreateAThingSpaceQualityOfServiceApiSubscriptionRequest.cs` |
| `SubscribeRequest` | `src/Verizon/Models/SubscribeRequest.cs` |
| `Success201` | `src/Verizon/Models/Success201.cs` |

### StopAThingSpaceQualityOfServiceApiSubscription

- **Server group**: `Thingspace`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `StopAThingSpaceQualityOfServiceApiSubscription(StopAThingSpaceQualityOfServiceApiSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `QosSubscriptionId`
- **Query params (wire ← C#)**: `accountName` ← `AccountName`, `qosSubscriptionId` ← `QosSubscriptionId`
- **Returns**: `Success201`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StopAThingSpaceQualityOfServiceApiSubscriptionRequest` | `src/Verizon/Requests/ThingSpaceQualityOfServiceApiActions/StopAThingSpaceQualityOfServiceApiSubscriptionRequest.cs` |
| `Success201` | `src/Verizon/Models/Success201.cs` |

