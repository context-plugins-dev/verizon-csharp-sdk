using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDevices;

/// <summary>
/// The inputs of the SensorInsightsListDevicesRequest operation.
/// </summary>
public sealed record SensorInsightsListDevicesRequest
{
    /// <summary>
    /// List all device details on an account
    /// </summary>
    public required DtoListDevicesRequest Body { get; init; }
}
