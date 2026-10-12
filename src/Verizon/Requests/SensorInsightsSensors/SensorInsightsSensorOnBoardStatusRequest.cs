using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSensors;

/// <summary>
/// The inputs of the SensorInsightsSensorOnBoardStatusRequest operation.
/// </summary>
public sealed record SensorInsightsSensorOnBoardStatusRequest
{
    /// <summary>
    /// Get the sensor's onboarding status
    /// </summary>
    public required DtoSensorOnBoardStatusRequest Body { get; init; }
}
