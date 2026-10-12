using Verizon.Models;

namespace Verizon.Requests.DeviceReports;

/// <summary>
/// The inputs of the CalculateAggregatedReportSynchronous operation.
/// </summary>
public sealed record CalculateAggregatedReportSynchronousRequest
{
    /// <summary>
    /// Aggregated report request.
    /// </summary>
    public required AggregateSessionReportRequest Body { get; init; }
}
