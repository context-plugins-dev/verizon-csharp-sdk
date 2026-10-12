using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the DeactivateServiceForDevices operation.
/// </summary>
public sealed record DeactivateServiceForDevicesRequest
{
    /// <summary>
    /// Request to deactivate service for one or more devices.
    /// </summary>
    public required CarrierDeactivateRequest Body { get; init; }
}
