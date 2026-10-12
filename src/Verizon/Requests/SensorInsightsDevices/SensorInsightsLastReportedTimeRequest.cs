using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDevices;

/// <summary>
/// The inputs of the SensorInsightsLastReportedTimeRequest operation.
/// </summary>
public sealed record SensorInsightsLastReportedTimeRequest
{
    /// <summary>
    /// Get the last reported information for a device
    /// </summary>
    public required DtoLastReportedTimeRequest Body { get; init; }
}
