using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSmartAlertMetrics;

/// <summary>
/// The inputs of the Sensorinsightsmetricsquery operation.
/// </summary>
public sealed record SensorinsightsmetricsqueryRequest
{
    /// <summary>
    /// Daily period requested, up to 30 days.
    /// </summary>
    public required DtoQueryMetrics Body { get; init; }
}
