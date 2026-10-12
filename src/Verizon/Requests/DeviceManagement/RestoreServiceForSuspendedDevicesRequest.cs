using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the RestoreServiceForSuspendedDevices operation.
/// </summary>
public sealed record RestoreServiceForSuspendedDevicesRequest
{
    /// <summary>
    /// Request to restore services of one or more suspended devices.
    /// </summary>
    public required CarrierActionsRequest Body { get; init; }
}
