<!-- Generated file — do not edit; regenerated with the SDK. -->

# Billing — operations

Accessor: `client.Billing` · Source: `src/Verizon/Api/Billing.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddAccount

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `AddAccount(AddAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ManagedAccountsAddResponse`
- **Error**: `ApiException<AddAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddAccountRequest` | `src/Verizon/Requests/Billing/AddAccountRequest.cs` |
| `ManagedAccountsAddRequest` | `src/Verizon/Models/ManagedAccountsAddRequest.cs` |
| `ManagedAccountsAddResponse` | `src/Verizon/Models/ManagedAccountsAddResponse.cs` |
| `AddAccountError` | `src/Verizon/Errors/AddAccountError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### CancelManagedAccountAction

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CancelManagedAccountAction(CancelManagedAccountActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ManagedAccountCancelResponse`
- **Error**: `ApiException<CancelManagedAccountActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelManagedAccountActionRequest` | `src/Verizon/Requests/Billing/CancelManagedAccountActionRequest.cs` |
| `ManagedAccountCancelRequest` | `src/Verizon/Models/ManagedAccountCancelRequest.cs` |
| `ManagedAccountCancelResponse` | `src/Verizon/Models/ManagedAccountCancelResponse.cs` |
| `CancelManagedAccountActionError` | `src/Verizon/Errors/CancelManagedAccountActionError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### ListManagedAccount

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ListManagedAccount(ListManagedAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountName`, `ServiceName`
- **Returns**: `ManagedAccountsGetAllResponse`
- **Error**: `ApiException<ListManagedAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListManagedAccountRequest` | `src/Verizon/Requests/Billing/ListManagedAccountRequest.cs` |
| `ManagedAccountsGetAllResponse` | `src/Verizon/Models/ManagedAccountsGetAllResponse.cs` |
| `ListManagedAccountError` | `src/Verizon/Errors/ListManagedAccountError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

### ManagedAccountAction

- **Server group**: `SubscriptionServer`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `ManagedAccountAction(ManagedAccountActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ManagedAccountsProvisionResponse`
- **Error**: `ApiException<ManagedAccountActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedAccountActionRequest` | `src/Verizon/Requests/Billing/ManagedAccountActionRequest.cs` |
| `ManagedAccountsProvisionRequest` | `src/Verizon/Models/ManagedAccountsProvisionRequest.cs` |
| `ManagedAccountsProvisionResponse` | `src/Verizon/Models/ManagedAccountsProvisionResponse.cs` |
| `ManagedAccountActionError` | `src/Verizon/Errors/ManagedAccountActionError.cs` |
| `DeviceLocationResult` | `src/Verizon/Models/DeviceLocationResult.cs` |

