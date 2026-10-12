using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSensors;

/// <summary>
/// The inputs of the SensorInsightsOnBoardSensorRequest operation.
/// </summary>
public sealed record SensorInsightsOnBoardSensorRequest
{
    /// <summary>
    /// Onboarding a sensor
    /// </summary>
    public required DtoOnBoardSensorRequest Body { get; init; }
}
