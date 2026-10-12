<!-- Generated file — do not edit; regenerated with the SDK. -->

# CloudConnectorSubscriptions — operations

Accessor: `client.CloudConnectorSubscriptions` · Source: `src/Verizon/Api/CloudConnectorSubscriptions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateSubscription

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Subscription`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateSubscriptionOperationRequest` | `src/Verizon/Requests/CloudConnectorSubscriptions/CreateSubscriptionOperationRequest.cs` |
| `CreateSubscriptionRequest` | `src/Verizon/Models/CreateSubscriptionRequest.cs` |
| `Subscription` | `src/Verizon/Models/Subscription.cs` |

### DeleteSubscription

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteSubscription(DeleteSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionOperationRequest` | `src/Verizon/Requests/CloudConnectorSubscriptions/DeleteSubscriptionOperationRequest.cs` |
| `DeleteSubscriptionRequest` | `src/Verizon/Models/DeleteSubscriptionRequest.cs` |

### QuerySubscription

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `QuerySubscription(QuerySubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<Subscription>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QuerySubscriptionOperationRequest` | `src/Verizon/Requests/CloudConnectorSubscriptions/QuerySubscriptionOperationRequest.cs` |
| `QuerySubscriptionRequest` | `src/Verizon/Models/QuerySubscriptionRequest.cs` |
| `Subscription` | `src/Verizon/Models/Subscription.cs` |

