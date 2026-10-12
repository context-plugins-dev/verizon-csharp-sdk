<!-- Generated file — do not edit; regenerated with the SDK. -->

# Targets — operations

Accessor: `client.Targets` · Source: `src/Verizon/Api/Targets.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAzureCentralIoTApplication

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateAzureCentralIoTApplication(CreateAzureCentralIoTApplicationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BillingaccountId`, `Body`
- **Returns**: `CreateIoTApplicationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateAzureCentralIoTApplicationRequest` | `src/Verizon/Requests/Targets/CreateAzureCentralIoTApplicationRequest.cs` |
| `CreateIoTApplicationRequest` | `src/Verizon/Models/CreateIoTApplicationRequest.cs` |
| `CreateIoTApplicationResponse` | `src/Verizon/Models/CreateIoTApplicationResponse.cs` |

### CreateTarget

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `CreateTarget(CreateTargetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Target`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTargetOperationRequest` | `src/Verizon/Requests/Targets/CreateTargetOperationRequest.cs` |
| `CreateTargetRequest` | `src/Verizon/Models/CreateTargetRequest.cs` |
| `Target` | `src/Verizon/Models/Target.cs` |

### DeleteTarget

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `DeleteTarget(DeleteTargetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteTargetOperationRequest` | `src/Verizon/Requests/Targets/DeleteTargetOperationRequest.cs` |
| `DeleteTargetRequest` | `src/Verizon/Models/DeleteTargetRequest.cs` |

### GenerateTargetExternalId

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `GenerateTargetExternalId(GenerateTargetExternalIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GenerateExternalIdResult`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GenerateTargetExternalIdRequest` | `src/Verizon/Requests/Targets/GenerateTargetExternalIdRequest.cs` |
| `GenerateExternalIdRequest` | `src/Verizon/Models/GenerateExternalIdRequest.cs` |
| `GenerateExternalIdResult` | `src/Verizon/Models/GenerateExternalIdResult.cs` |

### QueryTarget

- **Server group**: `CloudConnector`
- **Auth**: `options.ThingspaceOauth` AND `options.VzM2MToken`
- **Signature**: `QueryTarget(QueryTargetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IReadOnlyList<Target>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QueryTargetOperationRequest` | `src/Verizon/Requests/Targets/QueryTargetOperationRequest.cs` |
| `QueryTargetRequest` | `src/Verizon/Models/QueryTargetRequest.cs` |
| `Target` | `src/Verizon/Models/Target.cs` |

