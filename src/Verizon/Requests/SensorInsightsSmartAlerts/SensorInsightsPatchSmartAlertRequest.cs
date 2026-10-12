using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSmartAlerts;

/// <summary>
/// The inputs of the SensorInsightsPatchSmartAlertRequest operation.
/// </summary>
public sealed record SensorInsightsPatchSmartAlertRequest
{
    /// <summary>
    /// Partially update a smart alert
    /// </summary>
    public required DtoPatchSmartAlertRequest Body { get; init; }
}
