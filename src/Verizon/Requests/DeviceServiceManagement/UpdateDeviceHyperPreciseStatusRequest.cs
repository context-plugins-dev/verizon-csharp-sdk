using Verizon.Models;

namespace Verizon.Requests.DeviceServiceManagement;

/// <summary>
/// The inputs of the UpdateDeviceHyperPreciseStatus operation.
/// </summary>
public sealed record UpdateDeviceHyperPreciseStatusRequest
{
    /// <summary>
    /// List of devices and hyper-precise required statuses.
    /// </summary>
    public required BullseyeServiceRequest Body { get; init; }
}
