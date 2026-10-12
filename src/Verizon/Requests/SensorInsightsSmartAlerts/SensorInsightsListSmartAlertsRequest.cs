using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSmartAlerts;

/// <summary>
/// The inputs of the SensorInsightsListSmartAlertsRequest operation.
/// </summary>
public sealed record SensorInsightsListSmartAlertsRequest
{
    /// <summary>
    /// Retrieve a smart alert
    /// </summary>
    public required DtoListSmartAlertsRequest Body { get; init; }
}
