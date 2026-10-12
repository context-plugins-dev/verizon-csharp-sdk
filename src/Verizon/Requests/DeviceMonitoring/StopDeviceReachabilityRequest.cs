using Verizon.Models;

namespace Verizon.Requests.DeviceMonitoring;

/// <summary>
/// The inputs of the StopDeviceReachability operation.
/// </summary>
public sealed record StopDeviceReachabilityRequest
{
    /// <summary>
    /// Payload for the Stop Device Reachability monitors request.
    /// </summary>
    public required StopMonitorRequest Stopreachabilitypayload { get; init; }
}
