using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the CheckDevicesAvailabilityForActivation operation.
/// </summary>
public sealed record CheckDevicesAvailabilityForActivationRequest
{
    /// <summary>
    /// Request to check if devices can be activated or not.
    /// </summary>
    public required DeviceActivationRequest Body { get; init; }
}
