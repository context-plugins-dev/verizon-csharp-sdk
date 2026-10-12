using Verizon.Models;

namespace Verizon.Requests.SensorInsightsSmartAlerts;

/// <summary>
/// The inputs of the SensorInsightsBulkUpdate operation.
/// </summary>
public sealed record SensorInsightsBulkUpdateRequest
{
    /// <summary>
    /// Bulk update smart alerts
    /// </summary>
    public required DtoBulkUpdate Body { get; init; }
}
