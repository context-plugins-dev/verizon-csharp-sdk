using Verizon.Models;

namespace Verizon.Requests.DeviceDiagnostics;

/// <summary>
/// The inputs of the DeviceReachabilityStatusUsingPost operation.
/// </summary>
public sealed record DeviceReachabilityStatusUsingPostRequest
{
    /// <summary>
    /// Retrieve Reachability Report Status for a device.
    /// </summary>
    public required NotificationReportStatusRequest Body { get; init; }
}
