using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ActivateServiceForDevices operation.
/// </summary>
public sealed record ActivateServiceForDevicesRequest
{
    /// <summary>
    /// Request for activating a service on devices.
    /// </summary>
    public required CarrierActivateRequest Body { get; init; }
}
