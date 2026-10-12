using Verizon.Models;

namespace Verizon.Requests.WirelessNetworkPerformance;

/// <summary>
/// The inputs of the NearRealTimeNetworkConditions operation.
/// </summary>
public sealed record NearRealTimeNetworkConditionsRequest
{
    /// <summary>
    /// Request for current network health.
    /// </summary>
    public required GetNetworkConditionsRequest Body { get; init; }
}
