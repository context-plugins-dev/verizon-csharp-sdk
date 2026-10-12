<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceRoleController — operations

Accessor: `client.DeviceRoleController` · Source: `src/Verizon/Api/DeviceRoleController.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAclRulesByVendorId

- **Server group**: `ImpServer`
- **Auth**: `options.ThingspaceOauth` AND `options.SessionToken`
- **Signature**: `GetAclRulesByVendorId(GetAclRulesByVendorIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VendorId`
- **Query params (wire ← C#)**: `VendorID` ← `VendorId`
- **Returns**: `IReadOnlyList<DeviceRole>`
- **Error**: `ApiException<GetAclRulesByVendorIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetString(out string)` [400, 401, 403, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAclRulesByVendorIdRequest` | `src/Verizon/Requests/DeviceRoleController/GetAclRulesByVendorIdRequest.cs` |
| `DeviceRole` | `src/Verizon/Models/DeviceRole.cs` |
| `GetAclRulesByVendorIdError` | `src/Verizon/Errors/GetAclRulesByVendorIdError.cs` |

