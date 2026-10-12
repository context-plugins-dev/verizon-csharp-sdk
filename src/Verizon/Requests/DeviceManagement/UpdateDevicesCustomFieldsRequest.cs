using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UpdateDevicesCustomFields operation.
/// </summary>
public sealed record UpdateDevicesCustomFieldsRequest
{
    /// <summary>
    /// Request to update custom field of devices.
    /// </summary>
    public required CustomFieldsUpdateRequest Body { get; init; }
}
