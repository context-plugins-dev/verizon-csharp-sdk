using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UpdateDeviceId operation.
/// </summary>
public sealed record UpdateDeviceIdRequest
{
    /// <summary>
    /// Identifier type.
    /// </summary>
    public required string ServiceType { get; init; }

    /// <summary>
    /// Request to update device id.
    /// </summary>
    public required ChangeDeviceIdRequest Body { get; init; }
}
