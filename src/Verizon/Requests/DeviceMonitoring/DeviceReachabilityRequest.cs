using Verizon.Models;

namespace Verizon.Requests.DeviceMonitoring;

/// <summary>
/// The inputs of the DeviceReachability operation.
/// </summary>
public sealed record DeviceReachabilityRequest
{
    /// <summary>
    /// Create Reachability Report Request
    /// </summary>
    public required NotificationReportRequest Body { get; init; }
}
