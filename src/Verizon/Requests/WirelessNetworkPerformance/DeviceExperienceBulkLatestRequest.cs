using Verizon.Models;

namespace Verizon.Requests.WirelessNetworkPerformance;

/// <summary>
/// The inputs of the DeviceExperienceBulkLatest operation.
/// </summary>
public sealed record DeviceExperienceBulkLatestRequest
{
    /// <summary>
    /// Request for bulk latest history details.
    /// </summary>
    public required GetDeviceExperienceScoreBulkRequest Body { get; init; }
}
