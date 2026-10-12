using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSensors;

/// <summary>
/// The inputs of the SensorInsightsOffBoardSensorRequest operation.
/// </summary>
public sealed record SensorInsightsOffBoardSensorRequest
{
    /// <summary>
    /// Offboard a sensor
    /// </summary>
    public required DtoOffBoardSensorRequest Body { get; init; }
}
