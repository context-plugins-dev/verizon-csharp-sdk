using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSensors;

/// <summary>
/// The inputs of the SensorInsightsListSensorDevicesRequest operation.
/// </summary>
public sealed record SensorInsightsListSensorDevicesRequest
{
    /// <summary>
    /// List details of the sensors
    /// </summary>
    public required DtoListSensorDevicesRequest Body { get; init; }
}
