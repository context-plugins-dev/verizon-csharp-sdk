using Verizon.Models;

namespace Verizon.Requests.DeviceReports;

/// <summary>
/// The inputs of the GetSessionsReport operation.
/// </summary>
public sealed record GetSessionsReportRequest
{
    /// <summary>
    /// Request for sessions report.
    /// </summary>
    public required SessionReportRequest Body { get; init; }
}
