using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the AddDevices operation.
/// </summary>
public sealed record AddDevicesOperationRequest
{
    /// <summary>
    /// Devices to add.
    /// </summary>
    public required AddDevicesRequest Body { get; init; }
}
