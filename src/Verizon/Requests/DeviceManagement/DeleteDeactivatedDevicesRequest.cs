using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the DeleteDeactivatedDevices operation.
/// </summary>
public sealed record DeleteDeactivatedDevicesRequest
{
    /// <summary>
    /// Devices to delete.
    /// </summary>
    public required DeleteDevicesRequest Body { get; init; }
}
