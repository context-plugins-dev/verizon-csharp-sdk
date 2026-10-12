using Verizon.Models.AnyOf;

namespace Verizon.Requests.SensorInsightsDevices;

/// <summary>
/// The inputs of the SensorInsightsDeviceActionSetRequest operation.
/// </summary>
public sealed record SensorInsightsDeviceActionSetRequest
{
    /// <summary>
    /// Set device configuration
    /// </summary>
    public required DmV1DevicesActionsSetRequest Body { get; init; }
}
