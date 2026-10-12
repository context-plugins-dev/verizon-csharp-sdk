using Verizon.Models;

namespace Verizon.Requests.DeviceReports;

/// <summary>
/// The inputs of the CalculateAggregatedReportAsynchronous operation.
/// </summary>
public sealed record CalculateAggregatedReportAsynchronousRequest
{
    /// <summary>
    /// Aggregated session report request.
    /// </summary>
    public required AggregateSessionReportRequest Body { get; init; }
}
