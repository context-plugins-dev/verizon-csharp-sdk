using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the SuspendServiceForDevices operation.
/// </summary>
public sealed record SuspendServiceForDevicesRequest
{
    /// <summary>
    /// Request to suspend service for one or more devices.
    /// </summary>
    public required CarrierActionsRequest Body { get; init; }
}
