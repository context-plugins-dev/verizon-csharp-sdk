using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSensors;

/// <summary>
/// The inputs of the SensorInsightsSensorOffBoardingStatusRequest operation.
/// </summary>
public sealed record SensorInsightsSensorOffBoardingStatusRequest
{
    /// <summary>
    /// Get a sensor's offboarding status
    /// </summary>
    public required DtoSensorOffBoardStatusRequest Body { get; init; }
}
